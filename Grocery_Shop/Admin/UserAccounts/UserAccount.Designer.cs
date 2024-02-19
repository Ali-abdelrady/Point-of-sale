namespace Grocery_Shop
{
    partial class UserAccount_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.CreateAccount_Page = new System.Windows.Forms.TabPage();
            this.Phone_Textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Address_Textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Salalry_Textbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.LastName_Textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MidName_Textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.firstName_Textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.Role_Combox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_Confimation_Txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Create_Password_Txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Create_Username_txtbox = new System.Windows.Forms.TextBox();
            this.cur_lbl = new System.Windows.Forms.Label();
            this.ChangePassword_Page = new System.Windows.Forms.TabPage();
            this.New_Password_Txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Confirm_NewPassword_Txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Current_Password_Txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Current_Username_Txtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.User_Table = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_COl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Search_Txtbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Label();
            this.product_list_lbl = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.CreateAccount_Page.SuspendLayout();
            this.ChangePassword_Page.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.CreateAccount_Page);
            this.metroTabControl1.Controls.Add(this.ChangePassword_Page);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1116, 703);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // CreateAccount_Page
            // 
            this.CreateAccount_Page.BackColor = System.Drawing.Color.White;
            this.CreateAccount_Page.Controls.Add(this.Phone_Textbox);
            this.CreateAccount_Page.Controls.Add(this.label9);
            this.CreateAccount_Page.Controls.Add(this.Address_Textbox);
            this.CreateAccount_Page.Controls.Add(this.label13);
            this.CreateAccount_Page.Controls.Add(this.Salalry_Textbox);
            this.CreateAccount_Page.Controls.Add(this.label14);
            this.CreateAccount_Page.Controls.Add(this.LastName_Textbox);
            this.CreateAccount_Page.Controls.Add(this.label10);
            this.CreateAccount_Page.Controls.Add(this.MidName_Textbox);
            this.CreateAccount_Page.Controls.Add(this.label11);
            this.CreateAccount_Page.Controls.Add(this.firstName_Textbox);
            this.CreateAccount_Page.Controls.Add(this.label12);
            this.CreateAccount_Page.Controls.Add(this.Create_Btn);
            this.CreateAccount_Page.Controls.Add(this.Role_Combox);
            this.CreateAccount_Page.Controls.Add(this.label1);
            this.CreateAccount_Page.Controls.Add(this.Password_Confimation_Txtbox);
            this.CreateAccount_Page.Controls.Add(this.label2);
            this.CreateAccount_Page.Controls.Add(this.Create_Password_Txtbox);
            this.CreateAccount_Page.Controls.Add(this.label6);
            this.CreateAccount_Page.Controls.Add(this.Create_Username_txtbox);
            this.CreateAccount_Page.Controls.Add(this.cur_lbl);
            this.CreateAccount_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateAccount_Page.Location = new System.Drawing.Point(4, 38);
            this.CreateAccount_Page.Name = "CreateAccount_Page";
            this.CreateAccount_Page.Size = new System.Drawing.Size(1108, 661);
            this.CreateAccount_Page.TabIndex = 0;
            this.CreateAccount_Page.Text = "CREATE ACCOUNT";
            // 
            // Phone_Textbox
            // 
            this.Phone_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Phone_Textbox.Location = new System.Drawing.Point(403, 304);
            this.Phone_Textbox.Multiline = true;
            this.Phone_Textbox.Name = "Phone_Textbox";
            this.Phone_Textbox.Size = new System.Drawing.Size(486, 30);
            this.Phone_Textbox.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(212, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 30);
            this.label9.TabIndex = 78;
            this.label9.Text = "PHONE NUMBER";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address_Textbox
            // 
            this.Address_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Address_Textbox.Location = new System.Drawing.Point(403, 267);
            this.Address_Textbox.Multiline = true;
            this.Address_Textbox.Name = "Address_Textbox";
            this.Address_Textbox.Size = new System.Drawing.Size(486, 30);
            this.Address_Textbox.TabIndex = 77;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(212, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 30);
            this.label13.TabIndex = 76;
            this.label13.Text = "ADDRESS";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Salalry_Textbox
            // 
            this.Salalry_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Salalry_Textbox.Location = new System.Drawing.Point(403, 229);
            this.Salalry_Textbox.Multiline = true;
            this.Salalry_Textbox.Name = "Salalry_Textbox";
            this.Salalry_Textbox.Size = new System.Drawing.Size(486, 30);
            this.Salalry_Textbox.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(212, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 30);
            this.label14.TabIndex = 74;
            this.label14.Text = "SALARY";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastName_Textbox
            // 
            this.LastName_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LastName_Textbox.Location = new System.Drawing.Point(403, 188);
            this.LastName_Textbox.Multiline = true;
            this.LastName_Textbox.Name = "LastName_Textbox";
            this.LastName_Textbox.Size = new System.Drawing.Size(486, 30);
            this.LastName_Textbox.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(212, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 30);
            this.label10.TabIndex = 72;
            this.label10.Text = "LAST NAME";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MidName_Textbox
            // 
            this.MidName_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MidName_Textbox.Location = new System.Drawing.Point(403, 151);
            this.MidName_Textbox.Multiline = true;
            this.MidName_Textbox.Name = "MidName_Textbox";
            this.MidName_Textbox.Size = new System.Drawing.Size(486, 30);
            this.MidName_Textbox.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 30);
            this.label11.TabIndex = 70;
            this.label11.Text = "MIDDLE NAME";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstName_Textbox
            // 
            this.firstName_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstName_Textbox.Location = new System.Drawing.Point(403, 113);
            this.firstName_Textbox.Multiline = true;
            this.firstName_Textbox.Name = "firstName_Textbox";
            this.firstName_Textbox.Size = new System.Drawing.Size(486, 30);
            this.firstName_Textbox.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(212, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 30);
            this.label12.TabIndex = 68;
            this.label12.Text = "FIRST NAME";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Create_Btn
            // 
            this.Create_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Create_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Create_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Create_Btn.Location = new System.Drawing.Point(713, 513);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(167, 36);
            this.Create_Btn.TabIndex = 67;
            this.Create_Btn.Text = "CREATE";
            this.Create_Btn.UseVisualStyleBackColor = false;
            this.Create_Btn.Click += new System.EventHandler(this.Create_Btn_Click);
            // 
            // Role_Combox
            // 
            this.Role_Combox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Role_Combox.FormattingEnabled = true;
            this.Role_Combox.IntegralHeight = false;
            this.Role_Combox.ItemHeight = 16;
            this.Role_Combox.Items.AddRange(new object[] {
            "admin",
            "cashier"});
            this.Role_Combox.Location = new System.Drawing.Point(403, 457);
            this.Role_Combox.Name = "Role_Combox";
            this.Role_Combox.Size = new System.Drawing.Size(486, 24);
            this.Role_Combox.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 65;
            this.label1.Text = "ROLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password_Confimation_Txtbox
            // 
            this.Password_Confimation_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Password_Confimation_Txtbox.Location = new System.Drawing.Point(403, 415);
            this.Password_Confimation_Txtbox.Multiline = true;
            this.Password_Confimation_Txtbox.Name = "Password_Confimation_Txtbox";
            this.Password_Confimation_Txtbox.Size = new System.Drawing.Size(486, 30);
            this.Password_Confimation_Txtbox.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 63;
            this.label2.Text = "RE-TYPE PASSWORD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Create_Password_Txtbox
            // 
            this.Create_Password_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Create_Password_Txtbox.Location = new System.Drawing.Point(403, 378);
            this.Create_Password_Txtbox.Multiline = true;
            this.Create_Password_Txtbox.Name = "Create_Password_Txtbox";
            this.Create_Password_Txtbox.Size = new System.Drawing.Size(486, 30);
            this.Create_Password_Txtbox.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 30);
            this.label6.TabIndex = 61;
            this.label6.Text = "PASSWORD";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Create_Username_txtbox
            // 
            this.Create_Username_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Create_Username_txtbox.Location = new System.Drawing.Point(403, 340);
            this.Create_Username_txtbox.Multiline = true;
            this.Create_Username_txtbox.Name = "Create_Username_txtbox";
            this.Create_Username_txtbox.Size = new System.Drawing.Size(486, 30);
            this.Create_Username_txtbox.TabIndex = 60;
            // 
            // cur_lbl
            // 
            this.cur_lbl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cur_lbl.Location = new System.Drawing.Point(212, 339);
            this.cur_lbl.Name = "cur_lbl";
            this.cur_lbl.Size = new System.Drawing.Size(129, 30);
            this.cur_lbl.TabIndex = 59;
            this.cur_lbl.Text = "USERNAME";
            this.cur_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangePassword_Page
            // 
            this.ChangePassword_Page.BackColor = System.Drawing.Color.White;
            this.ChangePassword_Page.Controls.Add(this.New_Password_Txtbox);
            this.ChangePassword_Page.Controls.Add(this.label3);
            this.ChangePassword_Page.Controls.Add(this.Update_Btn);
            this.ChangePassword_Page.Controls.Add(this.Confirm_NewPassword_Txtbox);
            this.ChangePassword_Page.Controls.Add(this.label4);
            this.ChangePassword_Page.Controls.Add(this.Current_Password_Txtbox);
            this.ChangePassword_Page.Controls.Add(this.label5);
            this.ChangePassword_Page.Controls.Add(this.Current_Username_Txtbox);
            this.ChangePassword_Page.Controls.Add(this.label7);
            this.ChangePassword_Page.Location = new System.Drawing.Point(4, 38);
            this.ChangePassword_Page.Name = "ChangePassword_Page";
            this.ChangePassword_Page.Size = new System.Drawing.Size(1108, 661);
            this.ChangePassword_Page.TabIndex = 1;
            this.ChangePassword_Page.Text = "CHANGE PASSWORD";
            // 
            // New_Password_Txtbox
            // 
            this.New_Password_Txtbox.Location = new System.Drawing.Point(412, 258);
            this.New_Password_Txtbox.Multiline = true;
            this.New_Password_Txtbox.Name = "New_Password_Txtbox";
            this.New_Password_Txtbox.Size = new System.Drawing.Size(486, 30);
            this.New_Password_Txtbox.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(221, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 60;
            this.label3.Text = "NEW PASSWORD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Update_Btn
            // 
            this.Update_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Btn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Update_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Update_Btn.Location = new System.Drawing.Point(737, 334);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(164, 36);
            this.Update_Btn.TabIndex = 58;
            this.Update_Btn.Text = "UPDATE";
            this.Update_Btn.UseVisualStyleBackColor = false;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Confirm_NewPassword_Txtbox
            // 
            this.Confirm_NewPassword_Txtbox.Location = new System.Drawing.Point(412, 298);
            this.Confirm_NewPassword_Txtbox.Multiline = true;
            this.Confirm_NewPassword_Txtbox.Name = "Confirm_NewPassword_Txtbox";
            this.Confirm_NewPassword_Txtbox.Size = new System.Drawing.Size(486, 30);
            this.Confirm_NewPassword_Txtbox.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(221, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 30);
            this.label4.TabIndex = 52;
            this.label4.Text = "CONFIRM PASSWORD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Current_Password_Txtbox
            // 
            this.Current_Password_Txtbox.Location = new System.Drawing.Point(412, 222);
            this.Current_Password_Txtbox.Multiline = true;
            this.Current_Password_Txtbox.Name = "Current_Password_Txtbox";
            this.Current_Password_Txtbox.Size = new System.Drawing.Size(486, 30);
            this.Current_Password_Txtbox.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(221, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 30);
            this.label5.TabIndex = 50;
            this.label5.Text = "PASSWORD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Current_Username_Txtbox
            // 
            this.Current_Username_Txtbox.Location = new System.Drawing.Point(412, 184);
            this.Current_Username_Txtbox.Multiline = true;
            this.Current_Username_Txtbox.Name = "Current_Username_Txtbox";
            this.Current_Username_Txtbox.Size = new System.Drawing.Size(486, 30);
            this.Current_Username_Txtbox.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label7.Location = new System.Drawing.Point(221, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 30);
            this.label7.TabIndex = 48;
            this.label7.Text = "USERNAME";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.User_Table);
            this.metroTabPage1.Controls.Add(this.Search_Txtbox);
            this.metroTabPage1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1108, 661);
            this.metroTabPage1.TabIndex = 3;
            this.metroTabPage1.Text = "USERS LIST";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // User_Table
            // 
            this.User_Table.AllowUserToAddRows = false;
            this.User_Table.AllowUserToDeleteRows = false;
            this.User_Table.AllowUserToResizeColumns = false;
            this.User_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.User_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.User_Table.BackgroundColor = System.Drawing.Color.White;
            this.User_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.User_Table.ColumnHeadersHeight = 40;
            this.User_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.User_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name_COl,
            this.Address_Col,
            this.Phone_Number,
            this.Salary_col,
            this.UserName_Col,
            this.Password_Col,
            this.Delete});
            this.User_Table.EnableHeadersVisualStyles = false;
            this.User_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(223)))));
            this.User_Table.Location = new System.Drawing.Point(-4, 66);
            this.User_Table.Name = "User_Table";
            this.User_Table.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(251)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.User_Table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.User_Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.User_Table.Size = new System.Drawing.Size(1112, 599);
            this.User_Table.TabIndex = 69;
            this.User_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_Table_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // Name_COl
            // 
            this.Name_COl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_COl.DataPropertyName = "NAME";
            this.Name_COl.HeaderText = "NAME";
            this.Name_COl.Name = "Name_COl";
            this.Name_COl.ReadOnly = true;
            // 
            // Address_Col
            // 
            this.Address_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address_Col.DataPropertyName = "ADDRESS";
            this.Address_Col.HeaderText = "ADDRESS";
            this.Address_Col.Name = "Address_Col";
            this.Address_Col.ReadOnly = true;
            this.Address_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Phone_Number
            // 
            this.Phone_Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone_Number.DataPropertyName = "PHONE_NUMBER";
            this.Phone_Number.HeaderText = "PHONE NUMBER";
            this.Phone_Number.Name = "Phone_Number";
            this.Phone_Number.ReadOnly = true;
            // 
            // Salary_col
            // 
            this.Salary_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Salary_col.DataPropertyName = "SALARY";
            this.Salary_col.HeaderText = "SALARY";
            this.Salary_col.Name = "Salary_col";
            this.Salary_col.ReadOnly = true;
            this.Salary_col.Width = 83;
            // 
            // UserName_Col
            // 
            this.UserName_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName_Col.DataPropertyName = "USERNAME";
            this.UserName_Col.HeaderText = "USERNAME";
            this.UserName_Col.Name = "UserName_Col";
            this.UserName_Col.ReadOnly = true;
            // 
            // Password_Col
            // 
            this.Password_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Password_Col.DataPropertyName = "PASSWORD";
            this.Password_Col.FillWeight = 35F;
            this.Password_Col.HeaderText = "PASSWORD";
            this.Password_Col.Name = "Password_Col";
            this.Password_Col.ReadOnly = true;
            this.Password_Col.Width = 108;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Delete.DataPropertyName = "DELETE";
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Grocery_Shop.Properties.Resources.icons8_trash_20;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 5;
            // 
            // Search_Txtbox
            // 
            this.Search_Txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.Search_Txtbox.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Search_Txtbox.ForeColor = System.Drawing.Color.Gray;
            this.Search_Txtbox.Location = new System.Drawing.Point(3, 19);
            this.Search_Txtbox.Name = "Search_Txtbox";
            this.Search_Txtbox.Size = new System.Drawing.Size(353, 25);
            this.Search_Txtbox.TabIndex = 70;
            this.Search_Txtbox.Text = " Search here";
            this.Search_Txtbox.WordWrap = false;
            this.Search_Txtbox.TextChanged += new System.EventHandler(this.Search_Txtbox_TextChanged);
            this.Search_Txtbox.Enter += new System.EventHandler(this.Search_Txtbox_Enter);
            this.Search_Txtbox.Leave += new System.EventHandler(this.Search_Txtbox_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Controls.Add(this.product_list_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 57);
            this.panel1.TabIndex = 22;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Close_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Close_Btn.Image = global::Grocery_Shop.Properties.Resources.icons8_close_window_50;
            this.Close_Btn.Location = new System.Drawing.Point(1064, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(55, 57);
            this.Close_Btn.TabIndex = 26;
            this.Close_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // product_list_lbl
            // 
            this.product_list_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.product_list_lbl.BackColor = System.Drawing.Color.Transparent;
            this.product_list_lbl.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_list_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.product_list_lbl.Location = new System.Drawing.Point(3, 12);
            this.product_list_lbl.Name = "product_list_lbl";
            this.product_list_lbl.Size = new System.Drawing.Size(316, 33);
            this.product_list_lbl.TabIndex = 1;
            this.product_list_lbl.Text = "USER ACCOUNT";
            this.product_list_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserAccount_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UserAccount_Form";
            this.Size = new System.Drawing.Size(1122, 769);
            this.Load += new System.EventHandler(this.UserAccount_Form_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.CreateAccount_Page.ResumeLayout(false);
            this.CreateAccount_Page.PerformLayout();
            this.ChangePassword_Page.ResumeLayout(false);
            this.ChangePassword_Page.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage CreateAccount_Page;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Close_Btn;
        private System.Windows.Forms.Label product_list_lbl;
        private System.Windows.Forms.TabPage ChangePassword_Page;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.TextBox Confirm_NewPassword_Txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Current_Password_Txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Current_Username_Txtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox New_Password_Txtbox;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TextBox Phone_Textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Address_Textbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Salalry_Textbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox LastName_Textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MidName_Textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox firstName_Textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.ComboBox Role_Combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_Confimation_Txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Create_Password_Txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Create_Username_txtbox;
        private System.Windows.Forms.Label cur_lbl;
        private System.Windows.Forms.DataGridView User_Table;
        private System.Windows.Forms.TextBox Search_Txtbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_COl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_Col;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}
