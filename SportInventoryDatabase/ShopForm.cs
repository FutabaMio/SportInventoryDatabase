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
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            shopsDataGridView.AutoGenerateColumns = true;
            LoadData();
        }

        private void LoadData()
        {

            using (var context = new ApplicationContext())
            {
                // Получение списка пользователей из базы данных
                var shops = context.Shops
                    .Select(u => new
                    {
                        u.Id,
                        u.Dealer,
                    })
                    .ToList();

                shopsDataGridView.DataSource = shops; // Установка источника данных
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addEditForm = new AddEditShopInfo();
            addEditForm.ShowDialog();
            LoadData();  // Перезагружаем данные после добавления
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (shopsDataGridView.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)shopsDataGridView.SelectedRows[0].Cells["ID"].Value;

                using (var form = new AddEditShopInfo(selectedProductId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var context = new ApplicationContext())
                        {
                            var product = context.Shops.Find(selectedProductId);
                            if (product != null)
                            {
                                // Обновляем свойства товара
                                
                                product.Dealer = form.Dealer;

                                // Сохраняем изменения в базе данных
                                context.SaveChanges();
                            }
                        }

                        LoadData(); // Обновляем данные на экране
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите товар для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (shopsDataGridView.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)shopsDataGridView.SelectedRows[0].Cells["ID"].Value;

                var result = MessageBox.Show("Вы действительно хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new ApplicationContext())
                    {
                        var good = context.Shops.Find(selectedUserId);
                        if (good != null)
                        {
                            context.Shops.Remove(good);
                            context.SaveChanges();
                        }
                    }

                    LoadData(); // Обновляем данные
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
