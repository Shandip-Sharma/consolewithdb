namespace CreateAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSecondname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.listMonth = new System.Windows.Forms.ListBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listGender = new System.Windows.Forms.ListBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.lblCurrentEmail = new System.Windows.Forms.Label();
            this.txtCureentEmail = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.listLocation = new System.Windows.Forms.ListBox();
            this.btmSubmit = new System.Windows.Forms.Button();
            this.dgvCreateAccount = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Your Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtSecondname
            // 
            this.txtSecondname.Location = new System.Drawing.Point(118, 54);
            this.txtSecondname.Name = "txtSecondname";
            this.txtSecondname.PlaceholderText = "Last";
            this.txtSecondname.Size = new System.Drawing.Size(100, 23);
            this.txtSecondname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose your username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 98);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "@gmail.com";
            this.txtUsername.Size = new System.Drawing.Size(277, 23);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create a password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm your Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(12, 142);
            this.txtpassword.MaxLength = 8;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(277, 23);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.Tag = "";
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(12, 186);
            this.txtConfirmPassword.MaxLength = 8;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(277, 23);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(13, 216);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(51, 15);
            this.lblBirthday.TabIndex = 10;
            this.lblBirthday.Text = "Birthday";
            // 
            // listMonth
            // 
            this.listMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listMonth.FormattingEnabled = true;
            this.listMonth.ItemHeight = 21;
            this.listMonth.Items.AddRange(new object[] {
            "Month",
            "Jan",
            "Feb",
            "Mar",
            "April",
            "May",
            "Jun",
            "July",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.listMonth.Location = new System.Drawing.Point(14, 241);
            this.listMonth.Name = "listMonth";
            this.listMonth.Size = new System.Drawing.Size(86, 25);
            this.listMonth.TabIndex = 11;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(118, 245);
            this.txtday.MaxLength = 2;
            this.txtday.Name = "txtday";
            this.txtday.PlaceholderText = "Day";
            this.txtday.Size = new System.Drawing.Size(69, 23);
            this.txtday.TabIndex = 12;
            this.txtday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtday.TextChanged += new System.EventHandler(this.txtday_TextChanged);
            this.txtday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtday_KeyPress);
            this.txtday.Leave += new System.EventHandler(this.txtday_Leave);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(217, 243);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceholderText = "Year";
            this.txtYear.Size = new System.Drawing.Size(72, 23);
            this.txtYear.TabIndex = 13;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtYear.Leave += new System.EventHandler(this.txtYear_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gender";
            // 
            // listGender
            // 
            this.listGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listGender.FormattingEnabled = true;
            this.listGender.ItemHeight = 20;
            this.listGender.Items.AddRange(new object[] {
            "I am..",
            "Male",
            "Female",
            "Other"});
            this.listGender.Location = new System.Drawing.Point(13, 293);
            this.listGender.Name = "listGender";
            this.listGender.Size = new System.Drawing.Size(276, 24);
            this.listGender.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 320);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 15);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Mobile phone";
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Location = new System.Drawing.Point(14, 338);
            this.txtphoneNumber.MaxLength = 10;
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.PlaceholderText = "Enter the phone number";
            this.txtphoneNumber.Size = new System.Drawing.Size(275, 23);
            this.txtphoneNumber.TabIndex = 17;
            this.txtphoneNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtphoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphoneNumber_KeyPress);
            this.txtphoneNumber.Leave += new System.EventHandler(this.txtphoneNumber_Leave);
            // 
            // lblCurrentEmail
            // 
            this.lblCurrentEmail.AutoSize = true;
            this.lblCurrentEmail.Location = new System.Drawing.Point(11, 367);
            this.lblCurrentEmail.Name = "lblCurrentEmail";
            this.lblCurrentEmail.Size = new System.Drawing.Size(149, 15);
            this.lblCurrentEmail.TabIndex = 18;
            this.lblCurrentEmail.Text = "Your Current Email address";
            // 
            // txtCureentEmail
            // 
            this.txtCureentEmail.Location = new System.Drawing.Point(12, 385);
            this.txtCureentEmail.Name = "txtCureentEmail";
            this.txtCureentEmail.PlaceholderText = "Enter your current email address";
            this.txtCureentEmail.Size = new System.Drawing.Size(277, 23);
            this.txtCureentEmail.TabIndex = 19;
            this.txtCureentEmail.Leave += new System.EventHandler(this.txtCureentEmail_Leave);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(13, 415);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(53, 15);
            this.lblLocation.TabIndex = 20;
            this.lblLocation.Text = "Location";
            // 
            // listLocation
            // 
            this.listLocation.FormattingEnabled = true;
            this.listLocation.ItemHeight = 15;
            this.listLocation.Items.AddRange(new object[] {
            "Choose Location",
            "Kathmandu",
            "Lalitpur",
            "Bhaktapur",
            "Kavre",
            "Bharatpur",
            "Makawanpur",
            "Bara",
            "Parsa",
            "Rautahat",
            "Sarlahi",
            "Mohatri",
            "Dhanusha",
            "Sinduli",
            "Ramechap"});
            this.listLocation.Location = new System.Drawing.Point(12, 433);
            this.listLocation.Name = "listLocation";
            this.listLocation.Size = new System.Drawing.Size(277, 19);
            this.listLocation.TabIndex = 21;
            this.listLocation.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btmSubmit
            // 
            this.btmSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btmSubmit.Location = new System.Drawing.Point(239, 467);
            this.btmSubmit.Name = "btmSubmit";
            this.btmSubmit.Size = new System.Drawing.Size(97, 33);
            this.btmSubmit.TabIndex = 22;
            this.btmSubmit.Text = "Submit";
            this.btmSubmit.UseVisualStyleBackColor = false;
            this.btmSubmit.Click += new System.EventHandler(this.btmSubmit_Click);
            // 
            // dgvCreateAccount
            // 
            this.dgvCreateAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateAccount.Location = new System.Drawing.Point(310, 9);
            this.dgvCreateAccount.Name = "dgvCreateAccount";
            this.dgvCreateAccount.RowTemplate.Height = 25;
            this.dgvCreateAccount.Size = new System.Drawing.Size(484, 222);
            this.dgvCreateAccount.TabIndex = 23;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShow.Location = new System.Drawing.Point(310, 243);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(82, 25);
            this.btnShow.TabIndex = 24;
            this.btnShow.Text = "Show Data";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 502);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvCreateAccount);
            this.Controls.Add(this.btmSubmit);
            this.Controls.Add(this.listLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtCureentEmail);
            this.Controls.Add(this.lblCurrentEmail);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.listGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.listMonth);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecondname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Create your account";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblName;
        private TextBox txtFirstName;
        private TextBox txtSecondname;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
        private TextBox txtpassword;
        private TextBox txtConfirmPassword;
        private Label lblBirthday;
        private ListBox listMonth;
        private TextBox txtday;
        private TextBox txtYear;
        private Label label5;
        private ListBox listGender;
        private Label lblPhone;
        private TextBox txtphoneNumber;
        private Label lblCurrentEmail;
        private TextBox txtCureentEmail;
        private Label lblLocation;
        private ListBox listLocation;
        private Button btmSubmit;
        private DataGridView dgvCreateAccount;
        private Button btnShow;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}