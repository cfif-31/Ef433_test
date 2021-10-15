using Ef433_test.Classes;
using Ef433_test.Classes.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ef433_test.Forms
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            UpdateData();
            
        }

        private void UpdateData() {
            //Перебираем все продажи
            //*Добавляем using System.Data.Entity*
            //Используем метод Include, для загрузки содержимого связанных таблиц
            foreach (Order order in EfModel.Init().Orders.Include(o=>o.user).Include(o=>o.Products)) {
                //Добавляем строки в DGV
                dgvOrders.Rows.Add(
                    //Выводим дату продажи в нужном формате
                    order.OrderDate.ToString("dd-MM-yyyy hhh:ss"),
                    //Выводим имя пользователя (покупателя)
                    order.user.UserFullName,
                    //Получаем из списока товаров (select) названия в виде массива
                    //Соединям масив посредством запятых
                    String.Join(",", order.Products.Select(p=>p.Name)),
                    //Считаем сумму товаров - берем от каждого товара цену и суммируем
                    order.Products.Sum(p=>p.Price)
                );
            }
        }
    }
}
