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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            dataGridViewUsers.AutoGenerateColumns = true;
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var context = new ApplicationContext())
            {
                // Получение списка пользователей из базы данных
                var users = context.Users
                    .Select(u => new
                    {
                        u.Id,
                        u.FirstName,
                        u.SecondName,
                        u.Login,
                        u.Age
                    })
                    .ToList();

                dataGridViewUsers.DataSource = users; // Установка источника данных
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AddEditUserForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var context = new ApplicationContext())
                    {
                        // Добавляем нового пользователя
                        context.Users.Add(new Models.User
                        {
                            Login = form.Login,
                            Password = form.Password,
                            FirstName = form.FirstName,
                            SecondName = form.SecondName,
                            Age = form.Age
                        });
                        context.SaveChanges();
                    }

                    LoadUsers(); // Обновляем данные
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)dataGridViewUsers.SelectedRows[0].Cells["ID"].Value;

                using (var form = new AddEditUserForm(selectedUserId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var context = new ApplicationContext())
                        {
                            var user = context.Users.Find(selectedUserId);
                            if (user != null)
                            {
                                user.FirstName = form.FirstName;
                                user.SecondName = form.SecondName;
                                user.Login = form.Login;
                                user.Password = form.Password;
                                user.Age = form.Age;
                                context.Update(user);
                                context.SaveChanges();
                            }
                        }

                        LoadUsers(); // Обновляем данные
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedUserId = (int)dataGridViewUsers.SelectedRows[0].Cells["ID"].Value;

                var result = MessageBox.Show("Вы действительно хотите удалить этого пользователя?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new ApplicationContext())
                    {
                        var user = context.Users.Find(selectedUserId);
                        if (user != null)
                        {
                            context.Users.Remove(user);
                            context.SaveChanges();
                        }
                    }

                    LoadUsers(); // Обновляем данные
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
