using SportInventoryDatabase.Models;

namespace SportInventoryDatabase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // �������� ���� ������
            using (var context = new ApplicationContext())
            {
                try
                {
                    context.Database.EnsureCreated(); // ������ ���� ������, ���� ��� �� ����������.

                    // ���������, ���� �� ������ � ������� Users
                    if (!context.Users.Any())
                    {
                        // ��������� ��������� ������������
                        context.Users.Add(new User
                        {
                            FirstName = "����",
                            SecondName = "������",
                            Login = "admin",
                            Password = "12345",
                            Age = 30
                        });
                        context.SaveChanges(); // ��������� ��������� � ���� ������.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� �������� ���� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // ������ ����������
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }


    }
}