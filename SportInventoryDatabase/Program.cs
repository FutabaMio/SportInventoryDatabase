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
            // Создание базы данных
            using (var context = new ApplicationContext())
            {
                try
                {
                    context.Database.EnsureCreated(); // Создаём базу данных, если она не существует.

                    // Проверяем, есть ли записи в таблице Users
                    if (!context.Users.Any())
                    {
                        // Добавляем тестового пользователя
                        context.Users.Add(new User
                        {
                            FirstName = "Иван",
                            SecondName = "Иванов",
                            Login = "admin",
                            Password = "12345",
                            Age = 30
                        });
                        context.SaveChanges(); // Сохраняем изменения в базе данных.
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Запуск приложения
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }


    }
}