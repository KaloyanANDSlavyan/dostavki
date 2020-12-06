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
    public partial class Stocks : Form
    {
        private DatabaseAccess dbAccess;
        public Stocks()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess();
        }

        public void addStockButtonAction(object sender, EventArgs e) {
            Stock stock = new Stock();
            stock.Name = stockNameField.Text;
            stock.Date = stockDatePicker.Value;
            stock.Durability = int.Parse(stockDurabilityField.Text);
            stock.Price = double.Parse(stockPriceField.Text);
            stock.Measure = stockMeasureField.Text;

            
            dbAccess.insertStock(stock);
        }
    }
}
