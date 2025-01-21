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
            PriceNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)CountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(192, 409);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(94, 29);
            OkButton.TabIndex = 0;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 61);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(466, 27);
            NameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Категория";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(12, 130);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(466, 27);
            CategoryTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 7;
            label4.Text = "Количество";
            // 
            // CountNumericUpDown
            // 
            CountNumericUpDown.Location = new Point(12, 202);
            CountNumericUpDown.Name = "CountNumericUpDown";
            CountNumericUpDown.Size = new Size(150, 27);
            CountNumericUpDown.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 249);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 10;
            label5.Text = "Цена";
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Location = new Point(12, 272);
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(150, 27);
            PriceNumericUpDown.TabIndex = 11;
            // 
            // AddEditProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(PriceNumericUpDown);
            Controls.Add(label5);
            Controls.Add(CountNumericUpDown);
            Controls.Add(label4);
            Controls.Add(CategoryTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Controls.Add(OkButton);
            //Name = "AddEditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о продукте";
            ((System.ComponentModel.ISupportInitialize)CountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
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
        private NumericUpDown PriceNumericUpDown;
    }
}