namespace SportInventoryDatabase
{
    partial class ShopForm
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
            shopsDataGridView = new DataGridView();
            label1 = new Label();
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)shopsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // shopsDataGridView
            // 
            shopsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shopsDataGridView.Location = new Point(12, 12);
            shopsDataGridView.Name = "shopsDataGridView";
            shopsDataGridView.RowHeadersWidth = 51;
            shopsDataGridView.Size = new Size(467, 426);
            shopsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 1;
            label1.Text = "Панель управления";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(537, 35);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(148, 29);
            AddButton.TabIndex = 2;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(537, 70);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(148, 29);
            EditButton.TabIndex = 3;
            EditButton.Text = "Изменить";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(537, 105);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(148, 29);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(shopsDataGridView);
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазины";
            ((System.ComponentModel.ISupportInitialize)shopsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView shopsDataGridView;
        private Label label1;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
    }
}