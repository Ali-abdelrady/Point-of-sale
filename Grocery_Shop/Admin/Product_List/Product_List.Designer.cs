namespace Grocery_Shop
{
    partial class Product_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_Txtbox = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Correct_Cell = new System.Windows.Forms.DataGridViewImageColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products_Table = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 38);
            this.panel1.TabIndex = 24;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_x_45;
            this.Close_Btn.Location = new System.Drawing.Point(1147, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(50, 38);
            this.Close_Btn.TabIndex = 25;
            this.Close_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = " PRODUCT LIST";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Search_Txtbox
            // 
            this.Search_Txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.Search_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Search_Txtbox.ForeColor = System.Drawing.Color.Gray;
            this.Search_Txtbox.Location = new System.Drawing.Point(4, 48);
            this.Search_Txtbox.Name = "Search_Txtbox";
            this.Search_Txtbox.Size = new System.Drawing.Size(353, 25);
            this.Search_Txtbox.TabIndex = 27;
            this.Search_Txtbox.Text = "   Search here";
            this.Search_Txtbox.TextChanged += new System.EventHandler(this.Search_Txtbox_TextChanged);
            this.Search_Txtbox.Enter += new System.EventHandler(this.Search_Txtbox_Enter);
            this.Search_Txtbox.Leave += new System.EventHandler(this.Search_Txtbox_Leave);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            this.dataGridViewImageColumn1.HeaderText = "DELETE";
            this.dataGridViewImageColumn1.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.DataPropertyName = "Edit";
            this.dataGridViewImageColumn2.HeaderText = "EDIT";
            this.dataGridViewImageColumn2.Image = global::Grocery_Shop.Properties.Resources.icons8_pencil_20;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Correct_Cell
            // 
            this.Correct_Cell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Correct_Cell.DataPropertyName = "Correct";
            this.Correct_Cell.HeaderText = "";
            this.Correct_Cell.Image = global::Grocery_Shop.Properties.Resources.icons8_correct_20;
            this.Correct_Cell.Name = "Correct_Cell";
            this.Correct_Cell.ReadOnly = true;
            this.Correct_Cell.Width = 5;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantity.DataPropertyName = "Cur_Amount";
            this.Quantity.HeaderText = "QTY";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 69;
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
            // P_Id
            // 
            this.P_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.P_Id.DataPropertyName = "Product_Id";
            this.P_Id.HeaderText = "PCODE";
            this.P_Id.Name = "P_Id";
            this.P_Id.ReadOnly = true;
            this.P_Id.Width = 92;
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
            this.Products_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Products_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Products_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.P_Id,
            this.Column2,
            this.Quantity,
            this.Correct_Cell});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Products_Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Products_Table.EnableHeadersVisualStyles = false;
            this.Products_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Products_Table.Location = new System.Drawing.Point(4, 82);
            this.Products_Table.Name = "Products_Table";
            this.Products_Table.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Products_Table.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Products_Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Products_Table.Size = new System.Drawing.Size(1193, 579);
            this.Products_Table.TabIndex = 26;
            this.Products_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Products_Table_CellContentClick);
            // 
            // Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 661);
            this.Controls.Add(this.Search_Txtbox);
            this.Controls.Add(this.Products_Table);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "p";
            this.Load += new System.EventHandler(this.Product_List_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Products_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_Txtbox;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.DataGridViewImageColumn Correct_Cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Id;
        private System.Windows.Forms.DataGridView Products_Table;
    }
}