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
    public partial class ShowDeliveredStocks : Form
    {
        private DatabaseAccess dbAccess;

        public ShowDeliveredStocks()
        {
            InitializeComponent();
            dbAccess = new DatabaseAccess();
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(delivorIDField.Text);
            dataGridView1.DataSource = dbAccess.outputDelivor(id);
        }
    }
}
