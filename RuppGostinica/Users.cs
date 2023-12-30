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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ruppGostinicaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.ruppGostinicaDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id_user = Convert.ToInt32(usersDataGridView[0, usersDataGridView.CurrentRow.Index].Value.ToString());
  
                usersBindingSource.RemoveCurrent();
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void usersBindin(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Check(loginTextBox.Text))
               return;
            this.usersTableAdapter.Insert(loginTextBox.Text, textBox1.Text, firstNameTextBox.Text, middleNameTextBox.Text, Convert.ToInt32(iDRoleTextBox.Text));
            this.usersTableAdapter.Fill(this.ruppGostinicaDataSet.Users);
        }
        bool Check(string login)
        {
            for (int i = 0; i < this.ruppGostinicaDataSet.Users.Rows.Count; i++)
            {
                if (this.usersTableAdapter.GetData().Rows[i].ItemArray[1].Equals(login))
                {
                    MessageBox.Show("Логин пользователя занят!");
                    return true;
                }
                   
            }
            return false;
        }
    }
}

