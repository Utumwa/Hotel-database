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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ruppGostinicaDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.ruppGostinicaDataSet.Rooms);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomsTableAdapter.Insert(Convert.ToInt32(hotelIDTextBox.Text), Convert.ToInt32(roomTypeTextBox.Text), Convert.ToInt32(bedTypeTextBox.Text), Convert.ToInt32(roomStatusTextBox.Text), Convert.ToDecimal(priceTextBox.Text));
                this.roomsTableAdapter.Fill(this.ruppGostinicaDataSet.Rooms);
            }
            catch
            {
                MessageBox.Show("Заполните поля!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id_rooms = Convert.ToInt32(roomsDataGridView[0, roomsDataGridView.CurrentRow.Index].Value.ToString());

                    roomsBindingSource.RemoveCurrent();
                    this.Validate();
                    this.roomsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);
        }
    }
}
