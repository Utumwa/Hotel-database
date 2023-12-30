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
    public partial class ViewingHotels : Form
    {
        public ViewingHotels()
        {
            InitializeComponent();
        }

        private void hotelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);

        }

        private void ViewingHotels_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ruppGostinicaDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.ruppGostinicaDataSet.Hotels);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
