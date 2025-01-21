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
                // �������� ������ � ������
                var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show($"����� ����������, {user.FirstName} {user.SecondName}!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ������� � ������� ����
                    this.Hide(); // �������� ������� �����
                    var mainMenuForm = new MainMenuForm(); // ������ ��������� �������� ����
                    mainMenuForm.ShowDialog(); // ��������� ������� ����
                    this.Close(); // ��������� ����� �����������
                }
                else
                {
                    MessageBox.Show("�������� ����� ��� ������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ShowPasswordBTN.Text = isPasswordVisible ? "������" : "��������";
        }

    }
}
