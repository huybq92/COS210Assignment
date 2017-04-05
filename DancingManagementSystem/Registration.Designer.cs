namespace DancingManagementSystem
{
    partial class Registration
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxFirstname = new System.Windows.Forms.TextBox();
            this.txtboxLastname = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtboxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtboxMobile = new System.Windows.Forms.TextBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(50, 129);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(149, 13);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Please choose your username";
            // 
            // txtboxFirstname
            // 
            this.txtboxFirstname.Location = new System.Drawing.Point(53, 86);
            this.txtboxFirstname.Name = "txtboxFirstname";
            this.txtboxFirstname.Size = new System.Drawing.Size(79, 20);
            this.txtboxFirstname.TabIndex = 1;
            this.txtboxFirstname.Text = "First";
            this.txtboxFirstname.GotFocus += new System.EventHandler(this.txtboxFirstname_GotFocus);
            // 
            // txtboxLastname
            // 
            this.txtboxLastname.Location = new System.Drawing.Point(138, 86);
            this.txtboxLastname.Name = "txtboxLastname";
            this.txtboxLastname.Size = new System.Drawing.Size(79, 20);
            this.txtboxLastname.TabIndex = 2;
            this.txtboxLastname.Text = "Last";
            this.txtboxLastname.GotFocus += new System.EventHandler(this.txtboxLastname_GotFocus);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(100, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Create your own account";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(53, 145);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(164, 20);
            this.txtboxUsername.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(223, 145);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 20);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.TabStop = false;
            this.btnCheck.Text = "Check availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(50, 187);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Create a password";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(53, 203);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(120, 20);
            this.txtboxPassword.TabIndex = 4;
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(50, 226);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(113, 13);
            this.lblPasswordConfirm.TabIndex = 9;
            this.lblPasswordConfirm.Text = "Confirm your password";
            // 
            // txtboxPasswordConfirm
            // 
            this.txtboxPasswordConfirm.Location = new System.Drawing.Point(53, 242);
            this.txtboxPasswordConfirm.Name = "txtboxPasswordConfirm";
            this.txtboxPasswordConfirm.PasswordChar = '*';
            this.txtboxPasswordConfirm.Size = new System.Drawing.Size(120, 20);
            this.txtboxPasswordConfirm.TabIndex = 5;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(50, 284);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 340);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(53, 356);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(146, 20);
            this.txtboxEmail.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(258, 406);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(177, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(209, 340);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(38, 13);
            this.lblMobile.TabIndex = 11;
            this.lblMobile.Text = "Mobile";
            // 
            // txtboxMobile
            // 
            this.txtboxMobile.Location = new System.Drawing.Point(212, 356);
            this.txtboxMobile.Name = "txtboxMobile";
            this.txtboxMobile.Size = new System.Drawing.Size(120, 20);
            this.txtboxMobile.TabIndex = 8;
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(52, 303);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(195, 20);
            this.datePickerBirthday.TabIndex = 16;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 452);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtboxLastname);
            this.Controls.Add(this.txtboxPasswordConfirm);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.txtboxMobile);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxFirstname);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtboxFirstname;
        private System.Windows.Forms.TextBox txtboxLastname;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtboxPasswordConfirm;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtboxMobile;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
    }
}