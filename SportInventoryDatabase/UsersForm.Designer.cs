namespace SportInventoryDatabase
{
    partial class UsersForm
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
            dataGridViewUsers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 12);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.Size = new Size(604, 426);
            dataGridViewUsers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(640, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(640, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(148, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(640, 105);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(640, 12);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 4;
            label1.Text = "Панель управления";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewUsers);
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label label1;
    }
}