namespace Grocery_Shop
{
    partial class Quantity_form
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
            this.quantity_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quantity_txtbox
            // 
            this.quantity_txtbox.BackColor = System.Drawing.SystemColors.Info;
            this.quantity_txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantity_txtbox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.quantity_txtbox.Location = new System.Drawing.Point(0, 0);
            this.quantity_txtbox.Multiline = true;
            this.quantity_txtbox.Name = "quantity_txtbox";
            this.quantity_txtbox.Size = new System.Drawing.Size(122, 52);
            this.quantity_txtbox.TabIndex = 0;
            this.quantity_txtbox.TextChanged += new System.EventHandler(this.quantity_txtbox_TextChanged);
            this.quantity_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantity_txtbox_KeyDown);
            // 
            // Quantity_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(122, 52);
            this.Controls.Add(this.quantity_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Quantity_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quantity_txtbox;
    }
}