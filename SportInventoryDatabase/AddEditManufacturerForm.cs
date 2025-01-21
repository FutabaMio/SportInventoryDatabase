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
    public partial class AddEditManufacturerForm : Form
    {
        private Manufacturer CurrentUser { get; set; }
        private int? _userId;
        public AddEditManufacturerForm(int? userId = null)
        {
            InitializeComponent();

            _userId = userId;

            if (userId.HasValue)
            {
               LoadUserData(userId.Value);
            }
        }

        public string Name => nameTextBox.Text.Trim();
        public string Country => countryTextBox.Text.Trim();

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(countryTextBox.Text))  
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new ApplicationContext())
            {
                // Если редактируем существующего пользователя
                if (CurrentUser != null)
                {
                    CurrentUser.Name = nameTextBox.Text;
                    CurrentUser.Country = countryTextBox.Text;
                   

                    db.Manufacturers.Update(CurrentUser);
                    //db.SaveChanges();
                }
                else // Если создаём нового пользователя
                {
                    var newUser = new Manufacturer
                    {
                        Name = nameTextBox.Text,
                        Country = countryTextBox.Text,
                    };

                    //db.Manufacturers.Add(newUser);
                    
                }

                db.SaveChanges(); // Сохраняем изменения в базу данных
            }

            MessageBox.Show("Пользователь успешно сохранён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // Устанавливаем результат диалога для закрытия формы
            this.Close(); // Закрываем форму

        }

        private void LoadUserData(int userId)
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Manufacturers.Find(userId);
                if (user != null)
                {
                    nameTextBox.Text = user.Name;
                    countryTextBox.Text = user.Country;
                    
                }
            }
        } 
    }
}
