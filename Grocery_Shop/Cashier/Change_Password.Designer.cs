namespace Grocery_Shop.Cashier
{
    partial class Change_Password
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
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Confirmation_Txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_Txtbox = new System.Windows.Forms.TextBox();
            this.cur_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Cancel_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancel_Btn.Location = new System.Drawing.Point(441, 172);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(103, 36);
            this.Cancel_Btn.TabIndex = 56;
            this.Cancel_Btn.Text = "CANCEL";
            this.Cancel_Btn.UseVisualStyleBackColor = false;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Save_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Save_Btn.Location = new System.Drawing.Point(332, 172);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(103, 36);
            this.Save_Btn.TabIndex = 55;
            this.Save_Btn.Text = "SAVE";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
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
            this.panel1.Size = new System.Drawing.Size(562, 46);
            this.panel1.TabIndex = 54;
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
            this.Close_Btn.Location = new System.Drawing.Point(521, 0);
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
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "CHANGE PASSWORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Confirmation_Txtbox
            // 
            this.Confirmation_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Confirmation_Txtbox.Location = new System.Drawing.Point(162, 116);
            this.Confirmation_Txtbox.Multiline = true;
            this.Confirmation_Txtbox.Name = "Confirmation_Txtbox";
            this.Confirmation_Txtbox.Size = new System.Drawing.Size(381, 30);
            this.Confirmation_Txtbox.TabIndex = 60;
            this.Confirmation_Txtbox.Enter += new System.EventHandler(this.Confirmation_Txtbox_Enter);
            this.Confirmation_Txtbox.Leave += new System.EventHandler(this.Confirmation_Txtbox_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "CONFIRM PASSWORD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password_Txtbox
            // 
            this.Password_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Password_Txtbox.Location = new System.Drawing.Point(162, 80);
            this.Password_Txtbox.Multiline = true;
            this.Password_Txtbox.Name = "Password_Txtbox";
            this.Password_Txtbox.Size = new System.Drawing.Size(381, 30);
            this.Password_Txtbox.TabIndex = 58;
            this.Password_Txtbox.Enter += new System.EventHandler(this.Password_Txtbox_Enter);
            this.Password_Txtbox.Leave += new System.EventHandler(this.Password_Txtbox_Leave);
            // 
            // cur_lbl
            // 
            this.cur_lbl.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cur_lbl.Location = new System.Drawing.Point(11, 80);
            this.cur_lbl.Name = "cur_lbl";
            this.cur_lbl.Size = new System.Drawing.Size(134, 30);
            this.cur_lbl.TabIndex = 57;
            this.cur_lbl.Text = "NEW PASSWORD";
            this.cur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 221);
            this.ControlBox = false;
            this.Controls.Add(this.Confirmation_Txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_Txtbox);
            this.Controls.Add(this.cur_lbl);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Change_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Confirmation_Txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_Txtbox;
        private System.Windows.Forms.Label cur_lbl;
    }
}