using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.Common;

namespace SportInventoryDatabase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private bool isPasswordVisible = false;
        private void AcceptBTN_Click(object sender, EventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password = PasswordTB.Text.Trim();

            using (var context = new ApplicationContext())
            {
                // Проверка логина и пароля
                var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show($"Добро пожаловать, {user.FirstName} {user.SecondName}!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Переход в главное меню
                    this.Hide(); // Скрываем текущую форму
                    var mainMenuForm = new MainMenuForm(); // Создаём экземпляр главного меню
                    mainMenuForm.ShowDialog(); // Открываем главное меню
                    this.Close(); // Закрываем форму авторизации
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EraseBTN_Click(object sender, EventArgs e)
        {
            LoginTB.Text = string.Empty;
            PasswordTB.Text = string.Empty;
        }

        private void ShowPasswordBTN_Click_1(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            PasswordTB.UseSystemPasswordChar = !isPasswordVisible;
            ShowPasswordBTN.Text = isPasswordVisible ? "Скрыть" : "Показать";
        }

    }
}
