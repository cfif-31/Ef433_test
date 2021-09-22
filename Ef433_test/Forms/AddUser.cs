using Ef433_test.Classes;
using Ef433_test.Classes.Types;
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
    public partial class AddUser : Form
    {
        //Храним пользователя, которого мы редактируем/добавляем
        User user;

        //Принимаем пользователя в конструктор
        public AddUser(User user)
        {
            //Сохраняем пришедшего пользователя в переменную в форме
            this.user = user;
            InitializeComponent();

            //Приваем значения из объекта пользователя в поля
            tbLogin.Text = user.UserLogin;
            tbPass.Text = user.UserPass;
            tbFullName.Text = user.UserFullName;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Присваем значения объекту из полей
            user.UserLogin = tbLogin.Text;
            user.UserFullName = tbFullName.Text;
            user.UserPass = tbPass.Text;

            //Если id нулевой (пользователь добавляется)
            if (user.UserId == 0) {
                //Добавляем его в таблицу пользователей
                EfModel.Init().Users.Add(user);
            }
            //Сохраняем изменения
            EfModel.Init().SaveChanges();
        }
    }
}
