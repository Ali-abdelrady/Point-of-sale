namespace Grocery_Shop.Cashier
{
    partial class Order_Void
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Void));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Void_Btn = new System.Windows.Forms.Button();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.login_txtbox = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(455, 46);
            this.panel1.TabIndex = 57;
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
            this.Close_Btn.Location = new System.Drawing.Point(414, 0);
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
            this.label1.Text = "CANCEL ORDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(64, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(64, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 58;
            // 
            // Void_Btn
            // 
            this.Void_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Void_Btn.FlatAppearance.BorderSize = 0;
            this.Void_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Void_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Void_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Void_Btn.Location = new System.Drawing.Point(97, 165);
            this.Void_Btn.Name = "Void_Btn";
            this.Void_Btn.Size = new System.Drawing.Size(274, 33);
            this.Void_Btn.TabIndex = 61;
            this.Void_Btn.Text = "VOID";
            this.Void_Btn.UseVisualStyleBackColor = false;
            this.Void_Btn.Click += new System.EventHandler(this.Void_Btn_Click);
            // 
            // password_txtbox
            // 
            this.password_txtbox.AcceptsReturn = true;
            this.password_txtbox.AcceptsTab = true;
            this.password_txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.password_txtbox.Location = new System.Drawing.Point(97, 120);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '.';
            this.password_txtbox.Size = new System.Drawing.Size(274, 25);
            this.password_txtbox.TabIndex = 60;
            this.password_txtbox.Enter += new System.EventHandler(this.password_txtbox_Enter);
            this.password_txtbox.Leave += new System.EventHandler(this.password_txtbox_Leave);
            // 
            // login_txtbox
            // 
            this.login_txtbox.AcceptsReturn = true;
            this.login_txtbox.AcceptsTab = true;
            this.login_txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.login_txtbox.Location = new System.Drawing.Point(97, 72);
            this.login_txtbox.Name = "login_txtbox";
            this.login_txtbox.Size = new System.Drawing.Size(274, 25);
            this.login_txtbox.TabIndex = 59;
            this.login_txtbox.Enter += new System.EventHandler(this.login_txtbox_Enter);
            this.login_txtbox.Leave += new System.EventHandler(this.login_txtbox_Leave);
            // 
            // Order_Void
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(455, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Void_Btn);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.login_txtbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Order_Void";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_Void";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Order_Void_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Void_Btn;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox login_txtbox;
    }
}