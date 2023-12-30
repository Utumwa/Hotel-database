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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);

        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ruppGostinicaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.ruppGostinicaDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Check(textBox1.Text, textBox2.Text);
            string role = id != -1 ? this.ruppGostinicaDataSet.Users.Rows[id].ItemArray[1].ToString() : "-1";
            switch (role)
            {
                case "1": //админ
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    break;
                case "2": //Клиент
                    ClientForm client = new ClientForm();
                    client.login = this.ruppGostinicaDataSet.Users.Rows[id].ItemArray[0].ToString();
                    client.Show();
                    break;
                case "3": //Кассир
                    Payment cash = new Payment();
                    cash.login = this.ruppGostinicaDataSet.Users.Rows[id].ItemArray[0].ToString();
                    cash.Show();
                    break;
                case "4": //Повар
                     CookForms cook = new CookForms();
                    cook.Show();
                    break;
                default:
                    break;
            }
        }
        int Check(string login, string password)
        {
            for (int i = 0; i < this.ruppGostinicaDataSet.Users.Rows.Count; i++)
            {
                if (this.ruppGostinicaDataSet.Users.Rows[i].ItemArray[1].Equals(login) && this.ruppGostinicaDataSet.Users.Rows[i].ItemArray[2].Equals(password))
                    return i;//всё ок
            }
            MessageBox.Show("Неверный логин или пароль!");
            return -1;
        }

    }
}
