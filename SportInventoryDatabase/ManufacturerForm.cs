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
    public partial class ManufacturerForm : Form
    {
        public ManufacturerForm()
        {
            InitializeComponent();
            manufacturerDataGridView.AutoGenerateColumns = true;
            LoadData();
        }

        private void LoadData()
        {

            using (var context = new ApplicationContext())
            {
                // Получение списка пользователей из базы данных
                var manufacturers = context.Manufacturers
                    .Select(u => new
                    {
                        u.Id,
                        u.Name,
                    })
                    .ToList();

                manufacturerDataGridView.DataSource = manufacturers; // Установка источника данных
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditManufacturerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var context = new ApplicationContext())
                    {
                        // Добавляем нового пользователя
                        context.Manufacturers.Add(new Models.Manufacturer
                        {
                            Name = form.Name,
                            Country = form.Country,
                        });
                        context.SaveChanges();
                    }

                    LoadData(); // Обновляем данные
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (manufacturerDataGridView.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)manufacturerDataGridView.SelectedRows[0].Cells["ID"].Value;

                using (var form = new AddEditManufacturerForm(selectedProductId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var context = new ApplicationContext())
                        {
                            var product = context.Manufacturers.Find(selectedProductId);
                            if (product != null)
                            {
                                // Обновляем свойства товара
                                product.Name = form.Name;
                                product.Country = form.Country;

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
            if (manufacturerDataGridView.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)manufacturerDataGridView.SelectedRows[0].Cells["ID"].Value;

                var result = MessageBox.Show("Вы действительно хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new ApplicationContext())
                    {
                        var good = context.Manufacturers.Find(selectedUserId);
                        if (good != null)
                        {
                            context.Manufacturers.Remove(good);
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
