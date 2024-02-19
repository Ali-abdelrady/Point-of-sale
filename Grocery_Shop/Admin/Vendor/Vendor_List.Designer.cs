namespace Grocery_Shop
{
    partial class Vendor_List
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
            this.Vendors_Table = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_col = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_Cell = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search_Txtbox = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Label();
            this.category_list_lbl = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Vendors_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vendors_Table
            // 
            this.Vendors_Table.AllowUserToAddRows = false;
            this.Vendors_Table.AllowUserToDeleteRows = false;
            this.Vendors_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vendors_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Vendors_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Vendors_Table.BackgroundColor = System.Drawing.Color.White;
            this.Vendors_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Vendors_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Vendors_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Vendors_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vendors_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Category_Col,
            this.Column1,
            this.Column2,
            this.Column3,
            this.edit_col,
            this.Delete_Cell});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Vendors_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Vendors_Table.EnableHeadersVisualStyles = false;
            this.Vendors_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.Vendors_Table.Location = new System.Drawing.Point(0, 58);
            this.Vendors_Table.Name = "Vendors_Table";
            this.Vendors_Table.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Vendors_Table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Vendors_Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Vendors_Table.Size = new System.Drawing.Size(1103, 609);
            this.Vendors_Table.TabIndex = 24;
            this.Vendors_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vendors_Table_CellClick);
            this.Vendors_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vendors_Table_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "Vendor_Id";
            this.Column4.HeaderText = "ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 53;
            // 
            // Category_Col
            // 
            this.Category_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Category_Col.DataPropertyName = "Name";
            this.Category_Col.HeaderText = "VENDOR";
            this.Category_Col.Name = "Category_Col";
            this.Category_Col.ReadOnly = true;
            this.Category_Col.Width = 106;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Address";
            this.Column1.HeaderText = "ADDRESS";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Email";
            this.Column2.HeaderText = "EMAIL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "PhoneNumber";
            this.Column3.HeaderText = "PHONE NUMBER";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // edit_col
            // 
            this.edit_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.edit_col.DataPropertyName = "Edit";
            this.edit_col.HeaderText = "EDIT";
            this.edit_col.Image = global::Grocery_Shop.Properties.Resources.icons8_pencil_20;
            this.edit_col.Name = "edit_col";
            this.edit_col.ReadOnly = true;
            this.edit_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit_col.Width = 75;
            // 
            // Delete_Cell
            // 
            this.Delete_Cell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Delete_Cell.DataPropertyName = "Delete";
            this.Delete_Cell.HeaderText = "DELETE";
            this.Delete_Cell.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.Delete_Cell.Name = "Delete_Cell";
            this.Delete_Cell.ReadOnly = true;
            this.Delete_Cell.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Search_Txtbox);
            this.panel1.Controls.Add(this.Add_Btn);
            this.panel1.Controls.Add(this.category_list_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 58);
            this.panel1.TabIndex = 23;
            // 
            // Search_Txtbox
            // 
            this.Search_Txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.Search_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Search_Txtbox.ForeColor = System.Drawing.Color.Gray;
            this.Search_Txtbox.Location = new System.Drawing.Point(691, 17);
            this.Search_Txtbox.Name = "Search_Txtbox";
            this.Search_Txtbox.Size = new System.Drawing.Size(353, 25);
            this.Search_Txtbox.TabIndex = 5;
            this.Search_Txtbox.Text = "  Search here";
            this.Search_Txtbox.Click += new System.EventHandler(this.Search_Txtbox_Click);
            this.Search_Txtbox.TextChanged += new System.EventHandler(this.Search_Txtbox_TextChanged);
            this.Search_Txtbox.Enter += new System.EventHandler(this.Search_Txtbox_Enter);
            this.Search_Txtbox.Leave += new System.EventHandler(this.Search_Txtbox_Leave);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Add_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_add_document_30;
            this.Add_Btn.Location = new System.Drawing.Point(1063, 0);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(40, 58);
            this.Add_Btn.TabIndex = 3;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // category_list_lbl
            // 
            this.category_list_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category_list_lbl.BackColor = System.Drawing.Color.Transparent;
            this.category_list_lbl.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_list_lbl.ForeColor = System.Drawing.Color.Black;
            this.category_list_lbl.Location = new System.Drawing.Point(3, 12);
            this.category_list_lbl.Name = "category_list_lbl";
            this.category_list_lbl.Size = new System.Drawing.Size(300, 33);
            this.category_list_lbl.TabIndex = 1;
            this.category_list_lbl.Text = "VENDOR LIST ";
            this.category_list_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "EDIT";
            this.dataGridViewImageColumn1.Image = global::Grocery_Shop.Properties.Resources.icons8_pencil_20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn2.HeaderText = "DELETE";
            this.dataGridViewImageColumn2.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // Vendor_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Vendors_Table);
            this.Controls.Add(this.panel1);
            this.Name = "Vendor_List";
            this.Size = new System.Drawing.Size(1103, 667);
            this.Load += new System.EventHandler(this.Vendor_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vendors_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Vendors_Table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Search_Txtbox;
        private System.Windows.Forms.Label Add_Btn;
        private System.Windows.Forms.Label category_list_lbl;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn edit_col;
        private System.Windows.Forms.DataGridViewImageColumn Delete_Cell;
    }
}
