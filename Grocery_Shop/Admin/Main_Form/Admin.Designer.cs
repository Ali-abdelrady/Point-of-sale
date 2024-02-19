namespace Grocery_Shop
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.header_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Left_Frame = new System.Windows.Forms.Panel();
            this.dashboard2 = new Grocery_Shop.Dashboard();
            this.userAccount_Form1 = new Grocery_Shop.UserAccount_Form();
            this.stockEntry_Form2 = new Grocery_Shop.StockEntry_Form();
            this.productList_Form2 = new Grocery_Shop.ProductList_Form();
            this.category_List2 = new Grocery_Shop.Category_List();
            this.brand_List2 = new Grocery_Shop.Brand_List();
            this.vendor_List1 = new Grocery_Shop.Vendor_List();
            this.records_Form2 = new Grocery_Shop.Records_Form();
            this.dashboard1 = new Grocery_Shop.Dashboard();
            this.SalesHistory_Btn = new System.Windows.Forms.Button();
            this.StoreDetails_Btn = new System.Windows.Forms.Button();
            this.Vendor_Btn = new System.Windows.Forms.Button();
            this.StockEntry_Btn = new System.Windows.Forms.Button();
            this.Records_Btn = new System.Windows.Forms.Button();
            this.Category_Btn = new System.Windows.Forms.Button();
            this.Brand_Btn = new System.Windows.Forms.Button();
            this.User_Btn = new System.Windows.Forms.Button();
            this.Logout_Btn = new System.Windows.Forms.Button();
            this.Product_Btn = new System.Windows.Forms.Button();
            this.Dashborad_Btn = new System.Windows.Forms.Button();
            this.user_lbl = new System.Windows.Forms.Label();
            this.Left_Frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1455, 10);
            this.header_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(68, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Left_Frame
            // 
            this.Left_Frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Left_Frame.Controls.Add(this.SalesHistory_Btn);
            this.Left_Frame.Controls.Add(this.StoreDetails_Btn);
            this.Left_Frame.Controls.Add(this.Vendor_Btn);
            this.Left_Frame.Controls.Add(this.StockEntry_Btn);
            this.Left_Frame.Controls.Add(this.Records_Btn);
            this.Left_Frame.Controls.Add(this.Category_Btn);
            this.Left_Frame.Controls.Add(this.Brand_Btn);
            this.Left_Frame.Controls.Add(this.User_Btn);
            this.Left_Frame.Controls.Add(this.Logout_Btn);
            this.Left_Frame.Controls.Add(this.Product_Btn);
            this.Left_Frame.Controls.Add(this.Dashborad_Btn);
            this.Left_Frame.Controls.Add(this.label1);
            this.Left_Frame.Controls.Add(this.user_lbl);
            this.Left_Frame.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Frame.Location = new System.Drawing.Point(0, 10);
            this.Left_Frame.Name = "Left_Frame";
            this.Left_Frame.Size = new System.Drawing.Size(304, 885);
            this.Left_Frame.TabIndex = 1;
            this.Left_Frame.MouseEnter += new System.EventHandler(this.Left_Frame_MouseEnter);
            this.Left_Frame.MouseLeave += new System.EventHandler(this.Left_Frame_MouseLeave);
            // 
            // dashboard2
            // 
            this.dashboard2.BackColor = System.Drawing.Color.White;
            this.dashboard2.Location = new System.Drawing.Point(307, 13);
            this.dashboard2.Name = "dashboard2";
            this.dashboard2.Size = new System.Drawing.Size(1148, 881);
            this.dashboard2.TabIndex = 11;
            this.dashboard2.Load += new System.EventHandler(this.dashboard2_Load);
            // 
            // userAccount_Form1
            // 
            this.userAccount_Form1.AutoSize = true;
            this.userAccount_Form1.BackColor = System.Drawing.Color.White;
            this.userAccount_Form1.ForeColor = System.Drawing.Color.Black;
            this.userAccount_Form1.Location = new System.Drawing.Point(307, 13);
            this.userAccount_Form1.Name = "userAccount_Form1";
            this.userAccount_Form1.Size = new System.Drawing.Size(1148, 881);
            this.userAccount_Form1.TabIndex = 10;
            // 
            // stockEntry_Form2
            // 
            this.stockEntry_Form2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockEntry_Form2.AutoSize = true;
            this.stockEntry_Form2.BackColor = System.Drawing.Color.White;
            this.stockEntry_Form2.ForeColor = System.Drawing.Color.Black;
            this.stockEntry_Form2.Location = new System.Drawing.Point(307, 13);
            this.stockEntry_Form2.Name = "stockEntry_Form2";
            this.stockEntry_Form2.Size = new System.Drawing.Size(1148, 881);
            this.stockEntry_Form2.TabIndex = 5;
            this.stockEntry_Form2.Load += new System.EventHandler(this.stockEntry_Form2_Load);
            // 
            // productList_Form2
            // 
            this.productList_Form2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productList_Form2.Location = new System.Drawing.Point(307, 13);
            this.productList_Form2.Name = "productList_Form2";
            this.productList_Form2.Size = new System.Drawing.Size(1148, 881);
            this.productList_Form2.TabIndex = 4;
            // 
            // category_List2
            // 
            this.category_List2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category_List2.Category_Id = 0;
            this.category_List2.Category_Name = null;
            this.category_List2.Location = new System.Drawing.Point(307, 13);
            this.category_List2.Name = "category_List2";
            this.category_List2.Size = new System.Drawing.Size(1148, 881);
            this.category_List2.TabIndex = 3;
            // 
            // brand_List2
            // 
            this.brand_List2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brand_List2.Brand_Id = 0;
            this.brand_List2.Brand_Name = null;
            this.brand_List2.Location = new System.Drawing.Point(307, 13);
            this.brand_List2.Name = "brand_List2";
            this.brand_List2.Size = new System.Drawing.Size(1148, 881);
            this.brand_List2.TabIndex = 2;
            // 
            // vendor_List1
            // 
            this.vendor_List1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendor_List1.AutoSize = true;
            this.vendor_List1.BackColor = System.Drawing.Color.White;
            this.vendor_List1.Location = new System.Drawing.Point(307, 13);
            this.vendor_List1.Name = "vendor_List1";
            this.vendor_List1.Size = new System.Drawing.Size(1148, 881);
            this.vendor_List1.TabIndex = 9;
            // 
            // records_Form2
            // 
            this.records_Form2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.records_Form2.AutoSize = true;
            this.records_Form2.BackColor = System.Drawing.Color.White;
            this.records_Form2.ForeColor = System.Drawing.Color.Black;
            this.records_Form2.Location = new System.Drawing.Point(307, 13);
            this.records_Form2.Name = "records_Form2";
            this.records_Form2.Size = new System.Drawing.Size(1148, 881);
            this.records_Form2.TabIndex = 8;
            // 
            // dashboard1
            // 
            this.dashboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboard1.BackColor = System.Drawing.Color.White;
            this.dashboard1.Location = new System.Drawing.Point(308, 10);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1110, 854);
            this.dashboard1.TabIndex = 10;
            // 
            // SalesHistory_Btn
            // 
            this.SalesHistory_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.SalesHistory_Btn.FlatAppearance.BorderSize = 0;
            this.SalesHistory_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesHistory_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SalesHistory_Btn.Image = ((System.Drawing.Image)(resources.GetObject("SalesHistory_Btn.Image")));
            this.SalesHistory_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesHistory_Btn.Location = new System.Drawing.Point(0, 644);
            this.SalesHistory_Btn.Name = "SalesHistory_Btn";
            this.SalesHistory_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.SalesHistory_Btn.Size = new System.Drawing.Size(304, 43);
            this.SalesHistory_Btn.TabIndex = 12;
            this.SalesHistory_Btn.Text = "  SALES HISTORY";
            this.SalesHistory_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalesHistory_Btn.UseVisualStyleBackColor = false;
            this.SalesHistory_Btn.Click += new System.EventHandler(this.SalesHistory_Btn_Click);
            // 
            // StoreDetails_Btn
            // 
            this.StoreDetails_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.StoreDetails_Btn.FlatAppearance.BorderSize = 0;
            this.StoreDetails_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreDetails_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.StoreDetails_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_online_store_30;
            this.StoreDetails_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StoreDetails_Btn.Location = new System.Drawing.Point(0, 697);
            this.StoreDetails_Btn.Name = "StoreDetails_Btn";
            this.StoreDetails_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.StoreDetails_Btn.Size = new System.Drawing.Size(304, 43);
            this.StoreDetails_Btn.TabIndex = 11;
            this.StoreDetails_Btn.Text = "  STORE SETTINGS";
            this.StoreDetails_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StoreDetails_Btn.UseVisualStyleBackColor = false;
            this.StoreDetails_Btn.Click += new System.EventHandler(this.StoreDetails_Btn_Click);
            // 
            // Vendor_Btn
            // 
            this.Vendor_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Vendor_Btn.FlatAppearance.BorderSize = 0;
            this.Vendor_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vendor_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Vendor_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_users_30__1_;
            this.Vendor_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vendor_Btn.Location = new System.Drawing.Point(0, 345);
            this.Vendor_Btn.Name = "Vendor_Btn";
            this.Vendor_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Vendor_Btn.Size = new System.Drawing.Size(304, 43);
            this.Vendor_Btn.TabIndex = 10;
            this.Vendor_Btn.Text = "  VENDORS";
            this.Vendor_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Vendor_Btn.UseVisualStyleBackColor = false;
            this.Vendor_Btn.Click += new System.EventHandler(this.Vendor_Btn_Click);
            // 
            // StockEntry_Btn
            // 
            this.StockEntry_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.StockEntry_Btn.FlatAppearance.BorderSize = 0;
            this.StockEntry_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StockEntry_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.StockEntry_Btn.Image = ((System.Drawing.Image)(resources.GetObject("StockEntry_Btn.Image")));
            this.StockEntry_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StockEntry_Btn.Location = new System.Drawing.Point(0, 529);
            this.StockEntry_Btn.Name = "StockEntry_Btn";
            this.StockEntry_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.StockEntry_Btn.Size = new System.Drawing.Size(304, 43);
            this.StockEntry_Btn.TabIndex = 9;
            this.StockEntry_Btn.Text = "  STOCK ENTRY";
            this.StockEntry_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StockEntry_Btn.UseVisualStyleBackColor = false;
            this.StockEntry_Btn.Click += new System.EventHandler(this.StockEntry_Btn_Click);
            // 
            // Records_Btn
            // 
            this.Records_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Records_Btn.FlatAppearance.BorderSize = 0;
            this.Records_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Records_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Records_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Records_Btn.Image")));
            this.Records_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Records_Btn.Location = new System.Drawing.Point(0, 586);
            this.Records_Btn.Name = "Records_Btn";
            this.Records_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Records_Btn.Size = new System.Drawing.Size(304, 43);
            this.Records_Btn.TabIndex = 8;
            this.Records_Btn.Text = "  RECORDS";
            this.Records_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Records_Btn.UseVisualStyleBackColor = false;
            this.Records_Btn.Click += new System.EventHandler(this.Records_Btn_Click);
            // 
            // Category_Btn
            // 
            this.Category_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Category_Btn.FlatAppearance.BorderSize = 0;
            this.Category_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Category_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Category_Btn.Image")));
            this.Category_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Category_Btn.Location = new System.Drawing.Point(0, 465);
            this.Category_Btn.Name = "Category_Btn";
            this.Category_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Category_Btn.Size = new System.Drawing.Size(304, 43);
            this.Category_Btn.TabIndex = 7;
            this.Category_Btn.Text = "  CATEGORY";
            this.Category_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Category_Btn.UseVisualStyleBackColor = false;
            this.Category_Btn.Click += new System.EventHandler(this.Category_Btn_Click);
            // 
            // Brand_Btn
            // 
            this.Brand_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Brand_Btn.FlatAppearance.BorderSize = 0;
            this.Brand_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brand_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Brand_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Brand_Btn.Image")));
            this.Brand_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Brand_Btn.Location = new System.Drawing.Point(0, 401);
            this.Brand_Btn.Name = "Brand_Btn";
            this.Brand_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Brand_Btn.Size = new System.Drawing.Size(304, 43);
            this.Brand_Btn.TabIndex = 6;
            this.Brand_Btn.Text = "  BRAND";
            this.Brand_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Brand_Btn.UseVisualStyleBackColor = false;
            this.Brand_Btn.Click += new System.EventHandler(this.Brand_Btn_Click);
            // 
            // User_Btn
            // 
            this.User_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.User_Btn.FlatAppearance.BorderSize = 0;
            this.User_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.User_Btn.Image = ((System.Drawing.Image)(resources.GetObject("User_Btn.Image")));
            this.User_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User_Btn.Location = new System.Drawing.Point(0, 756);
            this.User_Btn.Name = "User_Btn";
            this.User_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.User_Btn.Size = new System.Drawing.Size(304, 43);
            this.User_Btn.TabIndex = 5;
            this.User_Btn.Text = "  USER SETTINGS";
            this.User_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.User_Btn.UseVisualStyleBackColor = false;
            this.User_Btn.Click += new System.EventHandler(this.User_Btn_Click);
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Logout_Btn.FlatAppearance.BorderSize = 0;
            this.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Logout_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Logout_Btn.Image")));
            this.Logout_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_Btn.Location = new System.Drawing.Point(0, 819);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Logout_Btn.Size = new System.Drawing.Size(304, 43);
            this.Logout_Btn.TabIndex = 4;
            this.Logout_Btn.Text = "  LOGOUT";
            this.Logout_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout_Btn.UseVisualStyleBackColor = false;
            this.Logout_Btn.Click += new System.EventHandler(this.Logout_Btn_Click);
            // 
            // Product_Btn
            // 
            this.Product_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Product_Btn.FlatAppearance.BorderSize = 0;
            this.Product_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Product_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Product_Btn.Image")));
            this.Product_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Product_Btn.Location = new System.Drawing.Point(0, 291);
            this.Product_Btn.Name = "Product_Btn";
            this.Product_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Product_Btn.Size = new System.Drawing.Size(304, 43);
            this.Product_Btn.TabIndex = 3;
            this.Product_Btn.Text = "  PRODUCT";
            this.Product_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Product_Btn.UseVisualStyleBackColor = false;
            this.Product_Btn.Click += new System.EventHandler(this.product_btn_Click);
            // 
            // Dashborad_Btn
            // 
            this.Dashborad_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Dashborad_Btn.FlatAppearance.BorderSize = 0;
            this.Dashborad_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashborad_Btn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Dashborad_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Dashborad_Btn.Image")));
            this.Dashborad_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashborad_Btn.Location = new System.Drawing.Point(0, 230);
            this.Dashborad_Btn.Name = "Dashborad_Btn";
            this.Dashborad_Btn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Dashborad_Btn.Size = new System.Drawing.Size(304, 43);
            this.Dashborad_Btn.TabIndex = 2;
            this.Dashborad_Btn.Text = "  DASHBOARD";
            this.Dashborad_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashborad_Btn.UseVisualStyleBackColor = false;
            this.Dashborad_Btn.Click += new System.EventHandler(this.dashborad_btn_Click);
            // 
            // user_lbl
            // 
            this.user_lbl.Image = global::Grocery_Shop.Properties.Resources.user;
            this.user_lbl.Location = new System.Drawing.Point(79, 34);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(143, 144);
            this.user_lbl.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1455, 895);
            this.ControlBox = false;
            this.Controls.Add(this.Left_Frame);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.stockEntry_Form2);
            this.Controls.Add(this.productList_Form2);
            this.Controls.Add(this.category_List2);
            this.Controls.Add(this.brand_List2);
            this.Controls.Add(this.vendor_List1);
            this.Controls.Add(this.records_Form2);
            this.Controls.Add(this.dashboard2);
            this.Controls.Add(this.userAccount_Form1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Left_Frame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dashborad_Btn;
        private System.Windows.Forms.Button Product_Btn;
        private System.Windows.Forms.Button Logout_Btn;
        private System.Windows.Forms.Button User_Btn;
        private System.Windows.Forms.Button Brand_Btn;
        private System.Windows.Forms.Button Category_Btn;
        private System.Windows.Forms.Button Records_Btn;
        private System.Windows.Forms.Button StockEntry_Btn;
        private System.Windows.Forms.Button Vendor_Btn;
        private System.Windows.Forms.Button StoreDetails_Btn;
        private System.Windows.Forms.Panel Left_Frame;
        private ProductList_Form productList_Form2;
        private Records_Form records_Form2;
        private Vendor_List vendor_List1;
        private Brand_List brand_List2;
        private Category_List category_List2;
        private Dashboard dashboard1;
        private UserAccount_Form userAccount_Form1;
        private Dashboard dashboard2;
        private StockEntry_Form stockEntry_Form2;
        private System.Windows.Forms.Button SalesHistory_Btn;
    }
}