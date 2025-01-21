namespace SportInventoryDatabase
{
    partial class AddEditShopInfo
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
            TB_dealer = new TextBox();
            BTN_accept = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Дилер";
            // 
            // TB_dealer
            // 
            TB_dealer.Location = new Point(12, 62);
            TB_dealer.Name = "TB_dealer";
            TB_dealer.Size = new Size(302, 27);
            TB_dealer.TabIndex = 1;
            // 
            // BTN_accept
            // 
            BTN_accept.Location = new Point(113, 327);
            BTN_accept.Name = "BTN_accept";
            BTN_accept.Size = new Size(94, 29);
            BTN_accept.TabIndex = 2;
            BTN_accept.Text = "ОК";
            BTN_accept.UseVisualStyleBackColor = true;
            BTN_accept.Click += BTN_accept_Click;
            // 
            // AddEditShopInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 368);
            Controls.Add(BTN_accept);
            Controls.Add(TB_dealer);
            Controls.Add(label1);
            Name = "AddEditShopInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditShopInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_dealer;
        private Button BTN_accept;
    }
}