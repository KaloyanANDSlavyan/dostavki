using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (ValidateChildren(ValidationConstraints.Enabled))
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

        public static bool checkIfPositive(string data)
        {
            string strRegex = @"^[+]?\d+([.]\d+)?$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(data))
                return (true);
            else
                return (false);
        }

        private void amount_Validating(object sender, CancelEventArgs e)
        {
            bool positiveCheck = checkIfPositive(deliveryAmountField.Text);
            if (positiveCheck)
            {

                e.Cancel = false;
                errorProvider1.SetError(deliveryAmountField, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(deliveryAmountField, "Enter a positive number!");
            }
        }
    }
}
