namespace Stokvel_Management_System
{
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBxGender = new System.Windows.Forms.ComboBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtTown);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtBankName);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbBxGender);
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 252);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Infromation :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(460, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(13, 80);
            this.txtID.Mask = "0000000000000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(96, 24);
            this.txtID.TabIndex = 26;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(460, 80);
            this.txtNumber.Mask = "(999) 000-0000";
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 24);
            this.txtNumber.TabIndex = 25;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(261, 192);
            this.txtCode.Mask = "0000";
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(58, 24);
            this.txtCode.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(258, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = " Postal Code :";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(9, 192);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 24);
            this.txtTown.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Town :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(457, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(460, 134);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(170, 82);
            this.txtAddress.TabIndex = 18;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(261, 135);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(100, 24);
            this.txtBankName.TabIndex = 16;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(9, 135);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 24);
            this.txtAccount.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "ID Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Account Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phone Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bank Name :";
            // 
            // cmbBxGender
            // 
            this.cmbBxGender.FormattingEnabled = true;
            this.cmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBxGender.Location = new System.Drawing.Point(261, 80);
            this.cmbBxGender.Name = "cmbBxGender";
            this.cmbBxGender.Size = new System.Drawing.Size(121, 24);
            this.cmbBxGender.TabIndex = 9;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(261, 35);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(142, 24);
            this.txtLast.TabIndex = 7;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(9, 35);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(174, 24);
            this.txtFirst.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(64, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 37);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(132, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 98);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login details :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(262, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(171, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(264, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(512, 437);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(170, 37);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(273, 280);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 37);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Generate Username:";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 486);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdd";
            this.Text = "Add Member ";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBxGender;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtNumber;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}