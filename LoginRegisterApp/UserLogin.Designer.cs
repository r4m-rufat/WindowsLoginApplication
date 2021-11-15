
namespace LoginRegisterApp
{
    partial class UserLogin
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
            this.lb_error_message = new System.Windows.Forms.Label();
            this.lb_create_new_account = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_error_message
            // 
            this.lb_error_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_error_message.AutoSize = true;
            this.lb_error_message.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_error_message.ForeColor = System.Drawing.Color.Red;
            this.lb_error_message.Location = new System.Drawing.Point(185, 327);
            this.lb_error_message.Name = "lb_error_message";
            this.lb_error_message.Size = new System.Drawing.Size(181, 22);
            this.lb_error_message.TabIndex = 14;
            this.lb_error_message.Text = "There is no account !";
            this.lb_error_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_error_message.Visible = false;
            // 
            // lb_create_new_account
            // 
            this.lb_create_new_account.AutoSize = true;
            this.lb_create_new_account.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_create_new_account.Location = new System.Drawing.Point(186, 296);
            this.lb_create_new_account.Name = "lb_create_new_account";
            this.lb_create_new_account.Size = new System.Drawing.Size(189, 17);
            this.lb_create_new_account.TabIndex = 13;
            this.lb_create_new_account.Text = "Don\'t you have an account ?";
            this.lb_create_new_account.Click += new System.EventHandler(this.lb_create_new_account_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(224, 231);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 34);
            this.btn_login.TabIndex = 12;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_password.Location = new System.Drawing.Point(146, 150);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(102, 23);
            this.lb_password.TabIndex = 11;
            this.lb_password.Text = "Password: ";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_username.Location = new System.Drawing.Point(141, 103);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(107, 23);
            this.lb_username.TabIndex = 10;
            this.lb_username.Text = "Username: ";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_password.Location = new System.Drawing.Point(259, 148);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(116, 30);
            this.tb_password.TabIndex = 9;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_username.Location = new System.Drawing.Point(259, 101);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(116, 30);
            this.tb_username.TabIndex = 8;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.lb_error_message);
            this.Controls.Add(this.lb_create_new_account);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "UserLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_error_message;
        private System.Windows.Forms.Label lb_create_new_account;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
    }
}

