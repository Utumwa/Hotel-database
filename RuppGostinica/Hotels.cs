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
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void hotelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ruppGostinicaDataSet.Hotels". При необходимости она может быть перемещена или удалена.
            this.hotelsTableAdapter.Fill(this.ruppGostinicaDataSet.Hotels);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.hotelsTableAdapter.Insert(Convert.ToInt32(hotelIDTextBox.Text), nameTextBox.Text, adressTextBox.Text, phoneNumberTextBox.Text);
            this.hotelsTableAdapter.Fill(this.ruppGostinicaDataSet.Hotels);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id_user = Convert.ToInt32(hotelsDataGridView[0, hotelsDataGridView.CurrentRow.Index].Value.ToString());

                hotelsBindingSource.RemoveCurrent();
                this.Validate();
                this.hotelsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);
            }
        }
    }
}
