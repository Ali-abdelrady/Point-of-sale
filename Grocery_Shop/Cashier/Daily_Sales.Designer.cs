namespace Grocery_Shop.Cashier
{
    partial class Daily_Sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SoldItems_EndDate = new System.Windows.Forms.DateTimePicker();
            this.SoldItems_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.DailySales_Table = new System.Windows.Forms.DataGridView();
            this.TotalSales_Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Preview_SoldItems = new System.Windows.Forms.Label();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.Load_Data = new System.Windows.Forms.Label();
            this.REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_SALES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailySales_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 46);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 226);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "DAILY SALES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SoldItems_EndDate
            // 
            this.SoldItems_EndDate.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.SoldItems_EndDate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SoldItems_EndDate.Location = new System.Drawing.Point(438, 61);
            this.SoldItems_EndDate.Name = "SoldItems_EndDate";
            this.SoldItems_EndDate.Size = new System.Drawing.Size(265, 25);
            this.SoldItems_EndDate.TabIndex = 68;
            this.SoldItems_EndDate.Value = new System.DateTime(2023, 10, 9, 0, 0, 0, 0);
            // 
            // SoldItems_StartDate
            // 
            this.SoldItems_StartDate.CalendarFont = new System.Drawing.Font("Tahoma", 11F);
            this.SoldItems_StartDate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.SoldItems_StartDate.Location = new System.Drawing.Point(129, 61);
            this.SoldItems_StartDate.Name = "SoldItems_StartDate";
            this.SoldItems_StartDate.Size = new System.Drawing.Size(265, 25);
            this.SoldItems_StartDate.TabIndex = 66;
            this.SoldItems_StartDate.Value = new System.DateTime(2023, 10, 7, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(11, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 30);
            this.label8.TabIndex = 65;
            this.label8.Text = "FILTER BY";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DailySales_Table
            // 
            this.DailySales_Table.AllowUserToAddRows = false;
            this.DailySales_Table.AllowUserToDeleteRows = false;
            this.DailySales_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DailySales_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DailySales_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DailySales_Table.BackgroundColor = System.Drawing.Color.White;
            this.DailySales_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DailySales_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DailySales_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DailySales_Table.ColumnHeadersHeight = 40;
            this.DailySales_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REF,
            this.PCODE,
            this.DESCRIPTION,
            this.PRICE,
            this.DISCOUNT,
            this.QTY,
            this.TOTAL_SALES,
            this.Column3});
            this.DailySales_Table.EnableHeadersVisualStyles = false;
            this.DailySales_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.DailySales_Table.Location = new System.Drawing.Point(7, 107);
            this.DailySales_Table.Name = "DailySales_Table";
            this.DailySales_Table.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DailySales_Table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DailySales_Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DailySales_Table.Size = new System.Drawing.Size(1328, 605);
            this.DailySales_Table.TabIndex = 64;
            this.DailySales_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DailySales_Table_CellContentClick);
            // 
            // TotalSales_Lbl
            // 
            this.TotalSales_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalSales_Lbl.BackColor = System.Drawing.Color.Black;
            this.TotalSales_Lbl.Font = new System.Drawing.Font("Tahoma", 20F);
            this.TotalSales_Lbl.ForeColor = System.Drawing.Color.Lime;
            this.TotalSales_Lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TotalSales_Lbl.Location = new System.Drawing.Point(1164, 57);
            this.TotalSales_Lbl.Name = "TotalSales_Lbl";
            this.TotalSales_Lbl.Size = new System.Drawing.Size(168, 38);
            this.TotalSales_Lbl.TabIndex = 69;
            this.TotalSales_Lbl.Text = "0.0";
            this.TotalSales_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(1295, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 38);
            this.label2.TabIndex = 70;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Grocery_Shop.Properties.Resources.icons8_cancel_order_20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 17;
            // 
            // Preview_SoldItems
            // 
            this.Preview_SoldItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Preview_SoldItems.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Preview_SoldItems.Image = global::Grocery_Shop.Properties.Resources.icons8_printer_30__1_;
            this.Preview_SoldItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Preview_SoldItems.Location = new System.Drawing.Point(891, 54);
            this.Preview_SoldItems.Name = "Preview_SoldItems";
            this.Preview_SoldItems.Size = new System.Drawing.Size(164, 38);
            this.Preview_SoldItems.TabIndex = 67;
            this.Preview_SoldItems.Text = "    PRINT PREVIEW";
            this.Preview_SoldItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Preview_SoldItems.Click += new System.EventHandler(this.Preview_SoldItems_Click);
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50__1_;
            this.Close_Btn.Location = new System.Drawing.Point(1305, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(41, 46);
            this.Close_Btn.TabIndex = 25;
            this.Close_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Load_Data
            // 
            this.Load_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_Data.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Load_Data.Image = global::Grocery_Shop.Properties.Resources.icons8_cycle_30;
            this.Load_Data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Load_Data.Location = new System.Drawing.Point(748, 54);
            this.Load_Data.Name = "Load_Data";
            this.Load_Data.Size = new System.Drawing.Size(127, 37);
            this.Load_Data.TabIndex = 71;
            this.Load_Data.Text = "     LOAD DATA";
            this.Load_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Load_Data.Click += new System.EventHandler(this.Load_Data_Click);
            // 
            // REF
            // 
            this.REF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.REF.DataPropertyName = "REF";
            this.REF.HeaderText = "REF";
            this.REF.Name = "REF";
            this.REF.ReadOnly = true;
            this.REF.Width = 56;
            // 
            // PCODE
            // 
            this.PCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PCODE.DataPropertyName = "PCODE";
            this.PCODE.HeaderText = "PCODE";
            this.PCODE.Name = "PCODE";
            this.PCODE.ReadOnly = true;
            this.PCODE.Width = 77;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = " DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            this.DESCRIPTION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 71;
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DISCOUNT.DataPropertyName = "DISCOUNT";
            this.DISCOUNT.HeaderText = "DISCOUNT";
            this.DISCOUNT.Name = "DISCOUNT";
            this.DISCOUNT.ReadOnly = true;
            this.DISCOUNT.Width = 105;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 62;
            // 
            // TOTAL_SALES
            // 
            this.TOTAL_SALES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TOTAL_SALES.DataPropertyName = "TOTAL_SALES";
            this.TOTAL_SALES.HeaderText = "TOTAL";
            this.TOTAL_SALES.Name = "TOTAL_SALES";
            this.TOTAL_SALES.ReadOnly = true;
            this.TOTAL_SALES.Width = 78;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "Cancel_Order";
            this.Column3.HeaderText = "";
            this.Column3.Image = global::Grocery_Shop.Properties.Resources.icons8_cancel_order_201;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 17;
            // 
            // Daily_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1346, 724);
            this.Controls.Add(this.Load_Data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalSales_Lbl);
            this.Controls.Add(this.SoldItems_EndDate);
            this.Controls.Add(this.SoldItems_StartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DailySales_Table);
            this.Controls.Add(this.Preview_SoldItems);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Daily_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily_Sales";
            this.Load += new System.EventHandler(this.Daily_Sales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DailySales_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SoldItems_EndDate;
        private System.Windows.Forms.DateTimePicker SoldItems_StartDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DailySales_Table;
        private System.Windows.Forms.Label Preview_SoldItems;
        private System.Windows.Forms.Label TotalSales_Lbl;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Load_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_SALES;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
    }
}