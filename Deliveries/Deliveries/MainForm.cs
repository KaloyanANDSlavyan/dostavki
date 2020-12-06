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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void exitMenuButtonAction(object sender, EventArgs e) {
            Application.Exit();
        }

        public void insertMenuButtonAction(object sender, EventArgs e) {
            Forms forms = new Forms();
            forms.Show();
        }
    }
}
