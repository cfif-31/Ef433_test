using Ef433_test.Classes;
using Ef433_test.Classes.Types;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef433_test.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            /*MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.201.12";
            builder.Port = 3306;
            builder.UserID = "testuser";
            builder.Password = "test234";
            builder.CharacterSet = "utf8";
            builder.Database = "testuser_Gibdd433_Ef2";
            Console.WriteLine(builder.ConnectionString);*/

            //Иниализировали модель
            UpdateData();
        }

        private void UpdateData()
        {
            //Очищаем DataGrid
            dgvUsers.Rows.Clear();
            //Перебрали пользователей - с условием, ГДЕ (where) имя пользователя или логин содержит поисковой запрос
            foreach (User user in EfModel.Init().Users
                .Where(u=>u.UserFullName.Contains(tbSearch.Text) || u.UserLogin.Contains(tbSearch.Text)))
                
            {
                //Добавили пользователя в DGV, получаем НОМЕР добавляемой строки
                int r = dgvUsers.Rows.Add(user.UserLogin, user.UserFullName);
                //Записываем информацию о пользователе в ТЕГ
                dgvUsers.Rows[r].Tag = user;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Показываем форму пользователя
            new UserAddForm(new User()).ShowDialog();
            //Обновляем данные
            UpdateData();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            //Проверяем, что выбрана минимум одна строка
            if (dgvUsers.SelectedRows.Count > 0)
            {
                //Получаем запись о пользователе из строки
                User user = dgvUsers.SelectedRows[0].Tag as User;
                //Создаем форму (полученный пользователь) и показываем ее как диалог
                new UserAddForm(user).ShowDialog();
                UpdateData();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            //Проверили, что выбрана минимум одна строка (больше их быть и не может)
            if (dgvUsers.SelectedRows.Count > 0) {
                //Получили из тега пользователя
                User user = dgvUsers.SelectedRows[0].Tag as User;
                //Спрашивем, хочет ли пользователь удалить запись
                if (MessageBox.Show("Вы хотите удалить пользователя " + user.UserFullName + "?",
                        "Удаление пользователя", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Обращаемся к модели и удаляем из коллекции пользователей запись
                    EfModel.Init().Users.Remove(user);
                    //Сохраняем изменения (синхронизируем изменения с БД)
                    EfModel.Init().SaveChanges();
                    //Обновляем данные в DGV
                    UpdateData();
                }
            }
        }

        //При изменении поискового запроса
        private void tbSearchChangeEvent(object sender, EventArgs e)
        {
            //Перезагружаем данные
            UpdateData();
        }
    }
}
