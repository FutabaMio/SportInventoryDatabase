namespace SportInventoryDatabase
{
    partial class LoginForm
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
            AppNameLB = new Label();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            LoginTB = new TextBox();
            PasswordTB = new TextBox();
            AcceptBTN = new Button();
            EraseBTN = new Button();
            ShowPasswordBTN = new Button();
            SuspendLayout();
            // 
            // AppNameLB
            // 
            AppNameLB.AutoSize = true;
            AppNameLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AppNameLB.Location = new Point(22, 28);
            AppNameLB.Name = "AppNameLB";
            AppNameLB.Size = new Size(348, 28);
            AppNameLB.TabIndex = 0;
            AppNameLB.Text = "База данных спортивных товаров";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(22, 105);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(55, 20);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(22, 194);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(65, 20);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Пароль:";
            // 
            // LoginTB
            // 
            LoginTB.Location = new Point(22, 128);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(348, 27);
            LoginTB.TabIndex = 3;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(22, 217);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(242, 27);
            PasswordTB.TabIndex = 4;
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // AcceptBTN
            // 
            AcceptBTN.Location = new Point(22, 302);
            AcceptBTN.Name = "AcceptBTN";
            AcceptBTN.Size = new Size(94, 29);
            AcceptBTN.TabIndex = 5;
            AcceptBTN.Text = "OK";
            AcceptBTN.UseVisualStyleBackColor = true;
            AcceptBTN.Click += AcceptBTN_Click;
            // 
            // EraseBTN
            // 
            EraseBTN.Location = new Point(276, 302);
            EraseBTN.Name = "EraseBTN";
            EraseBTN.Size = new Size(94, 29);
            EraseBTN.TabIndex = 6;
            EraseBTN.Text = "Стереть";
            EraseBTN.UseVisualStyleBackColor = true;
            EraseBTN.Click += EraseBTN_Click;
            // 
            // ShowPasswordBTN
            // 
            ShowPasswordBTN.Location = new Point(276, 217);
            ShowPasswordBTN.Name = "ShowPasswordBTN";
            ShowPasswordBTN.Size = new Size(94, 29);
            ShowPasswordBTN.TabIndex = 7;
            ShowPasswordBTN.Text = "Показать";
            ShowPasswordBTN.UseVisualStyleBackColor = true;
            ShowPasswordBTN.Click += ShowPasswordBTN_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 453);
            Controls.Add(ShowPasswordBTN);
            Controls.Add(EraseBTN);
            Controls.Add(AcceptBTN);
            Controls.Add(PasswordTB);
            Controls.Add(LoginTB);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(AppNameLB);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ShowPasswordBTN_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label AppNameLB;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Button AcceptBTN;
        private Button EraseBTN;
        private Button ShowPasswordBTN;
    }
}
