using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportInventoryDatabase
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            this.Hide();

            // Создаём и отображаем форму пользователей
            var usersForm = new UsersForm();
            usersForm.ShowDialog();

            // Возвращаем главное меню после закрытия формы пользователей
            this.Show();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            this.Hide();

            // Создаём и отображаем форму пользователей
            var catalogForm = new CatalogForm();
            catalogForm.ShowDialog();

            // Возвращаем главное меню после закрытия формы пользователей
            this.Show();
        }

        private void btnManufacturer_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            this.Hide();

            // Создаём и отображаем форму пользователей
            var manufacturerForm = new ManufacturerForm();
            manufacturerForm.ShowDialog();

            // Возвращаем главное меню после закрытия формы пользователей
            this.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            this.Hide();

            // Создаём и отображаем форму пользователей
            var shopForm = new ShopForm();
            shopForm.ShowDialog();

            // Возвращаем главное меню после закрытия формы пользователей
            this.Show();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            // Скрываем текущее окно
            this.Hide();

            // Создаём и отображаем форму пользователей
            var stockForm = new StockForm();
            stockForm.ShowDialog();

            // Возвращаем главное меню после закрытия формы пользователей
            this.Show();
        }
    }
}
