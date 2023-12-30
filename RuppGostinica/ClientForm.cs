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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewingHotels form = new ViewingHotels();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoocRooms form = new LoocRooms();
            form.Show();
        }
        
        private void ClientForm_Load(object sender, EventArgs e)
        {
             
        }
        public string login;
    }
}
