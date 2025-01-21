namespace SportInventoryDatabase
{
    partial class AddEditManufacturerForm
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
            AcceptButton = new Button();
            label1 = new Label();
            label2 = new Label();
            nameTextBox = new TextBox();
            countryTextBox = new TextBox();
            SuspendLayout();
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(158, 254);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(94, 29);
            AcceptButton.TabIndex = 0;
            AcceptButton.Text = "OK";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 115);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Страна";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 62);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(390, 27);
            nameTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(12, 142);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(390, 27);
            countryTextBox.TabIndex = 4;
            // 
            // AddEditManufacturerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 311);
            Controls.Add(countryTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AcceptButton);
            //Name = "AddEditManufacturerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEditManufacturerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AcceptButton;
        private Label label1;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox countryTextBox;
    }
}