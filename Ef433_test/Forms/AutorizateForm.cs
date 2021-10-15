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
    public partial class AutorizateForm : Form
    {
        public AutorizateForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            User user = EfModel.Init().Users
                .Where(u => u.UserLogin == tbLogin.Text && u.UserPass == tbPass.Text).FirstOrDefault();

            if (user != null)
            {
                if (user.UserType == User.userType.admin)
                {

                    Hide();
                    new UsersForm().ShowDialog();
                    Show();

                }
                else {
                    MessageBox.Show("User!" + user.UserFullName);
                }
            }
            else {
                MessageBox.Show("Uncorrect login or password!");
            }
        }
    }
}
