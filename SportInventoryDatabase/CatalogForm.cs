using Microsoft.EntityFrameworkCore;
using SportInventoryDatabase.Models;
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
    public partial class CatalogForm : Form
    {
        private readonly ApplicationContext _context;

        public CatalogForm()
        {
            InitializeComponent();
            goodsDataGridView.AutoGenerateColumns = true;
            LoadData();
        }

        private void LoadData()
        {
           
            using (var context = new ApplicationContext())
            {
                // Получение списка пользователей из базы данных
                var goods = context.Goods
                    .Select(u => new
                    {
                        u.Id,
                        u.Name,
                        u.Category,
                        u.Count,
                        u.Price
                    })
                    .ToList();

                goodsDataGridView.DataSource = goods; // Установка источника данных
            }
        }
   

        // Обработчик для кнопки "Добавить товар"
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addEditForm = new AddEditProductForm();
            addEditForm.ShowDialog();
            LoadData();  // Перезагружаем данные после добавления
        }

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            if (goodsDataGridView.SelectedRows.Count > 0)
            {
                int selectedProductId = (int)goodsDataGridView.SelectedRows[0].Cells["ID"].Value;

                using (var form = new AddEditProductForm(selectedProductId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var context = new ApplicationContext())
                        {
                            var product = context.Goods.Find(selectedProductId);
                            if (product != null)
                            {
                                // Обновляем свойства товара
                                product.Name = form.Name;
                                product.Category = form.Category;
                                //product.Manufacturer.Name = form.ManufacturerName; // Переход к объекту Manufacturer
                                product.Count = form.Count;
                                product.Price = form.Price;

                                // Сохраняем изменения в базе данных
                                context.Goods.Update(product);
                                context.SaveChanges();
                            }
                        }

                         // Обновляем данные на экране
                    } LoadData();
                }
            } 
            else
            {
                MessageBox.Show("Выберите товар для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            LoadData();
        }

        

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (goodsDataGridView.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)goodsDataGridView.SelectedRows[0].Cells["ID"].Value;

                var result = MessageBox.Show("Вы действительно хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new ApplicationContext())
                    {
                        var good = context.Goods.Find(selectedUserId);
                        if (good != null)
                        {
                            context.Goods.Remove(good);
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
