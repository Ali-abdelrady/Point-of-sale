namespace Grocery_Shop
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_account_icon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.login_txtbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.user_account_icon);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 225);
            this.panel1.TabIndex = 0;
            // 
            // user_account_icon
            // 
            this.user_account_icon.Image = global::Grocery_Shop.Properties.Resources.security__2_;
            this.user_account_icon.Location = new System.Drawing.Point(4, 6);
            this.user_account_icon.Name = "user_account_icon";
            this.user_account_icon.Size = new System.Drawing.Size(377, 216);
            this.user_account_icon.TabIndex = 0;
            this.user_account_icon.Click += new System.EventHandler(this.user_account_icon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.login_btn);
            this.panel2.Controls.Add(this.password_txtbox);
            this.panel2.Controls.Add(this.login_txtbox);
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 318);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 1;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit_btn.Location = new System.Drawing.Point(65, 215);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(274, 33);
            this.exit_btn.TabIndex = 8;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_btn.Location = new System.Drawing.Point(65, 162);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(274, 33);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_txtbox
            // 
            this.password_txtbox.AcceptsReturn = true;
            this.password_txtbox.AcceptsTab = true;
            this.password_txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.password_txtbox.Location = new System.Drawing.Point(65, 106);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '.';
            this.password_txtbox.Size = new System.Drawing.Size(274, 25);
            this.password_txtbox.TabIndex = 6;
            this.password_txtbox.Enter += new System.EventHandler(this.password_txtbox_Enter);
            this.password_txtbox.Leave += new System.EventHandler(this.password_txtbox_Leave);
            // 
            // login_txtbox
            // 
            this.login_txtbox.AcceptsReturn = true;
            this.login_txtbox.AcceptsTab = true;
            this.login_txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.login_txtbox.Location = new System.Drawing.Point(65, 47);
            this.login_txtbox.Name = "login_txtbox";
            this.login_txtbox.Size = new System.Drawing.Size(274, 25);
            this.login_txtbox.TabIndex = 5;
            this.login_txtbox.Enter += new System.EventHandler(this.login_txtbox_Enter);
            this.login_txtbox.Leave += new System.EventHandler(this.login_txtbox_Leave);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.login_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label user_account_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox login_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}