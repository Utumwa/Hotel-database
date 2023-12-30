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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Rooms form = new Rooms();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hotels form = new Hotels();
            form.Show();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            CookForms form = new CookForms();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Payment form = new Payment();
           form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.Show();
        }
    }
}
