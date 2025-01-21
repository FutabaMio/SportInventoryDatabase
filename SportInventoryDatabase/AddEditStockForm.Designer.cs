namespace SportInventoryDatabase
{
    partial class AddEditStockForm
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
            label1 = new Label();
            label2 = new Label();
            TB_name = new TextBox();
            TB_city = new TextBox();
            BTN_accept = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 170);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Город";
            // 
            // TB_name
            // 
            TB_name.Location = new Point(12, 81);
            TB_name.Name = "TB_name";
            TB_name.Size = new Size(356, 27);
            TB_name.TabIndex = 2;
            // 
            // TB_city
            // 
            TB_city.Location = new Point(12, 212);
            TB_city.Name = "TB_city";
            TB_city.Size = new Size(356, 27);
            TB_city.TabIndex = 3;
            // 
            // BTN_accept
            // 
            BTN_accept.Location = new Point(137, 409);
            BTN_accept.Name = "BTN_accept";
            BTN_accept.Size = new Size(94, 29);
            BTN_accept.TabIndex = 4;
            BTN_accept.Text = "OK";
            BTN_accept.UseVisualStyleBackColor = true;
            BTN_accept.Click += BTN_accept_Click;
            // 
            // AddEditStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(BTN_accept);
            Controls.Add(TB_city);
            Controls.Add(TB_name);
            Controls.Add(label2);
            Controls.Add(label1);
            //Name = "AddEditStockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о складе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TB_name;
        private TextBox TB_city;
        private Button BTN_accept;
    }
}