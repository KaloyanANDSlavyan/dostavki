using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Deliveries
{
    class DatabaseAccess
    {
        private String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slavyan\Desktop\dostavkiREPO\dostavki\Deliveries\Deliveries\Database1.mdf;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;

        public DatabaseAccess() {
            connection = new SqlConnection(conString);
        }

        public void insertStock(Stock stock) {
            String query = "insert into Stocks values('" + stock.Name + "','" + stock.Date.ToString() + "','"
                + stock.Durability.ToString() + "','" + stock.Price.ToString() + "','" + stock.Measure + "')";
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Успешно добавена стока!");
            }
            catch (Exception ex) {
                MessageBox.Show("Нещо са прееба брат");
            }
        }

        public void insertDelivor(Delivor delivor)
        {
            String query = "insert into Delivors values('" + delivor.CompanyName + "','" + delivor.Address + "','"
         + delivor.PhoneNumber + "','" + delivor.EmployeeContact + "')";
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Успешно добавен доставчик!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нещо са прееба брат");
            }
        }

        public void insertDelivery(Delivery delivery)
        {
            String query = "insert into Deliveries values('" + delivery.StockID.ToString() + "','" + delivery.DelivorID.ToString() + "','"
               + delivery.DocumentNumber.ToString() + "','" + delivery.DeliveryDate.ToString() + "','" + delivery.DeliveryAmount.ToString() + "')";
            command = new SqlCommand(query, connection);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Успешно добавена доставка!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нещо са прееба брат");
            }
        }
    }
}
