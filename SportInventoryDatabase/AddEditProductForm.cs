﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using SportInventoryDatabase.Models;

namespace SportInventoryDatabase
{
    public partial class AddEditProductForm : Form
    {
        private Goods _currentProduct { get; set; }
        private readonly ApplicationContext _context;
        private int? _productId;
        public AddEditProductForm(int? productId = null)
        {
            InitializeComponent();
            // _context = context;
            _productId = productId;

            if (productId.HasValue)
            {
                LoadUserData(productId.Value);
            }

            if (_currentProduct != null)
            {
                // Заполняем поля, если редактируем товар
                NameTextBox.Text = _currentProduct.Name;
                CategoryTextBox.Text = _currentProduct.Category;
                //ManufacturerTextBox.Text = _currentProduct.Manufacturer?.Name;
                CountNumericUpDown.Value = _currentProduct.Count;
                priceTextBox.Text = _currentProduct.Price.ToString();
            }
        }
        public string Name => NameTextBox.Text.Trim();
        public string Category => CategoryTextBox.Text.Trim();
        public int Count => int.Parse(CountNumericUpDown.Text.Trim());
        public decimal Price => decimal.Parse(priceTextBox.Text.Trim());

        private void OkButton_Click(object sender, EventArgs e)
        {
            
            using (var db = new ApplicationContext())
            {
                try
                {
                    // Проверка на пустые значения
                    if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                        string.IsNullOrWhiteSpace(CategoryTextBox.Text))
                    //string.IsNullOrWhiteSpace(ManufacturerTextBox.Text))
                    {
                        MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (_currentProduct != null)
                    {
                        _currentProduct.Name = NameTextBox.Text;
                        _currentProduct.Category = CategoryTextBox.Text;
                        _currentProduct.Count = int.Parse(CountNumericUpDown.Text.Trim());
                        _currentProduct.Price = decimal.Parse(priceTextBox.Text.Trim());
                        db.Goods.Update(_currentProduct);
                        db.SaveChanges();
                    }
                    else if (_currentProduct == null)// Если создаём нового пользователя
                    {
                        var newUser = new Goods
                        {
                            Name = NameTextBox.Text,
                            Category = CategoryTextBox.Text,
                            Count = int.Parse(CountNumericUpDown.Text.Trim()),
                            Price = decimal.Parse(priceTextBox.Text.Trim())
                        };
                        //db.Goods.Add(newUser);
                       
                    }
                    db.SaveChanges();
                    //db.SaveChanges();  // Сохраняем изменения в базе данных
                    MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Close();  // Закрываем форму
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadUserData(int userId)
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Goods.Find(userId);
                if (user != null)
                {
                    NameTextBox.Text = user.Name;
                    CategoryTextBox.Text = user.Category;
                    CountNumericUpDown.Text = user.Count.ToString();
                    priceTextBox.Text = user.Price.ToString();
                }
            }
        }
    }
}
