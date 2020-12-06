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
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }

        public void stocksButtonAction(object sender, EventArgs e) {
            Stocks stocks = new Stocks();
            stocks.Show();
        }
    }
}
