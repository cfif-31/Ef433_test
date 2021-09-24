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
    public partial class UserAddForm : Form
    {
        private User EditedUser;
        public UserAddForm(User user)
        {
            EditedUser = user;
            InitializeComponent();

            //Заполние компоненты значениями из записи о пользователе
            tbFio.Text = user.UserFullName;
            tbLogin.Text = user.UserLogin;
            tbPass.Text = user.UserPass;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Устанавливаем измененные значения в поля пользователя
            EditedUser.UserLogin = tbLogin.Text;
            EditedUser.UserPass = tbPass.Text;
            EditedUser.UserFullName = tbFio.Text;

            //Если пользователь новый (id пустой)
            if (EditedUser.UserId == 0)
                //Добавляем его в базу
                EfModel.Init().Users.Add(EditedUser);

           //Сохраняем изменения
            EfModel.Init().SaveChanges();
        }
    }
}
