using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class Deliveries : Form
    {
        private DatabaseAccess dbAccess;

        public Deliveries()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess();
        }

        private void deliveryAddButton_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();

            delivery.StockID = int.Parse(stockIDField.Text);
            delivery.DelivorID = int.Parse(delivorIDField.Text);
            delivery.DocumentNumber = int.Parse(documentField.Text);
            delivery.DeliveryDate = dateTimePicker1.Value;
            delivery.DeliveryAmount = double.Parse(deliveryAmountField.Text);

            dbAccess.insertDelivery(delivery);

        }
    }
}
