namespace Grocery_Shop
{
    partial class ProductList_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Products_Table = new System.Windows.Forms.DataGridView();
            this.P_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_col = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Cell = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_Btn = new System.Windows.Forms.Label();
            this.Search_Txtbox = new System.Windows.Forms.TextBox();
            this.product_list_lbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Products_Table
            // 
            this.Products_Table.AllowUserToAddRows = false;
            this.Products_Table.AllowUserToDeleteRows = false;
            this.Products_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Products_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Products_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Products_Table.BackgroundColor = System.Drawing.Color.White;
            this.Products_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Products_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Products_Table.ColumnHeadersHeight = 40;
            this.Products_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Products_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_Id,
            this.Column2,
            this.Price_Col,
            this.Barcode_Col,
            this.Category_Col,
            this.Brand_Col,
            this.edit_col,
            this.Delete_Cell});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Products_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Products_Table.EnableHeadersVisualStyles = false;
            this.Products_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.Products_Table.Location = new System.Drawing.Point(0, 57);
            this.Products_Table.Name = "Products_Table";
            this.Products_Table.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Products_Table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Products_Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Products_Table.Size = new System.Drawing.Size(1119, 712);
            this.Products_Table.TabIndex = 20;
            this.Products_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Products_Table_CellContentClick);
            // 
            // P_Id
            // 
            this.P_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.P_Id.DataPropertyName = "Product_Id";
            this.P_Id.HeaderText = "PCODE";
            this.P_Id.Name = "P_Id";
            this.P_Id.ReadOnly = true;
            this.P_Id.Width = 91;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "DESCRIPTION";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price_Col
            // 
            this.Price_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Price_Col.DataPropertyName = "Price";
            this.Price_Col.HeaderText = "PRICE";
            this.Price_Col.Name = "Price_Col";
            this.Price_Col.ReadOnly = true;
            this.Price_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price_Col.Width = 65;
            // 
            // Barcode_Col
            // 
            this.Barcode_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Barcode_Col.DataPropertyName = "Barcode";
            this.Barcode_Col.HeaderText = "BARCODE";
            this.Barcode_Col.Name = "Barcode_Col";
            this.Barcode_Col.ReadOnly = true;
            this.Barcode_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Barcode_Col.Width = 96;
            // 
            // Category_Col
            // 
            this.Category_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Category_Col.DataPropertyName = "Category_Name";
            this.Category_Col.HeaderText = "CATEGORY";
            this.Category_Col.Name = "Category_Col";
            this.Category_Col.ReadOnly = true;
            this.Category_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Category_Col.Width = 107;
            // 
            // Brand_Col
            // 
            this.Brand_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Brand_Col.DataPropertyName = "Brand_Name";
            this.Brand_Col.HeaderText = "BRAND";
            this.Brand_Col.Name = "Brand_Col";
            this.Brand_Col.ReadOnly = true;
            this.Brand_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Brand_Col.Width = 74;
            // 
            // edit_col
            // 
            this.edit_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.edit_col.DataPropertyName = "Edit";
            this.edit_col.FillWeight = 130F;
            this.edit_col.HeaderText = "";
            this.edit_col.Image = global::Grocery_Shop.Properties.Resources.icons8_pencil_20;
            this.edit_col.Name = "edit_col";
            this.edit_col.ReadOnly = true;
            this.edit_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit_col.Width = 5;
            // 
            // Delete_Cell
            // 
            this.Delete_Cell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Delete_Cell.DataPropertyName = "Delete";
            this.Delete_Cell.FillWeight = 130F;
            this.Delete_Cell.HeaderText = "";
            this.Delete_Cell.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.Delete_Cell.Name = "Delete_Cell";
            this.Delete_Cell.ReadOnly = true;
            this.Delete_Cell.Width = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Add_Btn);
            this.panel1.Controls.Add(this.Search_Txtbox);
            this.panel1.Controls.Add(this.product_list_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 57);
            this.panel1.TabIndex = 19;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Add_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_add_document_30;
            this.Add_Btn.Location = new System.Drawing.Point(1082, 0);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(37, 57);
            this.Add_Btn.TabIndex = 3;
            this.Add_Btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Search_Txtbox
            // 
            this.Search_Txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Txtbox.BackColor = System.Drawing.Color.White;
            this.Search_Txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Search_Txtbox.ForeColor = System.Drawing.Color.Gray;
            this.Search_Txtbox.Location = new System.Drawing.Point(701, 17);
            this.Search_Txtbox.Name = "Search_Txtbox";
            this.Search_Txtbox.Size = new System.Drawing.Size(353, 25);
            this.Search_Txtbox.TabIndex = 2;
            this.Search_Txtbox.Text = " Search here";
            this.Search_Txtbox.Click += new System.EventHandler(this.Search_Txtbox_Click);
            this.Search_Txtbox.TextChanged += new System.EventHandler(this.Search_Txtbox_TextChanged);
            this.Search_Txtbox.Enter += new System.EventHandler(this.Search_Txtbox_Enter);
            this.Search_Txtbox.Leave += new System.EventHandler(this.Search_Txtbox_Leave);
            // 
            // product_list_lbl
            // 
            this.product_list_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.product_list_lbl.BackColor = System.Drawing.Color.Transparent;
            this.product_list_lbl.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_list_lbl.ForeColor = System.Drawing.Color.Black;
            this.product_list_lbl.Location = new System.Drawing.Point(3, 12);
            this.product_list_lbl.Name = "product_list_lbl";
            this.product_list_lbl.Size = new System.Drawing.Size(316, 33);
            this.product_list_lbl.TabIndex = 1;
            this.product_list_lbl.Text = "PRODUCT LIST ";
            this.product_list_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "DELETE";
            this.dataGridViewImageColumn1.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn2.HeaderText = "EDIT";
            this.dataGridViewImageColumn2.Image = global::Grocery_Shop.Properties.Resources.icons8_pencil_20;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Products_Table);
            this.Controls.Add(this.panel1);
            this.Name = "ProductList_Form";
            this.Size = new System.Drawing.Size(1119, 769);
            this.Load += new System.EventHandler(this.ProductList_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Products_Table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Add_Btn;
        private System.Windows.Forms.Label product_list_lbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox Search_Txtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Col;
        private System.Windows.Forms.DataGridViewImageColumn edit_col;
        private System.Windows.Forms.DataGridViewImageColumn Delete_Cell;
    }
}
