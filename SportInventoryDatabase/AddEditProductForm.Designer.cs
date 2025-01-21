namespace SportInventoryDatabase
{
    partial class AddEditProductForm
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
            OkButton = new Button();
            label1 = new Label();
            NameTextBox = new TextBox();
            label2 = new Label();
            CategoryTextBox = new TextBox();
            label4 = new Label();
            CountNumericUpDown = new NumericUpDown();
            label5 = new Label();
            priceTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(168, 307);
            OkButton.Margin = new Padding(3, 2, 3, 2);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(82, 22);
            OkButton.TabIndex = 0;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(10, 46);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(408, 23);
            NameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 80);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Категория";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(10, 98);
            CategoryTextBox.Margin = new Padding(3, 2, 3, 2);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(408, 23);
            CategoryTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 134);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Количество";
            // 
            // CountNumericUpDown
            // 
            CountNumericUpDown.Location = new Point(10, 152);
            CountNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            CountNumericUpDown.Name = "CountNumericUpDown";
            CountNumericUpDown.Size = new Size(131, 23);
            CountNumericUpDown.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 187);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "Цена";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 205);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(129, 23);
            priceTextBox.TabIndex = 11;
            // 
            // AddEditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 338);
            Controls.Add(priceTextBox);
            Controls.Add(label5);
            Controls.Add(CountNumericUpDown);
            Controls.Add(label4);
            Controls.Add(CategoryTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(OkButton);
            Margin = new Padding(3, 2, 3, 2);
            //Name = "AddEditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о продукте";
            ((System.ComponentModel.ISupportInitialize)CountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Label label1;
        private TextBox NameTextBox;
        private Label label2;
        private TextBox CategoryTextBox;
        private Label label4;
        private NumericUpDown CountNumericUpDown;
        private Label label5;
        private TextBox priceTextBox;
    }
}