namespace SportInventoryDatabase
{
    partial class AddEditUserForm
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
            btnSave = new Button();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLogin = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(183, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "ОК";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(9, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(447, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(9, 125);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(447, 27);
            txtSecondName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(9, 197);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(109, 27);
            txtAge.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 102);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Возраст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 238);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 7;
            label4.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(9, 261);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(447, 27);
            txtLogin.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 303);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 9;
            label5.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(9, 326);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(447, 27);
            txtPassword.TabIndex = 10;
            // 
            // AddEditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAge);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSave);
            Name = "AddEditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о пользователе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtAge;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLogin;
        private Label label5;
        private TextBox txtPassword;
    }
}