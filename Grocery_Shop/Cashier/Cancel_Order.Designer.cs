namespace Grocery_Shop.Cashier
{
    partial class Cancel_Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pcode_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Price_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ref_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Qty_Textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description_Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Total_Textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Reason_Textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CancelQty_Textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CancelBy_Textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Action_cmbobox = new System.Windows.Forms.ComboBox();
            this.Discount_TextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(952, 46);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 226);
            this.panel2.TabIndex = 25;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50__1_;
            this.Close_Btn.Location = new System.Drawing.Point(911, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(41, 46);
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
            this.label1.Size = new System.Drawing.Size(242, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "CANCEL ORDER DETAILS ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "SOLD ITEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pcode_Textbox
            // 
            this.Pcode_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Pcode_Textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Pcode_Textbox.Location = new System.Drawing.Point(160, 160);
            this.Pcode_Textbox.Name = "Pcode_Textbox";
            this.Pcode_Textbox.ReadOnly = true;
            this.Pcode_Textbox.Size = new System.Drawing.Size(270, 27);
            this.Pcode_Textbox.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(25, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 60;
            this.label3.Text = "PRODUCT CODE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Price_Textbox
            // 
            this.Price_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Price_Textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Price_Textbox.Location = new System.Drawing.Point(670, 111);
            this.Price_Textbox.Name = "Price_Textbox";
            this.Price_Textbox.ReadOnly = true;
            this.Price_Textbox.Size = new System.Drawing.Size(270, 27);
            this.Price_Textbox.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(535, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 30);
            this.label4.TabIndex = 64;
            this.label4.Text = "PRICE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ref_Textbox
            // 
            this.Ref_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Ref_Textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Ref_Textbox.Location = new System.Drawing.Point(160, 119);
            this.Ref_Textbox.Name = "Ref_Textbox";
            this.Ref_Textbox.ReadOnly = true;
            this.Ref_Textbox.Size = new System.Drawing.Size(270, 27);
            this.Ref_Textbox.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 30);
            this.label5.TabIndex = 62;
            this.label5.Text = "TRANSACTION NUM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Qty_Textbox
            // 
            this.Qty_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Qty_Textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Qty_Textbox.Location = new System.Drawing.Point(670, 153);
            this.Qty_Textbox.Name = "Qty_Textbox";
            this.Qty_Textbox.ReadOnly = true;
            this.Qty_Textbox.Size = new System.Drawing.Size(270, 27);
            this.Qty_Textbox.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(535, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 30);
            this.label6.TabIndex = 68;
            this.label6.Text = "QTY";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Description_Textbox
            // 
            this.Description_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Description_Textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Description_Textbox.Location = new System.Drawing.Point(160, 200);
            this.Description_Textbox.Multiline = true;
            this.Description_Textbox.Name = "Description_Textbox";
            this.Description_Textbox.ReadOnly = true;
            this.Description_Textbox.Size = new System.Drawing.Size(270, 39);
            this.Description_Textbox.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(25, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 30);
            this.label7.TabIndex = 66;
            this.label7.Text = "DESCRIPTION";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Total_Textbox
            // 
            this.Total_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Total_Textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Total_Textbox.Location = new System.Drawing.Point(670, 193);
            this.Total_Textbox.Name = "Total_Textbox";
            this.Total_Textbox.ReadOnly = true;
            this.Total_Textbox.Size = new System.Drawing.Size(270, 27);
            this.Total_Textbox.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(535, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 30);
            this.label8.TabIndex = 70;
            this.label8.Text = "TOTAL";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label9.Location = new System.Drawing.Point(25, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 30);
            this.label9.TabIndex = 72;
            this.label9.Text = "CANCEL ITEM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Reason_Textbox
            // 
            this.Reason_Textbox.AcceptsTab = true;
            this.Reason_Textbox.AllowDrop = true;
            this.Reason_Textbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Reason_Textbox.Location = new System.Drawing.Point(670, 364);
            this.Reason_Textbox.Multiline = true;
            this.Reason_Textbox.Name = "Reason_Textbox";
            this.Reason_Textbox.Size = new System.Drawing.Size(270, 65);
            this.Reason_Textbox.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.Location = new System.Drawing.Point(535, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 30);
            this.label10.TabIndex = 79;
            this.label10.Text = "REASON";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelQty_Textbox
            // 
            this.CancelQty_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CancelQty_Textbox.Location = new System.Drawing.Point(670, 324);
            this.CancelQty_Textbox.Name = "CancelQty_Textbox";
            this.CancelQty_Textbox.Size = new System.Drawing.Size(270, 27);
            this.CancelQty_Textbox.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.Location = new System.Drawing.Point(535, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 30);
            this.label11.TabIndex = 77;
            this.label11.Text = "CANCEL QTY";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelBy_Textbox
            // 
            this.CancelBy_Textbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.CancelBy_Textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CancelBy_Textbox.Location = new System.Drawing.Point(160, 325);
            this.CancelBy_Textbox.Name = "CancelBy_Textbox";
            this.CancelBy_Textbox.ReadOnly = true;
            this.CancelBy_Textbox.Size = new System.Drawing.Size(270, 27);
            this.CancelBy_Textbox.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(23, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 30);
            this.label12.TabIndex = 75;
            this.label12.Text = "CANCEL BY";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Cancel_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancel_Btn.Location = new System.Drawing.Point(776, 444);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(164, 36);
            this.Cancel_Btn.TabIndex = 81;
            this.Cancel_Btn.Text = "CANCEL ORDER";
            this.Cancel_Btn.UseVisualStyleBackColor = false;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.Location = new System.Drawing.Point(23, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 30);
            this.label14.TabIndex = 82;
            this.label14.Text = "ADD TO INVENTORY";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Action_cmbobox
            // 
            this.Action_cmbobox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Action_cmbobox.FormattingEnabled = true;
            this.Action_cmbobox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Action_cmbobox.Location = new System.Drawing.Point(160, 366);
            this.Action_cmbobox.Name = "Action_cmbobox";
            this.Action_cmbobox.Size = new System.Drawing.Size(270, 27);
            this.Action_cmbobox.TabIndex = 83;
            this.Action_cmbobox.Text = "Yes";
            // 
            // Discount_TextBox
            // 
            this.Discount_TextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Discount_TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Discount_TextBox.Location = new System.Drawing.Point(670, 233);
            this.Discount_TextBox.Name = "Discount_TextBox";
            this.Discount_TextBox.ReadOnly = true;
            this.Discount_TextBox.Size = new System.Drawing.Size(270, 27);
            this.Discount_TextBox.TabIndex = 85;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.Location = new System.Drawing.Point(535, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 30);
            this.label15.TabIndex = 84;
            this.label15.Text = "DISCOUNT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cancel_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(952, 503);
            this.ControlBox = false;
            this.Controls.Add(this.Discount_TextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Action_cmbobox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Reason_Textbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CancelQty_Textbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CancelBy_Textbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Total_Textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Qty_Textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Description_Textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Price_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ref_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pcode_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cancel_Order";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Cancel_Order_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pcode_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Price_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ref_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Qty_Textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Description_Textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Total_Textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Reason_Textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CancelQty_Textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CancelBy_Textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Action_cmbobox;
        private System.Windows.Forms.TextBox Discount_TextBox;
        private System.Windows.Forms.Label label15;
    }
}