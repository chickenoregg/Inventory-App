
namespace ConsultingAppC969
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
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(120, 97);
            this.txtLoginUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(132, 22);
            this.txtLoginUsername.TabIndex = 0;
            this.txtLoginUsername.TextChanged += new System.EventHandler(this.txtLoginUsername_TextChanged);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(120, 181);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(132, 22);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(39, 101);
            this.lblLoginUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(73, 17);
            this.lblLoginUsername.TabIndex = 2;
            this.lblLoginUsername.Text = "Username";
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(39, 181);
            this.lblLoginPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(69, 17);
            this.lblLoginPassword.TabIndex = 3;
            this.lblLoginPassword.Text = "Password";
            this.lblLoginPassword.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Location = new System.Drawing.Point(57, 260);
            this.btnLoginLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(55, 28);
            this.btnLoginLogin.TabIndex = 4;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = true;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.Location = new System.Drawing.Point(199, 260);
            this.btnLoginExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(55, 28);
            this.btnLoginExit.TabIndex = 5;
            this.btnLoginExit.Text = "Exit";
            this.btnLoginExit.UseVisualStyleBackColor = true;
            this.btnLoginExit.Click += new System.EventHandler(this.btnLoginExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 334);
            this.Controls.Add(this.btnLoginExit);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.Button btnLoginExit;
    }
}

