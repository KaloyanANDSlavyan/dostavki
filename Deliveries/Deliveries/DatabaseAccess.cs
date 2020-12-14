using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;


namespace Deliveries
{
    class DatabaseAccess
    {
        
        private String conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Slavyan\Desktop\dostavkiREPO2\dostavki\Deliveries\Deliveries\Database1.mdf;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;

        public DatabaseAccess() {
            connection = new SqlConnection(conString);
        }

        public void insertStock(Stock stock) {
            String query = "insert into Stocks values(N'" + stock.Name + "','" + stock.Date.ToString() + "','"
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
            String query = "insert into Delivors values(N'" + delivor.CompanyName + "',N'" + delivor.Address + "','"
         + delivor.PhoneNumber + "',N'" + delivor.EmployeeContact + "')";
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
        public object outputDelivor(int id)
        {
            String query = @"SELECT Deliveries.delivorID as код_доставчик, Deliveries.stockID as код_стока, Stocks.stockName as име_стока, 
            Stocks.price * 1.2 AS цена_стока, CONCAT(Deliveries.deliveryAmount, ' ', Stocks.measure)
            AS количество FROM((Deliveries INNER JOIN Delivors ON Deliveries.delivorID = Delivors.delivorID)
            INNER JOIN Stocks ON Deliveries.stockID = Stocks.stockID) WHERE Delivors.delivorID = " + id;

            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public object outputStocks() {
            String query = @"SELECT s.stockID as код, s.stockName as име, 
                             s.date as дата, s.durability as трайност, 
                             s.price as цена, s.measure as мярка
                             FROM Stocks s";

            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public object queryOlio(DateTime date) {
            String query = @"SELECT s.stockName as име, s.price*1.2 as ценаДДС, 
                            d.delivorID as код_доставчик, CONCAT(d.deliveryAmount, ' ', s.measure) as количество, 
                            d.deliveryDate as дата_доставка
                            FROM Deliveries d
                            INNER JOIN Stocks s ON d.stockID = s.stockID
                            WHERE s.stockName = 'olio' AND d.deliveryDate < " + "'" + date.ToString() + "'" +
                           " ORDER BY d.deliveryAmount DESC";

            command = new SqlCommand(query, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
