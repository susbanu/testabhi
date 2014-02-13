using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExchangeFinans.Common;
using ExchangeFinans.Properties;
using EFDAL;
using System.Data.Common;
using EFDAL.Common;
using ExchangeFinans.Common.Constants;


namespace ExchangeFinans.UserControls.Lager
{
    public partial class CCTReceipts : BaseUserControl
    {
        #region user control's event

        public CCTReceipts()
        {
            InitializeComponent();
        }

        private void NewReciept_Load(object sender, EventArgs e)
        {
            BindTills();
            BindReciept();
        }

        #endregion

        #region control events
        private void btn_Search_Click(object sender, EventArgs e)
        {
            BindReciept();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_RecData.Text = string.Empty;
            txt_FromDate.Text = string.Empty;
            txt_ToDate.Text = string.Empty;
            gvReceipt.DataSource = null;
        }

        private void txt_ToDate_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_ToDate.Text.Replace("/", "")))
            {
                DateTime temp;
                temp = Utility.StringToDate(txt_ToDate.Text.Trim());
                if (temp == DateTime.MinValue)
                { MessageBox.Show(Resources.InvalidDate, Resources.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error); txt_ToDate.Focus(); }
                else try
                    {
                        dtToDate.Text = txt_ToDate.Text;
                    }
                    catch { MessageBox.Show(Resources.InvalidDate, Resources.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error); txt_ToDate.Focus(); }
            }
            else dtToDate.Checked = false;
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            dtToDate.MaxDate = DateTime.Now;
            txt_ToDate.Text = dtToDate.Text;
        }

        private void txt_FromDate_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_FromDate.Text.Replace("/", "")))
            {
                DateTime temp;
                temp = Utility.StringToDate(txt_FromDate.Text.Trim());
                if (temp == DateTime.MinValue)
                { MessageBox.Show(Resources.InvalidDate, Resources.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error); txt_FromDate.Focus(); }
                else try
                    {
                        dtFromDate.Text = txt_FromDate.Text;
                    }
                    catch { MessageBox.Show(Resources.InvalidDate, Resources.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error); txt_FromDate.Focus(); }
            }
            else dtFromDate.Checked = false;
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txt_FromDate.Text = dtFromDate.Text;
        }

        private void gvReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == this.colPrint.Index)
                {
                    #region Receipt Copy

                    PanelAccessibility(false);
                    PrintCopy(Convert.ToInt64(gvReceipt.Rows[e.RowIndex].Cells[this.colReceiptId.Index].Value));
                    PanelAccessibility(true);

                    #endregion
                }
            }
        }

        #endregion

        #region public private methods
        /// <summary>
        /// p
        /// </summary>
        private void BindTills()
        {
            TillsList lstTills = Tills.Search("AND BranchId = " + LoginUserInfo.BranchId);
            lstTills.Insert(0, new Tills() { TillNumber = Resources.AllItemText, TillId = 0 });
            cmb_Tills.DisplayMember = "TillNumber";
            cmb_Tills.ValueMember = "TillId";
            cmb_Tills.DataSource = lstTills;

            if (cmb_Tills.Items.Count > 0)
                cmb_Tills.SelectedValue = lstTills.Find(t => t.TillId == LoginUserInfo.TillId) != null ? LoginUserInfo.TillId : 0;
        }

        private void BindReciept()
        {
            DateTime dtStartDate = Utility.StringToDate(txt_FromDate.Text.Trim());
            DateTime dtEndDate = Utility.StringToDate(txt_ToDate.Text.Trim());
            int tillId = Convert.ToInt32(cmb_Tills.SelectedValue);

            if (dtStartDate != DateTime.MinValue && dtEndDate != DateTime.MinValue && dtStartDate > dtEndDate)
            {
                MessageBox.Show(Resources.InvalidDate, Resources.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AppResult appresult = CreditCardReceipt.CreditCardReceiptsForListing(txt_RecData.Text.Trim(), dtStartDate, dtEndDate, LoginUserInfo.BranchId, tillId);
            if (appresult.Result == AppsEnum.Result.Success)
            {
                if (appresult.DataSet.Tables[0].Rows.Count > 0)
                {
                    gvReceipt.AutoGenerateColumns = false;
                    gvReceipt.DataSource = appresult.DataSet.Tables[0];

                }
                else gvReceipt.DataSource = null;
            }
            else gvReceipt.DataSource = null;

        }

        private void PanelAccessibility(bool enable)
        {
            cp_Main.Enabled = enable;
        }

        private void PrintCopy(long CreditCardReceiptId)
        {
            DbConnection dbConn = Common.Utility.CreateConnection();
            bool isValid = true;
            string msg = string.Empty;
            DbTransaction dbTrans = dbConn.BeginTransaction(IsolationLevel.ReadCommitted);
            try
            {
                if (Utility.IsPrinterOK(Utility.GetValueByConfigkey(ConfigConst.PrinterName)))
                {
                    AppResult apRec = null;
                    CreditCardReceipt objCReditCardReceipt = new CreditCardReceipt(CreditCardReceiptId);
                    apRec = Print.PrintReceipts.printCardHolderReciept(objCReditCardReceipt, Utility.GetValueByConfigkey(ConfigConst.PrinterName));
                    if (apRec.Result == AppsEnum.Result.Success)
                    {
                        UpdatePrintedFlag(CreditCardReceiptId, ref isValid, ref msg);
                        if (isValid)
                        {
                            apRec = CreditCardReceipt.CreditCardReceiptSelectMerchantReceipt(CreditCardReceiptId);
                            if (apRec.Result == AppsEnum.Result.Success)
                            {
                                List<CreditCardReceipt> lstReceipts = ((List<CreditCardReceipt>)apRec.List);
                                if (lstReceipts.Count > 0)
                                {
                                    apRec = Print.PrintReceipts.printMerchantReciept(lstReceipts[0], Utility.GetValueByConfigkey(ConfigConst.PrinterName), PrintNeeded: true);
                                    if (apRec.Result.Equals(AppsEnum.Result.Success))
                                    {
                                        UpdatePrintedFlag(lstReceipts[0].CreditCardReceiptId, ref isValid, ref msg);
                                    }
                                    else
                                    {
                                        isValid = false; msg += apRec.ErrorMessage + "\n";
                                    }

                                }
                                else { isValid = false; msg += "Merchant Receipt Data Not Found.\n"; }
                            }
                            else { isValid = false; msg += apRec.ErrorText + "\n"; }
                        }
                    }
                    else { isValid = false; msg += apRec.ErrorMessage + "\n"; }

                    if (isValid) { dbTrans.Commit(); }

                    BindReciept();
                }
                else { MessageBox.Show(Resources.PrintetNotWorking, Resources.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }
            catch (Exception ex)
            {

                isValid = false;
                ErrorLog.Insert(ex);
                msg += ex.Message;
            }
            finally
            {
                if (!isValid)
                {
                    dbTrans.Rollback();
                    MessageBox.Show(msg, ExchangeFinans.Properties.Resources.MessageBoxTitle);
                }
                Common.Utility.DestroyConnection(dbConn);
            }
        }

        private void UpdatePrintedFlag(long CreditCardReceiptId, ref bool IsValid, ref string msg)
        {
            AppResult res = CreditCardReceipt.CreditCardReceiptUpdatePrintedReceipt(CreditCardReceiptId);
            if (res.Result == AppsEnum.Result.Error)
            {
                IsValid = false;
                msg += res.ErrorMessage + "\n";
            }
        }
        #endregion

    }
}

