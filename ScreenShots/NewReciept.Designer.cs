namespace ExchangeFinans.UserControls.Lager
{
    partial class CCTReceipts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cp_Main = new ExchangeFinans.CustomPanel();
            this.gvReceipt = new System.Windows.Forms.DataGridView();
            this.pnl_Title = new System.Windows.Forms.Panel();
            this.lbl_Rec = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cpl_Search = new ExchangeFinans.CustomPanel();
            this.lblCash = new System.Windows.Forms.Label();
            this.cmb_Tills = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.txt_RecData = new System.Windows.Forms.TextBox();
            this.txt_ToDate = new System.Windows.Forms.MaskedTextBox();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_RecSearch = new System.Windows.Forms.Label();
            this.txt_FromDate = new System.Windows.Forms.MaskedTextBox();
            this.lbl_CustData = new System.Windows.Forms.Label();
            this.lblTill = new System.Windows.Forms.Label();
            this.colReceiptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.cp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceipt)).BeginInit();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.cpl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // cp_Main
            // 
            this.cp_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.cp_Main.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.cp_Main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cp_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cp_Main.Controls.Add(this.gvReceipt);
            this.cp_Main.Controls.Add(this.pnl_Title);
            this.cp_Main.Controls.Add(this.cpl_Search);
            this.cp_Main.Curvature = 5;
            this.cp_Main.Location = new System.Drawing.Point(0, 0);
            this.cp_Main.Name = "cp_Main";
            this.cp_Main.Size = new System.Drawing.Size(1165, 748);
            this.cp_Main.TabIndex = 1;
            // 
            // gvReceipt
            // 
            this.gvReceipt.AllowUserToAddRows = false;
            this.gvReceipt.AllowUserToDeleteRows = false;
            this.gvReceipt.AllowUserToResizeColumns = false;
            this.gvReceipt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gvReceipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvReceipt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvReceipt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(233)))));
            this.gvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvReceipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvReceipt.ColumnHeadersHeight = 30;
            this.gvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReceiptId,
            this.colReceiptDate,
            this.colPersonalNumber,
            this.colAmount,
            this.colCustomerName,
            this.colPrint});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvReceipt.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvReceipt.EnableHeadersVisualStyles = false;
            this.gvReceipt.GridColor = System.Drawing.Color.Silver;
            this.gvReceipt.Location = new System.Drawing.Point(10, 80);
            this.gvReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.gvReceipt.MultiSelect = false;
            this.gvReceipt.Name = "gvReceipt";
            this.gvReceipt.ReadOnly = true;
            this.gvReceipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvReceipt.RowHeadersVisible = false;
            this.gvReceipt.RowTemplate.Height = 24;
            this.gvReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvReceipt.Size = new System.Drawing.Size(1140, 600);
            this.gvReceipt.TabIndex = 166;
            this.gvReceipt.TabStop = false;
            this.gvReceipt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvReceipt_CellContentClick);
            // 
            // pnl_Title
            // 
            this.pnl_Title.Controls.Add(this.lbl_Rec);
            this.pnl_Title.Controls.Add(this.pbImage);
            this.pnl_Title.Location = new System.Drawing.Point(10, 20);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(140, 36);
            this.pnl_Title.TabIndex = 165;
            // 
            // lbl_Rec
            // 
            this.lbl_Rec.AutoSize = true;
            this.lbl_Rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(106)))), ((int)(((byte)(100)))));
            this.lbl_Rec.Location = new System.Drawing.Point(30, 5);
            this.lbl_Rec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rec.Name = "lbl_Rec";
            this.lbl_Rec.Size = new System.Drawing.Size(73, 26);
            this.lbl_Rec.TabIndex = 162;
            this.lbl_Rec.Text = "Kvitto";
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImage.Image = global::ExchangeFinans.Properties.Resources.ic_doc;
            this.pbImage.Location = new System.Drawing.Point(1, 1);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(26, 34);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 161;
            this.pbImage.TabStop = false;
            // 
            // cpl_Search
            // 
            this.cpl_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(103)))), ((int)(((byte)(97)))));
            this.cpl_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(202)))), ((int)(((byte)(196)))));
            this.cpl_Search.Controls.Add(this.lblCash);
            this.cpl_Search.Controls.Add(this.cmb_Tills);
            this.cpl_Search.Controls.Add(this.btn_Cancel);
            this.cpl_Search.Controls.Add(this.btn_Search);
            this.cpl_Search.Controls.Add(this.dtToDate);
            this.cpl_Search.Controls.Add(this.txt_RecData);
            this.cpl_Search.Controls.Add(this.txt_ToDate);
            this.cpl_Search.Controls.Add(this.dtFromDate);
            this.cpl_Search.Controls.Add(this.lbl_RecSearch);
            this.cpl_Search.Controls.Add(this.txt_FromDate);
            this.cpl_Search.Controls.Add(this.lbl_CustData);
            this.cpl_Search.Controls.Add(this.lblTill);
            this.cpl_Search.Curvature = 5;
            this.cpl_Search.Location = new System.Drawing.Point(169, 20);
            this.cpl_Search.Name = "cpl_Search";
            this.cpl_Search.Size = new System.Drawing.Size(967, 50);
            this.cpl_Search.TabIndex = 0;
            // 
            // lblCash
            // 
            this.lblCash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblCash.Location = new System.Drawing.Point(294, 17);
            this.lblCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(42, 17);
            this.lblCash.TabIndex = 164;
            this.lblCash.Text = "Kassa";
            // 
            // cmb_Tills
            // 
            this.cmb_Tills.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Tills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tills.DropDownWidth = 125;
            this.cmb_Tills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Tills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cmb_Tills.ForeColor = System.Drawing.Color.Gray;
            this.cmb_Tills.FormattingEnabled = true;
            this.cmb_Tills.Items.AddRange(new object[] {
            "-Select-"});
            this.cmb_Tills.Location = new System.Drawing.Point(340, 15);
            this.cmb_Tills.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Tills.Name = "cmb_Tills";
            this.cmb_Tills.Size = new System.Drawing.Size(125, 21);
            this.cmb_Tills.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Cancel.BackgroundImage = global::ExchangeFinans.Properties.Resources.white_btn;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(203)))), ((int)(((byte)(195)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancel.Location = new System.Drawing.Point(858, 11);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 32);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "&Avbryt";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Search.BackgroundImage = global::ExchangeFinans.Properties.Resources.btn_search;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Location = new System.Drawing.Point(752, 9);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(90, 36);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "     Sök";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtToDate.CustomFormat = "yy/MM/dd";
            this.dtToDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtToDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(722, 13);
            this.dtToDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtToDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(18, 24);
            this.dtToDate.TabIndex = 5;
            this.dtToDate.TabStop = false;
            this.dtToDate.ValueChanged += new System.EventHandler(this.dtToDate_ValueChanged);
            // 
            // txt_RecData
            // 
            this.txt_RecData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_RecData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RecData.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RecData.Location = new System.Drawing.Point(111, 13);
            this.txt_RecData.Name = "txt_RecData";
            this.txt_RecData.Size = new System.Drawing.Size(170, 25);
            this.txt_RecData.TabIndex = 0;
            // 
            // txt_ToDate
            // 
            this.txt_ToDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_ToDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_ToDate.Location = new System.Drawing.Point(660, 13);
            this.txt_ToDate.Mask = "00\\/00\\/00";
            this.txt_ToDate.Name = "txt_ToDate";
            this.txt_ToDate.Size = new System.Drawing.Size(80, 24);
            this.txt_ToDate.TabIndex = 4;
            this.txt_ToDate.Leave += new System.EventHandler(this.txt_ToDate_Leave);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtFromDate.CustomFormat = "yy/MM/dd";
            this.dtFromDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFromDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(577, 13);
            this.dtFromDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtFromDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(18, 24);
            this.dtFromDate.TabIndex = 3;
            this.dtFromDate.TabStop = false;
            this.dtFromDate.ValueChanged += new System.EventHandler(this.dtFromDate_ValueChanged);
            // 
            // lbl_RecSearch
            // 
            this.lbl_RecSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_RecSearch.AutoSize = true;
            this.lbl_RecSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RecSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lbl_RecSearch.Location = new System.Drawing.Point(8, 17);
            this.lbl_RecSearch.Name = "lbl_RecSearch";
            this.lbl_RecSearch.Size = new System.Drawing.Size(97, 17);
            this.lbl_RecSearch.TabIndex = 2;
            this.lbl_RecSearch.Text = "Kvittonummer";
            // 
            // txt_FromDate
            // 
            this.txt_FromDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_FromDate.Culture = new System.Globalization.CultureInfo("es-US");
            this.txt_FromDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_FromDate.Location = new System.Drawing.Point(515, 13);
            this.txt_FromDate.Mask = "00\\/00\\/00";
            this.txt_FromDate.Name = "txt_FromDate";
            this.txt_FromDate.Size = new System.Drawing.Size(80, 24);
            this.txt_FromDate.TabIndex = 2;
            this.txt_FromDate.Leave += new System.EventHandler(this.txt_FromDate_Leave);
            // 
            // lbl_CustData
            // 
            this.lbl_CustData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_CustData.AutoSize = true;
            this.lbl_CustData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CustData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lbl_CustData.Location = new System.Drawing.Point(477, 17);
            this.lbl_CustData.Name = "lbl_CustData";
            this.lbl_CustData.Size = new System.Drawing.Size(35, 17);
            this.lbl_CustData.TabIndex = 4;
            this.lbl_CustData.Text = "Från";
            // 
            // lblTill
            // 
            this.lblTill.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTill.AutoSize = true;
            this.lblTill.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(224)))));
            this.lblTill.Location = new System.Drawing.Point(617, 17);
            this.lblTill.Name = "lblTill";
            this.lblTill.Size = new System.Drawing.Size(28, 17);
            this.lblTill.TabIndex = 4;
            this.lblTill.Text = "Till";
            // 
            // colReceiptId
            // 
            this.colReceiptId.DataPropertyName = "CreditCardReceiptId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colReceiptId.DefaultCellStyle = dataGridViewCellStyle3;
            this.colReceiptId.HeaderText = "ReceiptID";
            this.colReceiptId.Name = "colReceiptId";
            this.colReceiptId.ReadOnly = true;
            this.colReceiptId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colReceiptId.Visible = false;
            this.colReceiptId.Width = 220;
            // 
            // colReceiptDate
            // 
            this.colReceiptDate.DataPropertyName = "ReceiptDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "yy/MM/dd H:mm";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.colReceiptDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colReceiptDate.HeaderText = "DATUM";
            this.colReceiptDate.Name = "colReceiptDate";
            this.colReceiptDate.ReadOnly = true;
            this.colReceiptDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colReceiptDate.Width = 230;
            // 
            // colPersonalNumber
            // 
            this.colPersonalNumber.DataPropertyName = "PersonalNumber";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPersonalNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPersonalNumber.HeaderText = "PERSONNUMMER";
            this.colPersonalNumber.Name = "colPersonalNumber";
            this.colPersonalNumber.ReadOnly = true;
            this.colPersonalNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPersonalNumber.Width = 210;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAmount.HeaderText = "SUMMA";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colAmount.Width = 170;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "FirstName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.colCustomerName.DefaultCellStyle = dataGridViewCellStyle7;
            this.colCustomerName.HeaderText = "KUND";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCustomerName.Width = 450;
            // 
            // colPrint
            // 
            this.colPrint.HeaderText = "";
            this.colPrint.Image = global::ExchangeFinans.Properties.Resources.print;
            this.colPrint.Name = "colPrint";
            this.colPrint.ReadOnly = true;
            this.colPrint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colPrint.ToolTipText = "Print Receipt";
            this.colPrint.Width = 65;
            // 
            // NewReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cp_Main);
            this.Name = "NewReciept";
            this.Size = new System.Drawing.Size(1165, 745);
            this.Load += new System.EventHandler(this.NewReciept_Load);
            this.cp_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvReceipt)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            this.pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.cpl_Search.ResumeLayout(false);
            this.cpl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel cp_Main;
        private System.Windows.Forms.Panel pnl_Title;
        private System.Windows.Forms.Label lbl_Rec;
        private System.Windows.Forms.PictureBox pbImage;
        private CustomPanel cpl_Search;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.ComboBox cmb_Tills;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.TextBox txt_RecData;
        private System.Windows.Forms.MaskedTextBox txt_ToDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label lbl_RecSearch;
        private System.Windows.Forms.MaskedTextBox txt_FromDate;
        private System.Windows.Forms.Label lbl_CustData;
        private System.Windows.Forms.Label lblTill;
        private System.Windows.Forms.DataGridView gvReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewImageColumn colPrint;



    }
}
