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
    public partial class Stocks : Form
    {
        private DatabaseAccess dbAccess;
        public Stocks()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess();
        }

        public void addStockButtonAction(object sender, EventArgs e) {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Stock stock = new Stock();
                
                stock.Name = stockNameField.Text;
                stock.Date = stockDatePicker.Value;
                stock.Durability = int.Parse(stockDurabilityField.Text);
                stock.Price = double.Parse(stockPriceField.Text);
                stock.Measure = listBox1.GetItemText(listBox1.SelectedItem);


                dbAccess.insertStock(stock);
            }
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            
        }

        private void trajnostValidating(object sender, CancelEventArgs e)
        {
            bool positiveCheck = checkIfPositive(stockDurabilityField.Text);
            if (positiveCheck)
            {

                e.Cancel = false;
                errorProvider1.SetError(stockDurabilityField, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(stockDurabilityField, "Enter a positive number!");
            }

        }

        private void price_Validating(object sender, CancelEventArgs e)
        {
            bool positiveCheck = checkIfPositive(stockPriceField.Text);
            if (positiveCheck)
            {
               
                e.Cancel = false;
                errorProvider1.SetError(stockPriceField, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(stockPriceField, "Enter a positive number!");
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

    }
}
