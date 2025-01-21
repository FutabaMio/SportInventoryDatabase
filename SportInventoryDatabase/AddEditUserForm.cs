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
    public partial class AddEditUserForm : Form
    {
        private User CurrentUser { get; set; }
        private int? _userId;
        public AddEditUserForm(int? userId = null)
        {
            InitializeComponent();
            _userId = userId;

            if (userId.HasValue)
            {
                LoadUserData(userId.Value);
            }
        }
        public string FirstName => txtFirstName.Text.Trim();
        public string SecondName => txtSecondName.Text.Trim();
        public string Login => txtLogin.Text.Trim();
        public string Password => txtPassword.Text.Trim();
        public int Age => int.Parse(txtAge.Text.Trim());

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка на заполненность всех необходимых полей
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtSecondName.Text) ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new ApplicationContext())
            {
                // Если редактируем существующего пользователя
                if (CurrentUser != null)
                {
                    CurrentUser.FirstName = txtFirstName.Text;
                    CurrentUser.SecondName = txtSecondName.Text;
                    CurrentUser.Login = txtLogin.Text;
                    CurrentUser.Password = txtPassword.Text;
                    CurrentUser.Age = int.TryParse(txtAge.Text, out int age) ? age : 0;
                    db.Users.Update(CurrentUser);
                }
                else if(CurrentUser == null)// Если создаём нового пользователя
                {
                    var newUser = new User
                    {
                        FirstName = txtFirstName.Text,
                        SecondName = txtSecondName.Text,
                        Login = txtLogin.Text,
                        Password = txtPassword.Text,
                        Age = int.TryParse(txtAge.Text, out int age) ? age : 0
                    };
                    
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
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    txtFirstName.Text = user.FirstName;
                    txtSecondName.Text = user.SecondName;
                    txtLogin.Text = user.Login;
                    txtPassword.Text = user.Password;
                    txtAge.Text = user.Age.ToString();
                }
            }
        }
    }
}
