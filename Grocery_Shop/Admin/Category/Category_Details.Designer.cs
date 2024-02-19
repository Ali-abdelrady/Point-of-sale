namespace Grocery_Shop
{
    partial class Category_Details
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
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.SaveUpdate_Btn = new System.Windows.Forms.Button();
            this.Category_Txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(589, 46);
            this.panel1.TabIndex = 24;
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
            //this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50__1_;
            this.Close_Btn.Location = new System.Drawing.Point(548, 0);
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
            this.label1.Size = new System.Drawing.Size(184, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "Category Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Cancel_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancel_Btn.Location = new System.Drawing.Point(429, 133);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(103, 36);
            this.Cancel_Btn.TabIndex = 38;
            this.Cancel_Btn.Text = "CANCEL";
            this.Cancel_Btn.UseVisualStyleBackColor = false;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // SaveUpdate_Btn
            // 
            this.SaveUpdate_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.SaveUpdate_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUpdate_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SaveUpdate_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveUpdate_Btn.Location = new System.Drawing.Point(316, 133);
            this.SaveUpdate_Btn.Name = "SaveUpdate_Btn";
            this.SaveUpdate_Btn.Size = new System.Drawing.Size(103, 36);
            this.SaveUpdate_Btn.TabIndex = 36;
            this.SaveUpdate_Btn.Text = "SAVE";
            this.SaveUpdate_Btn.UseVisualStyleBackColor = false;
            this.SaveUpdate_Btn.Click += new System.EventHandler(this.SaveUpdate_Btn_Click);
            // 
            // Category_Txtbox
            // 
            this.Category_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Category_Txtbox.Location = new System.Drawing.Point(153, 83);
            this.Category_Txtbox.Name = "Category_Txtbox";
            this.Category_Txtbox.Size = new System.Drawing.Size(379, 25);
            this.Category_Txtbox.TabIndex = 35;
            this.Category_Txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Category_Txtbox_KeyDown);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(45, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "CATEGORY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Category_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 190);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.SaveUpdate_Btn);
            this.Controls.Add(this.Category_Txtbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Category_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Category_Details_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button SaveUpdate_Btn;
        private System.Windows.Forms.TextBox Category_Txtbox;
        private System.Windows.Forms.Label label4;
    }
}