
namespace LoginRegisterApp
{
    partial class UserRegister
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
            this.lb_success_message = new System.Windows.Forms.Label();
            this.lb_pass_login = new System.Windows.Forms.Label();
            this.lb_confirm_password = new System.Windows.Forms.Label();
            this.tb_confirm_password = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_error_message
            // 
            this.lb_error_message.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_error_message.ForeColor = System.Drawing.Color.Red;
            this.lb_error_message.Location = new System.Drawing.Point(54, 356);
            this.lb_error_message.Name = "lb_error_message";
            this.lb_error_message.Size = new System.Drawing.Size(487, 51);
            this.lb_error_message.TabIndex = 33;
            this.lb_error_message.Text = "Error message";
            this.lb_error_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_error_message.Visible = false;
            // 
            // lb_success_message
            // 
            this.lb_success_message.AutoSize = true;
            this.lb_success_message.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_success_message.ForeColor = System.Drawing.Color.Green;
            this.lb_success_message.Location = new System.Drawing.Point(134, 407);
            this.lb_success_message.Name = "lb_success_message";
            this.lb_success_message.Size = new System.Drawing.Size(355, 22);
            this.lb_success_message.TabIndex = 32;
            this.lb_success_message.Text = "You have successfully created an account !";
            this.lb_success_message.Visible = false;
            // 
            // lb_pass_login
            // 
            this.lb_pass_login.AutoSize = true;
            this.lb_pass_login.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_pass_login.Location = new System.Drawing.Point(239, 329);
            this.lb_pass_login.Name = "lb_pass_login";
            this.lb_pass_login.Size = new System.Drawing.Size(154, 17);
            this.lb_pass_login.TabIndex = 31;
            this.lb_pass_login.Text = "Have you an account ?";
            this.lb_pass_login.Click += new System.EventHandler(this.lb_pass_login_Click);
            // 
            // lb_confirm_password
            // 
            this.lb_confirm_password.AutoSize = true;
            this.lb_confirm_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_confirm_password.Location = new System.Drawing.Point(178, 228);
            this.lb_confirm_password.Name = "lb_confirm_password";
            this.lb_confirm_password.Size = new System.Drawing.Size(91, 23);
            this.lb_confirm_password.TabIndex = 30;
            this.lb_confirm_password.Text = "Confirm: ";
            // 
            // tb_confirm_password
            // 
            this.tb_confirm_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_confirm_password.Location = new System.Drawing.Point(289, 221);
            this.tb_confirm_password.Name = "tb_confirm_password";
            this.tb_confirm_password.Size = new System.Drawing.Size(116, 30);
            this.tb_confirm_password.TabIndex = 29;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_register.Location = new System.Drawing.Point(269, 281);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(103, 34);
            this.btn_register.TabIndex = 28;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_password.Location = new System.Drawing.Point(167, 187);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(102, 23);
            this.lb_password.TabIndex = 27;
            this.lb_password.Text = "Password: ";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_username.Location = new System.Drawing.Point(162, 140);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(107, 23);
            this.lb_username.TabIndex = 26;
            this.lb_username.Text = "Username: ";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_password.Location = new System.Drawing.Point(289, 180);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(116, 30);
            this.tb_password.TabIndex = 25;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_username.Location = new System.Drawing.Point(289, 133);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(116, 30);
            this.tb_username.TabIndex = 24;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_email.Location = new System.Drawing.Point(199, 95);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(70, 23);
            this.lb_email.TabIndex = 23;
            this.lb_email.Text = "Email: ";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_fullname.Location = new System.Drawing.Point(171, 43);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(98, 23);
            this.lb_fullname.TabIndex = 22;
            this.lb_fullname.Text = "Fullname: ";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_email.Location = new System.Drawing.Point(289, 88);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(116, 30);
            this.tb_email.TabIndex = 21;
            // 
            // tb_fullname
            // 
            this.tb_fullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_fullname.Location = new System.Drawing.Point(289, 41);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(116, 30);
            this.tb_fullname.TabIndex = 20;
            // 
            // UserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.lb_error_message);
            this.Controls.Add(this.lb_success_message);
            this.Controls.Add(this.lb_pass_login);
            this.Controls.Add(this.lb_confirm_password);
            this.Controls.Add(this.tb_confirm_password);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_fullname);
            this.Name = "UserRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRegister";
            this.Load += new System.EventHandler(this.UserRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_error_message;
        private System.Windows.Forms.Label lb_success_message;
        private System.Windows.Forms.Label lb_pass_login;
        private System.Windows.Forms.Label lb_confirm_password;
        private System.Windows.Forms.TextBox tb_confirm_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_fullname;
    }
}