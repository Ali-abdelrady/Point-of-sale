namespace Grocery_Shop
{
    partial class StockEntry_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Browse_Btn = new System.Windows.Forms.LinkLabel();
            this.Stock_Date = new System.Windows.Forms.DateTimePicker();
            this.Vendor_Cmbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StockBy_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.StockIn_Table = new System.Windows.Forms.DataGridView();
            this.PCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.End_Date = new System.Windows.Forms.DateTimePicker();
            this.StockHistory_Table = new System.Windows.Forms.DataGridView();
            this.Stock_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadRecord_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SrockIn_lbl = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.Delete_Cell = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockIn_Table)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockHistory_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1114, 709);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage1.Controls.Add(this.Browse_Btn);
            this.metroTabPage1.Controls.Add(this.Stock_Date);
            this.metroTabPage1.Controls.Add(this.Vendor_Cmbox);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.StockBy_txtbox);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.Save_Btn);
            this.metroTabPage1.Controls.Add(this.StockIn_Table);
            this.metroTabPage1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1106, 667);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "STOCK ENTRY";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Browse_Btn
            // 
            this.Browse_Btn.ActiveLinkColor = System.Drawing.Color.Blue;
            this.Browse_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse_Btn.AutoSize = true;
            this.Browse_Btn.BackColor = System.Drawing.Color.White;
            this.Browse_Btn.LinkColor = System.Drawing.Color.Black;
            this.Browse_Btn.Location = new System.Drawing.Point(849, 63);
            this.Browse_Btn.Name = "Browse_Btn";
            this.Browse_Btn.Size = new System.Drawing.Size(222, 18);
            this.Browse_Btn.TabIndex = 53;
            this.Browse_Btn.TabStop = true;
            this.Browse_Btn.Text = "[ Click Here To Browse Product ]";
            this.Browse_Btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Browse_Btn_LinkClicked);
            // 
            // Stock_Date
            // 
            this.Stock_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Stock_Date.Location = new System.Drawing.Point(133, 60);
            this.Stock_Date.Name = "Stock_Date";
            this.Stock_Date.Size = new System.Drawing.Size(265, 25);
            this.Stock_Date.TabIndex = 52;
            this.Stock_Date.ValueChanged += new System.EventHandler(this.Stock_Date_ValueChanged);
            // 
            // Vendor_Cmbox
            // 
            this.Vendor_Cmbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Vendor_Cmbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Vendor_Cmbox.FormattingEnabled = true;
            this.Vendor_Cmbox.IntegralHeight = false;
            this.Vendor_Cmbox.ItemHeight = 18;
            this.Vendor_Cmbox.Location = new System.Drawing.Point(825, 14);
            this.Vendor_Cmbox.Name = "Vendor_Cmbox";
            this.Vendor_Cmbox.Size = new System.Drawing.Size(265, 26);
            this.Vendor_Cmbox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(731, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "VENDOR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "STOCK IN DATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StockBy_txtbox
            // 
            this.StockBy_txtbox.Location = new System.Drawing.Point(133, 17);
            this.StockBy_txtbox.Multiline = true;
            this.StockBy_txtbox.Name = "StockBy_txtbox";
            this.StockBy_txtbox.ReadOnly = true;
            this.StockBy_txtbox.Size = new System.Drawing.Size(265, 26);
            this.StockBy_txtbox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "STOCK IN BY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Save_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Save_Btn.Location = new System.Drawing.Point(0, 628);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(103, 36);
            this.Save_Btn.TabIndex = 37;
            this.Save_Btn.Text = "SAVE";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // StockIn_Table
            // 
            this.StockIn_Table.AllowUserToAddRows = false;
            this.StockIn_Table.AllowUserToDeleteRows = false;
            this.StockIn_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockIn_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockIn_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockIn_Table.BackgroundColor = System.Drawing.Color.White;
            this.StockIn_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockIn_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StockIn_Table.ColumnHeadersHeight = 30;
            this.StockIn_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PCODE,
            this.Column2,
            this.Column3,
            this.Date_time,
            this.Column4,
            this.Brand_Col,
            this.Delete_Cell});
            this.StockIn_Table.EnableHeadersVisualStyles = false;
            this.StockIn_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.StockIn_Table.Location = new System.Drawing.Point(1, 138);
            this.StockIn_Table.Name = "StockIn_Table";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.StockIn_Table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.StockIn_Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StockIn_Table.Size = new System.Drawing.Size(1105, 484);
            this.StockIn_Table.TabIndex = 21;
            this.StockIn_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockIn_Table_CellContentClick);
            // 
            // PCODE
            // 
            this.PCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PCODE.DataPropertyName = "Product_Id";
            this.PCODE.HeaderText = "PCODE";
            this.PCODE.Name = "PCODE";
            this.PCODE.Width = 77;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = " DESCRIPTION";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "Cur_Amount";
            this.Column3.HeaderText = "QTY";
            this.Column3.Name = "Column3";
            this.Column3.Width = 62;
            // 
            // Date_time
            // 
            this.Date_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date_time.DataPropertyName = "Entry_Date";
            this.Date_time.HeaderText = "STOCK IN DATE";
            this.Date_time.Name = "Date_time";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Emp_Id";
            this.Column4.HeaderText = "STOCK IN BY";
            this.Column4.Name = "Column4";
            // 
            // Brand_Col
            // 
            this.Brand_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Brand_Col.DataPropertyName = "Name";
            this.Brand_Col.HeaderText = "VENDOR";
            this.Brand_Col.Name = "Brand_Col";
            this.Brand_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Brand_Col.Width = 69;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.End_Date);
            this.metroTabPage2.Controls.Add(this.StockHistory_Table);
            this.metroTabPage2.Controls.Add(this.Start_Date);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.LoadRecord_Btn);
            this.metroTabPage2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1106, 667);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "STOCK IN HISTORY";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // End_Date
            // 
            this.End_Date.Font = new System.Drawing.Font("Tahoma", 11F);
            this.End_Date.Location = new System.Drawing.Point(416, 32);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(265, 25);
            this.End_Date.TabIndex = 58;
            // 
            // StockHistory_Table
            // 
            this.StockHistory_Table.AllowUserToAddRows = false;
            this.StockHistory_Table.AllowUserToDeleteRows = false;
            this.StockHistory_Table.AllowUserToResizeColumns = false;
            this.StockHistory_Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockHistory_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.StockHistory_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockHistory_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockHistory_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockHistory_Table.BackgroundColor = System.Drawing.Color.White;
            this.StockHistory_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockHistory_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StockHistory_Table.ColumnHeadersHeight = 30;
            this.StockHistory_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stock_Id,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn3});
            this.StockHistory_Table.EnableHeadersVisualStyles = false;
            this.StockHistory_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.StockHistory_Table.Location = new System.Drawing.Point(0, 80);
            this.StockHistory_Table.Name = "StockHistory_Table";
            this.StockHistory_Table.ReadOnly = true;
            this.StockHistory_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.StockHistory_Table.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StockHistory_Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StockHistory_Table.Size = new System.Drawing.Size(1106, 587);
            this.StockHistory_Table.TabIndex = 57;
            this.StockHistory_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockHistory_Table_CellContentClick);
            // 
            // Stock_Id
            // 
            this.Stock_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Stock_Id.DataPropertyName = "Stock_Id";
            this.Stock_Id.HeaderText = "REF #";
            this.Stock_Id.Name = "Stock_Id";
            this.Stock_Id.ReadOnly = true;
            this.Stock_Id.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product_Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "PCODE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = " DESCRIPTION";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 62;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Entry_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "STOCK IN DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StockBy";
            this.dataGridViewTextBoxColumn5.HeaderText = "STOCK IN BY";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Vendor_Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "VENDOR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 88;
            // 
            // Start_Date
            // 
            this.Start_Date.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Start_Date.Location = new System.Drawing.Point(134, 32);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(265, 25);
            this.Start_Date.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 30);
            this.label4.TabIndex = 55;
            this.label4.Text = "FILTER BY DATE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadRecord_Btn
            // 
            this.LoadRecord_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.LoadRecord_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadRecord_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LoadRecord_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadRecord_Btn.Location = new System.Drawing.Point(687, 30);
            this.LoadRecord_Btn.Name = "LoadRecord_Btn";
            this.LoadRecord_Btn.Size = new System.Drawing.Size(117, 32);
            this.LoadRecord_Btn.TabIndex = 54;
            this.LoadRecord_Btn.Text = "LOAD RECORD";
            this.LoadRecord_Btn.UseVisualStyleBackColor = false;
            this.LoadRecord_Btn.Click += new System.EventHandler(this.LoadRecord_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Controls.Add(this.SrockIn_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 54);
            this.panel1.TabIndex = 23;
            // 
            // SrockIn_lbl
            // 
            this.SrockIn_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SrockIn_lbl.BackColor = System.Drawing.Color.Transparent;
            this.SrockIn_lbl.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrockIn_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.SrockIn_lbl.Location = new System.Drawing.Point(3, 16);
            this.SrockIn_lbl.Name = "SrockIn_lbl";
            this.SrockIn_lbl.Size = new System.Drawing.Size(314, 26);
            this.SrockIn_lbl.TabIndex = 1;
            this.SrockIn_lbl.Text = "STOCK IN";
            this.SrockIn_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            this.dataGridViewImageColumn1.HeaderText = "DELETE";
            this.dataGridViewImageColumn1.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn2.DataPropertyName = "Edit";
            this.dataGridViewImageColumn2.HeaderText = "EDIT";
            this.dataGridViewImageColumn2.Image = global::Grocery_Shop.Properties.Resources.icons8_pencil_20;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 63;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50;
            this.Close_Btn.Location = new System.Drawing.Point(1063, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(54, 54);
            this.Close_Btn.TabIndex = 26;
            this.Close_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Delete_Cell
            // 
            this.Delete_Cell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete_Cell.DataPropertyName = "Delete";
            this.Delete_Cell.HeaderText = "";
            this.Delete_Cell.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.Delete_Cell.Name = "Delete_Cell";
            this.Delete_Cell.Width = 5;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn3.DataPropertyName = "Delete";
            this.dataGridViewImageColumn3.HeaderText = "DELETE";
            this.dataGridViewImageColumn3.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 63;
            // 
            // StockEntry_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "StockEntry_Form";
            this.Size = new System.Drawing.Size(1120, 772);
            this.Load += new System.EventHandler(this.StockEntry_Form_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockIn_Table)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockHistory_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label SrockIn_lbl;
        private System.Windows.Forms.DataGridView StockIn_Table;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockBy_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Stock_Date;
        private System.Windows.Forms.ComboBox Vendor_Cmbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Start_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoadRecord_Btn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.LinkLabel Browse_Btn;
        private System.Windows.Forms.DataGridView StockHistory_Table;
        private System.Windows.Forms.DateTimePicker End_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand_Col;
        private System.Windows.Forms.DataGridViewImageColumn Delete_Cell;
    }
}
