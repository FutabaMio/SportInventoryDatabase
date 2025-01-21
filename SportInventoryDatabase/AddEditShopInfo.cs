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
    public partial class AddEditShopInfo : Form
    {
        private Shop CurrentUser { get; set; }
        private int? _userId;
        public AddEditShopInfo(int? userId = null)
        {
            InitializeComponent();
            _userId = userId;

            if (userId.HasValue)
            {
                LoadUserData(userId.Value);
            }
        }

        public string Dealer => TB_dealer.Text.Trim();

        private void BTN_accept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_dealer.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new ApplicationContext())
            {
                // Если редактируем существующего пользователя
                if (CurrentUser != null)
                {
                    CurrentUser.Dealer = TB_dealer.Text;
                    db.Shops.Update(CurrentUser);
                    db.SaveChanges();
                }
                else // Если создаём нового пользователя
                {
                    var newUser = new Shop
                    {
                        Dealer = TB_dealer.Text
                    };

                    db.Shops.Add(newUser);
                    db.SaveChanges();
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
                var user = context.Shops.Find(userId);
                if (user != null)
                {
                    TB_dealer.Text = user.Dealer;

                }
            }
        }
    }
}
