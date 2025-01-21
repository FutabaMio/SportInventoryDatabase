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
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            DG_Stocks.AutoGenerateColumns = true;
            LoadData();
        }

        private void LoadData()
        {

            using (var context = new ApplicationContext())
            {
                // Получение списка пользователей из базы данных
                var shops = context.Stocks
                    .Select(u => new
                    {
                        u.Id,
                        u.Name,
                        u.City,
                    })
                    .ToList();

                DG_Stocks.DataSource = shops; // Установка источника данных
            }
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            var addEditForm = new AddEditStockForm();
            addEditForm.ShowDialog();
            LoadData();  // Перезагружаем данные после добавления
        }

        private void BTN_edit_Click(object sender, EventArgs e)
        {
            if (DG_Stocks.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)DG_Stocks.SelectedRows[0].Cells["ID"].Value;

                using (var form = new AddEditStockForm(selectedProductId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var context = new ApplicationContext())
                        {
                            var product = context.Stocks.Find(selectedProductId);
                            if (product != null)
                            {
                                // Обновляем свойства товара

                                product.Name = form.Name;
                                product.City = form.City;
                                // Сохраняем изменения в базе данных
                                //context.SaveChanges();
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

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            if (DG_Stocks.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)DG_Stocks.SelectedRows[0].Cells["ID"].Value;

                var result = MessageBox.Show("Вы действительно хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new ApplicationContext())
                    {
                        var good = context.Stocks.Find(selectedUserId);
                        if (good != null)
                        {
                            context.Stocks.Remove(good);
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
