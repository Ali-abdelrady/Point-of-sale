namespace Grocery_Shop
{
    partial class Discount_Form
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
            this.DiscAmount_lbl = new System.Windows.Forms.Label();
            this.TotalPrice_lbl = new System.Windows.Forms.Label();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.Discount_txtbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.DiscAmount_lbl);
            this.panel1.Controls.Add(this.TotalPrice_lbl);
            this.panel1.Controls.Add(this.Confirm_btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Total_lbl);
            this.panel1.Controls.Add(this.Discount_txtbox);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 213);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DiscAmount_lbl
            // 
            this.DiscAmount_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscAmount_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscAmount_lbl.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.DiscAmount_lbl.Location = new System.Drawing.Point(216, 98);
            this.DiscAmount_lbl.Name = "DiscAmount_lbl";
            this.DiscAmount_lbl.Size = new System.Drawing.Size(293, 35);
            this.DiscAmount_lbl.TabIndex = 8;
            this.DiscAmount_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalPrice_lbl
            // 
            this.TotalPrice_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalPrice_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPrice_lbl.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.TotalPrice_lbl.Location = new System.Drawing.Point(216, 22);
            this.TotalPrice_lbl.Name = "TotalPrice_lbl";
            this.TotalPrice_lbl.Size = new System.Drawing.Size(293, 35);
            this.TotalPrice_lbl.TabIndex = 7;
            this.TotalPrice_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TotalPrice_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Confirm_btn.FlatAppearance.BorderSize = 0;
            this.Confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Confirm_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Confirm_btn.Location = new System.Drawing.Point(393, 146);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(116, 31);
            this.Confirm_btn.TabIndex = 6;
            this.Confirm_btn.Text = "CONFIRM";
            this.Confirm_btn.UseVisualStyleBackColor = false;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(76, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "DISCOUNT AMOUNT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "DISCOUNT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Total_lbl
            // 
            this.Total_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lbl.Location = new System.Drawing.Point(75, 22);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(115, 35);
            this.Total_lbl.TabIndex = 3;
            this.Total_lbl.Text = "TOTAL PRICE";
            this.Total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Discount_txtbox
            // 
            this.Discount_txtbox.Location = new System.Drawing.Point(216, 60);
            this.Discount_txtbox.Multiline = true;
            this.Discount_txtbox.Name = "Discount_txtbox";
            this.Discount_txtbox.Size = new System.Drawing.Size(293, 35);
            this.Discount_txtbox.TabIndex = 1;
            this.Discount_txtbox.TextChanged += new System.EventHandler(this.Discount_txtbox_TextChanged);
            this.Discount_txtbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Discount_txtbox_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.Close_Btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 47);
            this.panel2.TabIndex = 24;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50__1_;
            this.Close_Btn.Location = new System.Drawing.Point(549, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(54, 47);
            this.Close_Btn.TabIndex = 25;
            this.Close_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 47);
            this.label1.TabIndex = 24;
            this.label1.Text = "PRODUCT MODULE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Discount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 262);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Discount_Form";
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.Discount_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.TextBox Discount_txtbox;
        private System.Windows.Forms.Label DiscAmount_lbl;
        private System.Windows.Forms.Label TotalPrice_lbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label label1;
    }
}