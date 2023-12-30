using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuppGostinica
{
    public partial class CookForms : Form
    {
        public CookForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Menu form = new Menu();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Sklad form = new Sklad();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kitchen form = new Kitchen();
            form.Show();
        }
    }
}
