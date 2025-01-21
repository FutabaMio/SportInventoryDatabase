namespace SportInventoryDatabase
{
    partial class MainMenuForm
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
            btnUsers = new Button();
            btnGoods = new Button();
            btnManufacturer = new Button();
            btnShop = new Button();
            btnStocks = new Button();
            SuspendLayout();
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(12, 33);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(131, 42);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Пользователи";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnGoods
            // 
            btnGoods.Location = new Point(12, 81);
            btnGoods.Name = "btnGoods";
            btnGoods.Size = new Size(131, 42);
            btnGoods.TabIndex = 1;
            btnGoods.Text = "Каталог";
            btnGoods.UseVisualStyleBackColor = true;
            btnGoods.Click += btnGoods_Click;
            // 
            // btnManufacturer
            // 
            btnManufacturer.Location = new Point(12, 129);
            btnManufacturer.Name = "btnManufacturer";
            btnManufacturer.Size = new Size(131, 42);
            btnManufacturer.TabIndex = 2;
            btnManufacturer.Text = "Производители";
            btnManufacturer.UseVisualStyleBackColor = true;
            btnManufacturer.Click += btnManufacturer_Click;
            // 
            // btnShop
            // 
            btnShop.Location = new Point(12, 177);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(131, 42);
            btnShop.TabIndex = 3;
            btnShop.Text = "Магазины";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
            // 
            // btnStocks
            // 
            btnStocks.Location = new Point(12, 225);
            btnStocks.Name = "btnStocks";
            btnStocks.Size = new Size(131, 42);
            btnStocks.TabIndex = 4;
            btnStocks.Text = "Склады";
            btnStocks.UseVisualStyleBackColor = true;
            btnStocks.Click += btnStocks_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(163, 330);
            Controls.Add(btnStocks);
            Controls.Add(btnShop);
            Controls.Add(btnManufacturer);
            Controls.Add(btnGoods);
            Controls.Add(btnUsers);
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsers;
        private Button btnGoods;
        private Button btnManufacturer;
        private Button btnShop;
        private Button btnStocks;
    }
}