namespace Grocery_Shop.Cashier
{
    partial class Cashier_Mainform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_Mainform));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Purchases_Table = new System.Windows.Forms.DataGridView();
            this.transaction_num = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.transaction_date = new System.Windows.Forms.Label();
            this.barcode_search_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trans_date_lbl = new System.Windows.Forms.Label();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_Product_txtbox = new System.Windows.Forms.TextBox();
            this.Products_Table = new System.Windows.Forms.DataGridView();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Coulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Coulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode_Coulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Coulmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.header_panel = new System.Windows.Forms.Panel();
            this.Left_Frame = new System.Windows.Forms.Panel();
            this.DailySales_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.user_lbl = new System.Windows.Forms.Label();
            this.Discount_Btn = new System.Windows.Forms.Button();
            this.Settle_Payment_Btn = new System.Windows.Forms.Button();
            this.logout_bnt = new System.Windows.Forms.Button();
            this.change_pass_btn = new System.Windows.Forms.Button();
            this.clear_cart_btn = new System.Windows.Forms.Button();
            this.Timer_Lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.FinalPrice_Lbl = new System.Windows.Forms.Label();
            this.FullPrice_Lbl = new System.Windows.Forms.Label();
            this.Discount_Lbl = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.ProductName_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_Cell = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Purchases_Table)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).BeginInit();
            this.Left_Frame.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(310, 118);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1135, 628);
            this.metroTabControl1.TabIndex = 38;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.Purchases_Table);
            this.metroTabPage1.Controls.Add(this.transaction_num);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.Add_btn);
            this.metroTabPage1.Controls.Add(this.transaction_date);
            this.metroTabPage1.Controls.Add(this.barcode_search_txtbox);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.trans_date_lbl);
            this.metroTabPage1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1127, 586);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "MAIN FORM";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Purchases_Table
            // 
            this.Purchases_Table.AllowUserToAddRows = false;
            this.Purchases_Table.AllowUserToDeleteRows = false;
            this.Purchases_Table.AllowUserToResizeColumns = false;
            this.Purchases_Table.AllowUserToResizeRows = false;
            this.Purchases_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Purchases_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Purchases_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Purchases_Table.BackgroundColor = System.Drawing.Color.White;
            this.Purchases_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Purchases_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Purchases_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Purchases_Table.ColumnHeadersHeight = 30;
            this.Purchases_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Purchases_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName_Col,
            this.Price,
            this.QTY,
            this.DISCOUNT,
            this.Total,
            this.Delete_Cell});
            this.Purchases_Table.EnableHeadersVisualStyles = false;
            this.Purchases_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.Purchases_Table.Location = new System.Drawing.Point(0, 177);
            this.Purchases_Table.Name = "Purchases_Table";
            this.Purchases_Table.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Purchases_Table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Purchases_Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Purchases_Table.Size = new System.Drawing.Size(1127, 409);
            this.Purchases_Table.TabIndex = 40;
            this.Purchases_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Purchases_Table_CellContentClick);
            this.Purchases_Table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Purchases_Table_CellValueChanged);
            // 
            // transaction_num
            // 
            this.transaction_num.Font = new System.Drawing.Font("Tahoma", 11F);
            this.transaction_num.ForeColor = System.Drawing.Color.Red;
            this.transaction_num.Location = new System.Drawing.Point(179, 10);
            this.transaction_num.Margin = new System.Windows.Forms.Padding(0);
            this.transaction_num.Name = "transaction_num";
            this.transaction_num.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.transaction_num.Size = new System.Drawing.Size(101, 34);
            this.transaction_num.TabIndex = 39;
            this.transaction_num.Text = "NUM";
            this.transaction_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label4.Size = new System.Drawing.Size(179, 43);
            this.label4.TabIndex = 38;
            this.label4.Text = "TRANSACTION NUM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Add_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Add_btn.Location = new System.Drawing.Point(674, 111);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(79, 27);
            this.Add_btn.TabIndex = 37;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // transaction_date
            // 
            this.transaction_date.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.transaction_date.ForeColor = System.Drawing.Color.Black;
            this.transaction_date.Location = new System.Drawing.Point(191, 53);
            this.transaction_date.Margin = new System.Windows.Forms.Padding(0);
            this.transaction_date.Name = "transaction_date";
            this.transaction_date.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.transaction_date.Size = new System.Drawing.Size(278, 34);
            this.transaction_date.TabIndex = 36;
            this.transaction_date.Text = "DATE";
            this.transaction_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barcode_search_txtbox
            // 
            this.barcode_search_txtbox.ForeColor = System.Drawing.Color.Gray;
            this.barcode_search_txtbox.Location = new System.Drawing.Point(160, 113);
            this.barcode_search_txtbox.Name = "barcode_search_txtbox";
            this.barcode_search_txtbox.Size = new System.Drawing.Size(508, 25);
            this.barcode_search_txtbox.TabIndex = 35;
            this.barcode_search_txtbox.Enter += new System.EventHandler(this.barcode_search_txtbox_Enter);
            this.barcode_search_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_search_txtbox_KeyDown);
            this.barcode_search_txtbox.Leave += new System.EventHandler(this.barcode_search_txtbox_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "BARCODE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trans_date_lbl
            // 
            this.trans_date_lbl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trans_date_lbl.ForeColor = System.Drawing.Color.Black;
            this.trans_date_lbl.Location = new System.Drawing.Point(3, 49);
            this.trans_date_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.trans_date_lbl.Name = "trans_date_lbl";
            this.trans_date_lbl.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.trans_date_lbl.Size = new System.Drawing.Size(179, 43);
            this.trans_date_lbl.TabIndex = 33;
            this.trans_date_lbl.Text = "TRANSACTION DATE";
            this.trans_date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.label1);
            this.metroTabPage2.Controls.Add(this.Search_Product_txtbox);
            this.metroTabPage2.Controls.Add(this.Products_Table);
            this.metroTabPage2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1127, 586);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "PRODUCT LIST";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(734, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "PRODUCT NAME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search_Product_txtbox
            // 
            this.Search_Product_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Product_txtbox.Location = new System.Drawing.Point(839, 31);
            this.Search_Product_txtbox.Name = "Search_Product_txtbox";
            this.Search_Product_txtbox.Size = new System.Drawing.Size(285, 25);
            this.Search_Product_txtbox.TabIndex = 22;
            this.Search_Product_txtbox.TextChanged += new System.EventHandler(this.Search_Product_txtbox_TextChanged);
            this.Search_Product_txtbox.Enter += new System.EventHandler(this.Search_Product_txtbox_Enter);
            this.Search_Product_txtbox.Leave += new System.EventHandler(this.Search_Product_txtbox_Leave);
            // 
            // Products_Table
            // 
            this.Products_Table.AllowUserToAddRows = false;
            this.Products_Table.AllowUserToDeleteRows = false;
            this.Products_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Products_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Products_Table.BackgroundColor = System.Drawing.Color.White;
            this.Products_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Products_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Products_Table.ColumnHeadersHeight = 30;
            this.Products_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Products_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.Product_Id,
            this.Name_Coulmn,
            this.Price_Coulmn,
            this.Barcode_Coulmn,
            this.Category_Coulmn,
            this.Brand,
            this.Available_Amount,
            this.dataGridViewImageColumn2});
            this.Products_Table.EnableHeadersVisualStyles = false;
            this.Products_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.Products_Table.Location = new System.Drawing.Point(3, 79);
            this.Products_Table.Name = "Products_Table";
            this.Products_Table.ReadOnly = true;
            this.Products_Table.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Products_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Products_Table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Products_Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Products_Table.Size = new System.Drawing.Size(1121, 504);
            this.Products_Table.TabIndex = 21;
            this.Products_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Products_Table_CellContentClick);
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "#";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 42;
            // 
            // Product_Id
            // 
            this.Product_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Product_Id.DataPropertyName = "Product_Id";
            this.Product_Id.HeaderText = "PCODE";
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            this.Product_Id.Width = 77;
            // 
            // Name_Coulmn
            // 
            this.Name_Coulmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_Coulmn.DataPropertyName = "Name";
            this.Name_Coulmn.HeaderText = "DESCRIPTION";
            this.Name_Coulmn.Name = "Name_Coulmn";
            this.Name_Coulmn.ReadOnly = true;
            // 
            // Price_Coulmn
            // 
            this.Price_Coulmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Price_Coulmn.DataPropertyName = "Price";
            this.Price_Coulmn.HeaderText = "PRICE";
            this.Price_Coulmn.Name = "Price_Coulmn";
            this.Price_Coulmn.ReadOnly = true;
            this.Price_Coulmn.Width = 71;
            // 
            // Barcode_Coulmn
            // 
            this.Barcode_Coulmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Barcode_Coulmn.DataPropertyName = "Barcode";
            this.Barcode_Coulmn.HeaderText = "BARCODE";
            this.Barcode_Coulmn.Name = "Barcode_Coulmn";
            this.Barcode_Coulmn.ReadOnly = true;
            this.Barcode_Coulmn.Width = 96;
            // 
            // Category_Coulmn
            // 
            this.Category_Coulmn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Category_Coulmn.DataPropertyName = "Category_Name";
            this.Category_Coulmn.HeaderText = "CATEGORY";
            this.Category_Coulmn.Name = "Category_Coulmn";
            this.Category_Coulmn.ReadOnly = true;
            this.Category_Coulmn.Width = 107;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Brand.DataPropertyName = "Brand_Name";
            this.Brand.HeaderText = "BRAND";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 78;
            // 
            // Available_Amount
            // 
            this.Available_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Available_Amount.DataPropertyName = "Cur_Amount";
            this.Available_Amount.HeaderText = "CUR_AMOUNT";
            this.Available_Amount.Name = "Available_Amount";
            this.Available_Amount.ReadOnly = true;
            this.Available_Amount.Width = 129;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn2.DataPropertyName = "Add";
            this.dataGridViewImageColumn2.FillWeight = 125F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 5;
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1457, 10);
            this.header_panel.TabIndex = 37;
            // 
            // Left_Frame
            // 
            this.Left_Frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Left_Frame.Controls.Add(this.DailySales_Btn);
            this.Left_Frame.Controls.Add(this.label2);
            this.Left_Frame.Controls.Add(this.user_lbl);
            this.Left_Frame.Controls.Add(this.Discount_Btn);
            this.Left_Frame.Controls.Add(this.Settle_Payment_Btn);
            this.Left_Frame.Controls.Add(this.logout_bnt);
            this.Left_Frame.Controls.Add(this.change_pass_btn);
            this.Left_Frame.Controls.Add(this.clear_cart_btn);
            this.Left_Frame.ForeColor = System.Drawing.Color.Maroon;
            this.Left_Frame.Location = new System.Drawing.Point(0, 3);
            this.Left_Frame.Name = "Left_Frame";
            this.Left_Frame.Size = new System.Drawing.Size(304, 894);
            this.Left_Frame.TabIndex = 36;
            this.Left_Frame.MouseEnter += new System.EventHandler(this.Left_Frame_MouseEnter);
            this.Left_Frame.MouseLeave += new System.EventHandler(this.Left_Frame_MouseLeave);
            // 
            // DailySales_Btn
            // 
            this.DailySales_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.DailySales_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.DailySales_Btn.FlatAppearance.BorderSize = 0;
            this.DailySales_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DailySales_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DailySales_Btn.ForeColor = System.Drawing.Color.White;
            this.DailySales_Btn.Image = ((System.Drawing.Image)(resources.GetObject("DailySales_Btn.Image")));
            this.DailySales_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DailySales_Btn.Location = new System.Drawing.Point(2, 473);
            this.DailySales_Btn.Name = "DailySales_Btn";
            this.DailySales_Btn.Size = new System.Drawing.Size(301, 43);
            this.DailySales_Btn.TabIndex = 12;
            this.DailySales_Btn.Text = "   DAILY SALES";
            this.DailySales_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DailySales_Btn.UseVisualStyleBackColor = false;
            this.DailySales_Btn.Click += new System.EventHandler(this.DailySales_Btn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(77, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "CASHIER ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_lbl
            // 
            this.user_lbl.Image = ((System.Drawing.Image)(resources.GetObject("user_lbl.Image")));
            this.user_lbl.Location = new System.Drawing.Point(77, 61);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(143, 123);
            this.user_lbl.TabIndex = 10;
            // 
            // Discount_Btn
            // 
            this.Discount_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Discount_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.Discount_Btn.FlatAppearance.BorderSize = 0;
            this.Discount_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discount_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Discount_Btn.ForeColor = System.Drawing.Color.White;
            this.Discount_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Discount_Btn.Image")));
            this.Discount_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Discount_Btn.Location = new System.Drawing.Point(2, 347);
            this.Discount_Btn.Name = "Discount_Btn";
            this.Discount_Btn.Size = new System.Drawing.Size(301, 43);
            this.Discount_Btn.TabIndex = 8;
            this.Discount_Btn.Text = "    PUT DISCONT";
            this.Discount_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Discount_Btn.UseVisualStyleBackColor = false;
            this.Discount_Btn.Click += new System.EventHandler(this.Discount_Btn_Click);
            // 
            // Settle_Payment_Btn
            // 
            this.Settle_Payment_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Settle_Payment_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.Settle_Payment_Btn.FlatAppearance.BorderSize = 0;
            this.Settle_Payment_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settle_Payment_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Settle_Payment_Btn.ForeColor = System.Drawing.Color.White;
            this.Settle_Payment_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Settle_Payment_Btn.Image")));
            this.Settle_Payment_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settle_Payment_Btn.Location = new System.Drawing.Point(2, 414);
            this.Settle_Payment_Btn.Name = "Settle_Payment_Btn";
            this.Settle_Payment_Btn.Size = new System.Drawing.Size(301, 43);
            this.Settle_Payment_Btn.TabIndex = 7;
            this.Settle_Payment_Btn.Text = "   SETTLE PAYMENT";
            this.Settle_Payment_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settle_Payment_Btn.UseVisualStyleBackColor = false;
            this.Settle_Payment_Btn.Click += new System.EventHandler(this.Settle_Payment_Btn_Click);
            // 
            // logout_bnt
            // 
            this.logout_bnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.logout_bnt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.logout_bnt.FlatAppearance.BorderSize = 0;
            this.logout_bnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_bnt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.logout_bnt.ForeColor = System.Drawing.Color.White;
            this.logout_bnt.Image = ((System.Drawing.Image)(resources.GetObject("logout_bnt.Image")));
            this.logout_bnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_bnt.Location = new System.Drawing.Point(1, 600);
            this.logout_bnt.Name = "logout_bnt";
            this.logout_bnt.Size = new System.Drawing.Size(301, 43);
            this.logout_bnt.TabIndex = 6;
            this.logout_bnt.Text = "   LOGOUT";
            this.logout_bnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_bnt.UseVisualStyleBackColor = false;
            this.logout_bnt.Click += new System.EventHandler(this.logout_bnt_Click);
            // 
            // change_pass_btn
            // 
            this.change_pass_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.change_pass_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.change_pass_btn.FlatAppearance.BorderSize = 0;
            this.change_pass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_pass_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.change_pass_btn.ForeColor = System.Drawing.Color.White;
            this.change_pass_btn.Image = ((System.Drawing.Image)(resources.GetObject("change_pass_btn.Image")));
            this.change_pass_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.change_pass_btn.Location = new System.Drawing.Point(2, 532);
            this.change_pass_btn.Name = "change_pass_btn";
            this.change_pass_btn.Size = new System.Drawing.Size(301, 43);
            this.change_pass_btn.TabIndex = 5;
            this.change_pass_btn.Text = "   CHANGE PASSWORD";
            this.change_pass_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.change_pass_btn.UseVisualStyleBackColor = false;
            this.change_pass_btn.Click += new System.EventHandler(this.change_pass_btn_Click);
            // 
            // clear_cart_btn
            // 
            this.clear_cart_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.clear_cart_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.clear_cart_btn.FlatAppearance.BorderSize = 0;
            this.clear_cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_cart_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.clear_cart_btn.ForeColor = System.Drawing.Color.White;
            this.clear_cart_btn.Image = ((System.Drawing.Image)(resources.GetObject("clear_cart_btn.Image")));
            this.clear_cart_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_cart_btn.Location = new System.Drawing.Point(3, 284);
            this.clear_cart_btn.Name = "clear_cart_btn";
            this.clear_cart_btn.Size = new System.Drawing.Size(301, 43);
            this.clear_cart_btn.TabIndex = 3;
            this.clear_cart_btn.Text = "    CLEAR  CART";
            this.clear_cart_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clear_cart_btn.UseVisualStyleBackColor = false;
            this.clear_cart_btn.Click += new System.EventHandler(this.clear_cart_btn_Click);
            // 
            // Timer_Lbl
            // 
            this.Timer_Lbl.BackColor = System.Drawing.Color.White;
            this.Timer_Lbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Timer_Lbl.Font = new System.Drawing.Font("Tahoma", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_Lbl.ForeColor = System.Drawing.Color.Black;
            this.Timer_Lbl.Location = new System.Drawing.Point(595, 12);
            this.Timer_Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Timer_Lbl.Name = "Timer_Lbl";
            this.Timer_Lbl.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.Timer_Lbl.Size = new System.Drawing.Size(450, 62);
            this.Timer_Lbl.TabIndex = 48;
            this.Timer_Lbl.Text = "00 00 00";
            this.Timer_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.FinalPrice_Lbl);
            this.panel2.Controls.Add(this.FullPrice_Lbl);
            this.panel2.Controls.Add(this.Discount_Lbl);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Location = new System.Drawing.Point(308, 752);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 145);
            this.panel2.TabIndex = 40;
            // 
            // FinalPrice_Lbl
            // 
            this.FinalPrice_Lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalPrice_Lbl.ForeColor = System.Drawing.Color.Black;
            this.FinalPrice_Lbl.Location = new System.Drawing.Point(1018, 107);
            this.FinalPrice_Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.FinalPrice_Lbl.Name = "FinalPrice_Lbl";
            this.FinalPrice_Lbl.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.FinalPrice_Lbl.Size = new System.Drawing.Size(90, 22);
            this.FinalPrice_Lbl.TabIndex = 47;
            this.FinalPrice_Lbl.Text = "0.0";
            this.FinalPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FinalPrice_Lbl.Click += new System.EventHandler(this.FinalPrice_Lbl_Click);
            // 
            // FullPrice_Lbl
            // 
            this.FullPrice_Lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullPrice_Lbl.ForeColor = System.Drawing.Color.Black;
            this.FullPrice_Lbl.Location = new System.Drawing.Point(1018, 11);
            this.FullPrice_Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.FullPrice_Lbl.Name = "FullPrice_Lbl";
            this.FullPrice_Lbl.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.FullPrice_Lbl.Size = new System.Drawing.Size(92, 32);
            this.FullPrice_Lbl.TabIndex = 46;
            this.FullPrice_Lbl.Text = "0.0";
            this.FullPrice_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Discount_Lbl
            // 
            this.Discount_Lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_Lbl.ForeColor = System.Drawing.Color.Black;
            this.Discount_Lbl.Location = new System.Drawing.Point(1018, 57);
            this.Discount_Lbl.Margin = new System.Windows.Forms.Padding(0);
            this.Discount_Lbl.Name = "Discount_Lbl";
            this.Discount_Lbl.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.Discount_Lbl.Size = new System.Drawing.Size(93, 28);
            this.Discount_Lbl.TabIndex = 44;
            this.Discount_Lbl.Text = "0.0";
            this.Discount_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(796, 107);
            this.lbl3.Margin = new System.Windows.Forms.Padding(0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lbl3.Size = new System.Drawing.Size(157, 22);
            this.lbl3.TabIndex = 43;
            this.lbl3.Text = "FINAL PRICE";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(795, 11);
            this.lbl1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lbl1.Size = new System.Drawing.Size(128, 32);
            this.lbl1.TabIndex = 42;
            this.lbl1.Text = "FULL PRICE";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(795, 57);
            this.lbl2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lbl2.Size = new System.Drawing.Size(100, 28);
            this.lbl2.TabIndex = 40;
            this.lbl2.Text = "DISCOUNT";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50;
            this.Close_Btn.Location = new System.Drawing.Point(1404, 12);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(41, 43);
            this.Close_Btn.TabIndex = 39;
            this.Close_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // ProductName_Col
            // 
            this.ProductName_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName_Col.DataPropertyName = "DESCRIPTION";
            this.ProductName_Col.HeaderText = "DESCRIPTION";
            this.ProductName_Col.Name = "ProductName_Col";
            this.ProductName_Col.ReadOnly = true;
            this.ProductName_Col.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Price.DataPropertyName = "PRICE";
            this.Price.HeaderText = "PRICE";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 71;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QTY.Width = 62;
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DISCOUNT.DataPropertyName = "DISCOUNT";
            this.DISCOUNT.HeaderText = "DISCOUNT";
            this.DISCOUNT.Name = "DISCOUNT";
            this.DISCOUNT.ReadOnly = true;
            this.DISCOUNT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DISCOUNT.Width = 105;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Total.DataPropertyName = "TOTAL_SALES";
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.Width = 78;
            // 
            // Delete_Cell
            // 
            this.Delete_Cell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Delete_Cell.DataPropertyName = "Delete";
            this.Delete_Cell.HeaderText = "";
            this.Delete_Cell.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Cell.Image")));
            this.Delete_Cell.Name = "Delete_Cell";
            this.Delete_Cell.ReadOnly = true;
            this.Delete_Cell.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete_Cell.Width = 5;
            // 
            // Cashier_Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 897);
            this.ControlBox = false;
            this.Controls.Add(this.Timer_Lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Close_Btn);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.Left_Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cashier_Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Purchases_Table)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).EndInit();
            this.Left_Frame.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Close_Btn;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView Purchases_Table;
        private System.Windows.Forms.Label transaction_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label transaction_date;
        private System.Windows.Forms.TextBox barcode_search_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trans_date_lbl;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_Product_txtbox;
        private System.Windows.Forms.DataGridView Products_Table;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Panel Left_Frame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.Button Discount_Btn;
        private System.Windows.Forms.Button Settle_Payment_Btn;
        private System.Windows.Forms.Button logout_bnt;
        private System.Windows.Forms.Button change_pass_btn;
        private System.Windows.Forms.Button clear_cart_btn;
        private System.Windows.Forms.Label Timer_Lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FinalPrice_Lbl;
        private System.Windows.Forms.Label FullPrice_Lbl;
        private System.Windows.Forms.Label Discount_Lbl;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button DailySales_Btn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Coulmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Coulmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode_Coulmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Coulmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Amount;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn Delete_Cell;
    }
}