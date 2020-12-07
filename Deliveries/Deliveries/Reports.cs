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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        public void stocksButtonAction(object sender, EventArgs e) {
            StockReport stockReport = new StockReport();
            stockReport.Show();
        }

        public void olioButtonAction(object sender, EventArgs e) {
            OlioReport olioReport = new OlioReport();
            olioReport.Show();
        }
    }
}
