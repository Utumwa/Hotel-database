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
    public partial class Sklad : Form
    {
        public Sklad()
        {
            InitializeComponent();
        }

        private void skladBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.skladBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ruppGostinicaDataSet.Sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.ruppGostinicaDataSet.Sklad);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.skladTableAdapter.Insert(quantityTextBox.Text, productTextBox.Text);
            this.skladTableAdapter.Fill(this.ruppGostinicaDataSet.Sklad);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id_sklad = Convert.ToInt32(SkladdataGridView[0, SkladdataGridView.CurrentRow.Index].Value.ToString());

                    skladBindingSource.RemoveCurrent();
                    this.Validate();
                    this.skladBindingSource.EndEdit();
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
            this.skladBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);
        }
    }
}
