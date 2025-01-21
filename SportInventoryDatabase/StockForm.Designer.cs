namespace SportInventoryDatabase
{
    partial class StockForm
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
            DG_Stocks = new DataGridView();
            label1 = new Label();
            BTN_add = new Button();
            BTN_edit = new Button();
            BTN_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_Stocks).BeginInit();
            SuspendLayout();
            // 
            // DG_Stocks
            // 
            DG_Stocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Stocks.Location = new Point(12, 12);
            DG_Stocks.Name = "DG_Stocks";
            DG_Stocks.RowHeadersWidth = 51;
            DG_Stocks.Size = new Size(565, 426);
            DG_Stocks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(623, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 1;
            label1.Text = "Панель управления";
            // 
            // BTN_add
            // 
            BTN_add.Location = new Point(623, 35);
            BTN_add.Name = "BTN_add";
            BTN_add.Size = new Size(148, 29);
            BTN_add.TabIndex = 2;
            BTN_add.Text = "Добавить";
            BTN_add.UseVisualStyleBackColor = true;
            BTN_add.Click += BTN_add_Click;
            // 
            // BTN_edit
            // 
            BTN_edit.Location = new Point(623, 70);
            BTN_edit.Name = "BTN_edit";
            BTN_edit.Size = new Size(148, 29);
            BTN_edit.TabIndex = 3;
            BTN_edit.Text = "Изменить";
            BTN_edit.UseVisualStyleBackColor = true;
            BTN_edit.Click += BTN_edit_Click;
            // 
            // BTN_delete
            // 
            BTN_delete.Location = new Point(623, 105);
            BTN_delete.Name = "BTN_delete";
            BTN_delete.Size = new Size(148, 29);
            BTN_delete.TabIndex = 4;
            BTN_delete.Text = "Удалить";
            BTN_delete.UseVisualStyleBackColor = true;
            BTN_delete.Click += BTN_delete_Click;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_delete);
            Controls.Add(BTN_edit);
            Controls.Add(BTN_add);
            Controls.Add(label1);
            Controls.Add(DG_Stocks);
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склады";
            ((System.ComponentModel.ISupportInitialize)DG_Stocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DG_Stocks;
        private Label label1;
        private Button BTN_add;
        private Button BTN_edit;
        private Button BTN_delete;
    }
}