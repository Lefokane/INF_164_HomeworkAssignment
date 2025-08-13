namespace IN64_Homework_Assignment_1_Group53
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.grbSignIn = new System.Windows.Forms.GroupBox();
            this.rdbSignUp = new System.Windows.Forms.RadioButton();
            this.rdbLogin = new System.Windows.Forms.RadioButton();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSignInPassword = new System.Windows.Forms.TextBox();
            this.txtSignInEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSign = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCeateAccount = new System.Windows.Forms.GroupBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtSignUpPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSignUpStudentEmail = new System.Windows.Forms.TextBox();
            this.lblSignUpUpdate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lockTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLock = new System.Windows.Forms.Label();
            this.grbSignIn.SuspendLayout();
            this.grbCeateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSignIn
            // 
            this.grbSignIn.Controls.Add(this.lblLock);
            this.grbSignIn.Controls.Add(this.rdbSignUp);
            this.grbSignIn.Controls.Add(this.rdbLogin);
            this.grbSignIn.Controls.Add(this.btnlogin);
            this.grbSignIn.Controls.Add(this.btnClear);
            this.grbSignIn.Controls.Add(this.txtSignInPassword);
            this.grbSignIn.Controls.Add(this.txtSignInEmail);
            this.grbSignIn.Controls.Add(this.label4);
            this.grbSignIn.Controls.Add(this.label3);
            this.grbSignIn.Controls.Add(this.lblSign);
            this.grbSignIn.Controls.Add(this.label1);
            this.grbSignIn.Location = new System.Drawing.Point(13, 31);
            this.grbSignIn.Name = "grbSignIn";
            this.grbSignIn.Size = new System.Drawing.Size(451, 429);
            this.grbSignIn.TabIndex = 0;
            this.grbSignIn.TabStop = false;
            this.grbSignIn.Text = "SIgn In";
            // 
            // rdbSignUp
            // 
            this.rdbSignUp.AutoSize = true;
            this.rdbSignUp.Location = new System.Drawing.Point(237, 388);
            this.rdbSignUp.Name = "rdbSignUp";
            this.rdbSignUp.Size = new System.Drawing.Size(114, 20);
            this.rdbSignUp.TabIndex = 9;
            this.rdbSignUp.TabStop = true;
            this.rdbSignUp.Text = "Sign Up Mode";
            this.rdbSignUp.UseVisualStyleBackColor = true;
            this.rdbSignUp.CheckedChanged += new System.EventHandler(this.rdbSignUp_CheckedChanged);
            // 
            // rdbLogin
            // 
            this.rdbLogin.AutoSize = true;
            this.rdbLogin.Location = new System.Drawing.Point(33, 388);
            this.rdbLogin.Name = "rdbLogin";
            this.rdbLogin.Size = new System.Drawing.Size(99, 20);
            this.rdbLogin.TabIndex = 8;
            this.rdbLogin.TabStop = true;
            this.rdbLogin.Text = "Login Mode";
            this.rdbLogin.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(288, 329);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(92, 26);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 26);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.Location = new System.Drawing.Point(133, 258);
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.Size = new System.Drawing.Size(180, 22);
            this.txtSignInPassword.TabIndex = 5;
            this.txtSignInPassword.UseSystemPasswordChar = true;
            // 
            // txtSignInEmail
            // 
            this.txtSignInEmail.Location = new System.Drawing.Point(133, 160);
            this.txtSignInEmail.Name = "txtSignInEmail";
            this.txtSignInEmail.Size = new System.Drawing.Size(180, 22);
            this.txtSignInEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student email(u########@tuks.co.za)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSign
            // 
            this.lblSign.AutoSize = true;
            this.lblSign.Location = new System.Drawing.Point(6, 299);
            this.lblSign.Name = "lblSign";
            this.lblSign.Size = new System.Drawing.Size(45, 16);
            this.lblSign.TabIndex = 1;
            this.lblSign.Text = "ready.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " Welcome to Neo Fit Admin Manager";
            // 
            // grbCeateAccount
            // 
            this.grbCeateAccount.Controls.Add(this.btnSignUp);
            this.grbCeateAccount.Controls.Add(this.txtConfirmPassword);
            this.grbCeateAccount.Controls.Add(this.txtSignUpPassword);
            this.grbCeateAccount.Controls.Add(this.txtID);
            this.grbCeateAccount.Controls.Add(this.txtSignUpStudentEmail);
            this.grbCeateAccount.Controls.Add(this.lblSignUpUpdate);
            this.grbCeateAccount.Controls.Add(this.label6);
            this.grbCeateAccount.Controls.Add(this.label7);
            this.grbCeateAccount.Controls.Add(this.label8);
            this.grbCeateAccount.Controls.Add(this.label9);
            this.grbCeateAccount.Location = new System.Drawing.Point(470, 31);
            this.grbCeateAccount.Name = "grbCeateAccount";
            this.grbCeateAccount.Size = new System.Drawing.Size(441, 429);
            this.grbCeateAccount.TabIndex = 1;
            this.grbCeateAccount.TabStop = false;
            this.grbCeateAccount.Text = "Create Account";
            this.grbCeateAccount.Visible = false;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(276, 388);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(92, 26);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 258);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(174, 22);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.Location = new System.Drawing.Point(30, 198);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(174, 22);
            this.txtSignUpPassword.TabIndex = 7;
            this.txtSignUpPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 134);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 22);
            this.txtID.TabIndex = 8;
            // 
            // txtSignUpStudentEmail
            // 
            this.txtSignUpStudentEmail.Location = new System.Drawing.Point(30, 58);
            this.txtSignUpStudentEmail.Name = "txtSignUpStudentEmail";
            this.txtSignUpStudentEmail.Size = new System.Drawing.Size(174, 22);
            this.txtSignUpStudentEmail.TabIndex = 9;
            // 
            // lblSignUpUpdate
            // 
            this.lblSignUpUpdate.AutoSize = true;
            this.lblSignUpUpdate.Location = new System.Drawing.Point(27, 329);
            this.lblSignUpUpdate.Name = "lblSignUpUpdate";
            this.lblSignUpUpdate.Size = new System.Drawing.Size(112, 16);
            this.lblSignUpUpdate.TabIndex = 4;
            this.lblSignUpUpdate.Text = "Fill in your details.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password (8-26,upper,lower,digit,special)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "SA ID (13 digits)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Student email(u########@tuks.co.za)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lockTimer
            // 
            this.lockTimer.Interval = 1000;
            this.lockTimer.Tick += new System.EventHandler(this.lockTimer_Tick);
            // 
            // lblLock
            // 
            this.lblLock.AutoSize = true;
            this.lblLock.Location = new System.Drawing.Point(152, 38);
            this.lblLock.Name = "lblLock";
            this.lblLock.Size = new System.Drawing.Size(52, 16);
            this.lblLock.TabIndex = 10;
            this.lblLock.Text = "Locked";
            this.lblLock.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 512);
            this.Controls.Add(this.grbCeateAccount);
            this.Controls.Add(this.grbSignIn);
            this.Name = "Login";
            this.Text = "NeoFit-Sign In/Sign up";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grbSignIn.ResumeLayout(false);
            this.grbSignIn.PerformLayout();
            this.grbCeateAccount.ResumeLayout(false);
            this.grbCeateAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSignIn;
        private System.Windows.Forms.GroupBox grbCeateAccount;
        private System.Windows.Forms.RadioButton rdbSignUp;
        private System.Windows.Forms.RadioButton rdbLogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSignInPassword;
        private System.Windows.Forms.TextBox txtSignInEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtSignUpPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSignUpStudentEmail;
        private System.Windows.Forms.Label lblSignUpUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer lockTimer;
        private System.Windows.Forms.Label lblLock;
    }
}

