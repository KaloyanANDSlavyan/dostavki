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
    public partial class StockReport : Form
    {
        private DatabaseAccess dbAccess;
        public StockReport()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess();
        }

        public void viewStockButtonAction(object sender, EventArgs e) {
            stockGridView.DataSource = dbAccess.outputStocks();
        }
    }
}
