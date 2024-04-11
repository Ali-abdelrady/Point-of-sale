namespace Grocery_Shop
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sales_Lbl = new System.Windows.Forms.Label();
            this.Stock_Lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CriticalItems_Lbl = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.category_list_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Profits_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Vendor_lbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profits_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 114);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.OrangeRed;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "  DAILY SALES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sales_Lbl
            // 
            this.Sales_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sales_Lbl.AutoSize = true;
            this.Sales_Lbl.BackColor = System.Drawing.Color.OrangeRed;
            this.Sales_Lbl.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_Lbl.ForeColor = System.Drawing.Color.White;
            this.Sales_Lbl.Location = new System.Drawing.Point(28, 156);
            this.Sales_Lbl.Name = "Sales_Lbl";
            this.Sales_Lbl.Size = new System.Drawing.Size(30, 33);
            this.Sales_Lbl.TabIndex = 25;
            this.Sales_Lbl.Text = "0";
            this.Sales_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Stock_Lbl
            // 
            this.Stock_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Stock_Lbl.AutoSize = true;
            this.Stock_Lbl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Stock_Lbl.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_Lbl.ForeColor = System.Drawing.Color.White;
            this.Stock_Lbl.Location = new System.Drawing.Point(575, 156);
            this.Stock_Lbl.Name = "Stock_Lbl";
            this.Stock_Lbl.Size = new System.Drawing.Size(30, 33);
            this.Stock_Lbl.TabIndex = 33;
            this.Stock_Lbl.Text = "0";
            this.Stock_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(567, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 19);
            this.label12.TabIndex = 31;
            this.label12.Text = "  STOCK ON HAND ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(567, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(250, 114);
            this.label13.TabIndex = 32;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CriticalItems_Lbl
            // 
            this.CriticalItems_Lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CriticalItems_Lbl.AutoSize = true;
            this.CriticalItems_Lbl.BackColor = System.Drawing.Color.DarkOrange;
            this.CriticalItems_Lbl.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalItems_Lbl.ForeColor = System.Drawing.Color.White;
            this.CriticalItems_Lbl.Location = new System.Drawing.Point(846, 156);
            this.CriticalItems_Lbl.Name = "CriticalItems_Lbl";
            this.CriticalItems_Lbl.Size = new System.Drawing.Size(30, 33);
            this.CriticalItems_Lbl.TabIndex = 37;
            this.CriticalItems_Lbl.Text = "0";
            this.CriticalItems_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.DarkOrange;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(838, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 19);
            this.label16.TabIndex = 35;
            this.label16.Text = "  CRITICAL ITEMS ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.BackColor = System.Drawing.Color.DarkOrange;
            this.label17.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(838, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(250, 114);
            this.label17.TabIndex = 36;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // category_list_lbl
            // 
            this.category_list_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.category_list_lbl.BackColor = System.Drawing.Color.Transparent;
            this.category_list_lbl.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_list_lbl.ForeColor = System.Drawing.Color.Black;
            this.category_list_lbl.Location = new System.Drawing.Point(3, 12);
            this.category_list_lbl.Name = "category_list_lbl";
            this.category_list_lbl.Size = new System.Drawing.Size(126, 33);
            this.category_list_lbl.TabIndex = 1;
            this.category_list_lbl.Text = "Dashboard";
            this.category_list_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(936, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home / Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.category_list_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 58);
            this.panel1.TabIndex = 24;
            // 
            // Profits_Chart
            // 
            this.Profits_Chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Profits_Chart.BackSecondaryColor = System.Drawing.Color.White;
            this.Profits_Chart.BorderSkin.BackColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "area";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.Profits_Chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Tahoma", 11F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Year";
            legend1.ShadowColor = System.Drawing.Color.White;
            this.Profits_Chart.Legends.Add(legend1);
            this.Profits_Chart.Location = new System.Drawing.Point(-8, 275);
            this.Profits_Chart.Name = "Profits_Chart";
            series1.ChartArea = "area";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Year";
            series1.Name = "Profit";
            series1.ShadowColor = System.Drawing.Color.White;
            this.Profits_Chart.Series.Add(series1);
            this.Profits_Chart.Size = new System.Drawing.Size(1096, 499);
            this.Profits_Chart.TabIndex = 39;
            this.Profits_Chart.Text = "Sales_Chart";
            title1.BackColor = System.Drawing.Color.White;
            title1.Font = new System.Drawing.Font("Tahoma", 11F);
            title1.Name = "Title1";
            title1.Text = "YEARLY PROFITS";
            this.Profits_Chart.Titles.Add(title1);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.DodgerBlue;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(301, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 114);
            this.label9.TabIndex = 28;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DodgerBlue;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(306, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = " VENDORS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Vendor_lbl
            // 
            this.Vendor_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vendor_lbl.AutoSize = true;
            this.Vendor_lbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.Vendor_lbl.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendor_lbl.ForeColor = System.Drawing.Color.White;
            this.Vendor_lbl.Location = new System.Drawing.Point(308, 156);
            this.Vendor_lbl.Name = "Vendor_lbl";
            this.Vendor_lbl.Size = new System.Drawing.Size(30, 33);
            this.Vendor_lbl.TabIndex = 29;
            this.Vendor_lbl.Text = "0";
            this.Vendor_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.DarkOrange;
            this.label14.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Image = global::Grocery_Shop.Properties.Resources.loss;
            this.label14.Location = new System.Drawing.Point(985, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 114);
            this.label14.TabIndex = 38;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label10.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::Grocery_Shop.Properties.Resources.profit__2_;
            this.label10.Location = new System.Drawing.Point(714, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 114);
            this.label10.TabIndex = 34;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::Grocery_Shop.Properties.Resources.profit__2_;
            this.label6.Location = new System.Drawing.Point(443, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 114);
            this.label6.TabIndex = 30;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::Grocery_Shop.Properties.Resources.sales;
            this.label5.Location = new System.Drawing.Point(167, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 114);
            this.label5.TabIndex = 26;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Profits_Chart);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CriticalItems_Lbl);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Stock_Lbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Vendor_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Sales_Lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1103, 777);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Profits_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Sales_Lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Stock_Lbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label CriticalItems_Lbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label category_list_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Profits_Chart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Vendor_lbl;
        private System.Windows.Forms.Label label6;
    }
}
