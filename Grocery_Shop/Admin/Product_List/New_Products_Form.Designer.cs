namespace Grocery_Shop
{
    partial class New_Products_Form
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
            this.cur_lbl = new System.Windows.Forms.Label();
            this.ProductName_txtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Barcode_Txtbox = new System.Windows.Forms.TextBox();
            this.Brand_Combox = new System.Windows.Forms.ComboBox();
            this.Category_Combox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price_Txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveUpdate_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cur_lbl
            // 
            this.cur_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cur_lbl.Location = new System.Drawing.Point(46, 80);
            this.cur_lbl.Name = "cur_lbl";
            this.cur_lbl.Size = new System.Drawing.Size(129, 30);
            this.cur_lbl.TabIndex = 18;
            this.cur_lbl.Text = "PRODUCT NAME ";
            this.cur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductName_txtbox
            // 
            this.ProductName_txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ProductName_txtbox.Location = new System.Drawing.Point(181, 81);
            this.ProductName_txtbox.Name = "ProductName_txtbox";
            this.ProductName_txtbox.Size = new System.Drawing.Size(486, 25);
            this.ProductName_txtbox.TabIndex = 22;
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
            this.panel1.Size = new System.Drawing.Size(735, 47);
            this.panel1.TabIndex = 23;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50__1_;
            this.Close_Btn.Location = new System.Drawing.Point(686, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(49, 47);
            this.Close_Btn.TabIndex = 25;
            this.Close_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close_Btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 47);
            this.label1.TabIndex = 24;
            this.label1.Text = "Product Module";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(46, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "BARCODE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(46, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "BRAND";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Barcode_Txtbox
            // 
            this.Barcode_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Barcode_Txtbox.Location = new System.Drawing.Point(181, 118);
            this.Barcode_Txtbox.Name = "Barcode_Txtbox";
            this.Barcode_Txtbox.Size = new System.Drawing.Size(486, 25);
            this.Barcode_Txtbox.TabIndex = 26;
            // 
            // Brand_Combox
            // 
            this.Brand_Combox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Brand_Combox.FormattingEnabled = true;
            this.Brand_Combox.IntegralHeight = false;
            this.Brand_Combox.ItemHeight = 18;
            this.Brand_Combox.Location = new System.Drawing.Point(181, 155);
            this.Brand_Combox.Name = "Brand_Combox";
            this.Brand_Combox.Size = new System.Drawing.Size(485, 26);
            this.Brand_Combox.TabIndex = 27;
            // 
            // Category_Combox
            // 
            this.Category_Combox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Category_Combox.FormattingEnabled = true;
            this.Category_Combox.IntegralHeight = false;
            this.Category_Combox.ItemHeight = 18;
            this.Category_Combox.Location = new System.Drawing.Point(181, 193);
            this.Category_Combox.Name = "Category_Combox";
            this.Category_Combox.Size = new System.Drawing.Size(485, 26);
            this.Category_Combox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(46, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "CATEGORY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Price_Txtbox
            // 
            this.Price_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Price_Txtbox.Location = new System.Drawing.Point(181, 231);
            this.Price_Txtbox.Name = "Price_Txtbox";
            this.Price_Txtbox.Size = new System.Drawing.Size(486, 25);
            this.Price_Txtbox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(46, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "PRICE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveUpdate_Btn
            // 
            this.SaveUpdate_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.SaveUpdate_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUpdate_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SaveUpdate_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveUpdate_Btn.Location = new System.Drawing.Point(455, 283);
            this.SaveUpdate_Btn.Name = "SaveUpdate_Btn";
            this.SaveUpdate_Btn.Size = new System.Drawing.Size(103, 36);
            this.SaveUpdate_Btn.TabIndex = 32;
            this.SaveUpdate_Btn.Text = "SAVE";
            this.SaveUpdate_Btn.UseVisualStyleBackColor = false;
            this.SaveUpdate_Btn.Click += new System.EventHandler(this.SaveUpdate_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Cancel_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancel_Btn.Location = new System.Drawing.Point(564, 283);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(103, 36);
            this.Cancel_Btn.TabIndex = 34;
            this.Cancel_Btn.Text = "CANCEL";
            this.Cancel_Btn.UseVisualStyleBackColor = false;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // New_Products_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 343);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.SaveUpdate_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Price_Txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Category_Combox);
            this.Controls.Add(this.Brand_Combox);
            this.Controls.Add(this.Barcode_Txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductName_txtbox);
            this.Controls.Add(this.cur_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "New_Products_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.New_Products_Form_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cur_lbl;
        private System.Windows.Forms.TextBox ProductName_txtbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Barcode_Txtbox;
        private System.Windows.Forms.ComboBox Brand_Combox;
        private System.Windows.Forms.ComboBox Category_Combox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Price_Txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveUpdate_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}