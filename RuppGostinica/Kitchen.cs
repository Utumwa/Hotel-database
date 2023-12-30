﻿using System;
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
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        private void kitchenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kitchenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ruppGostinicaDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ruppGostinicaDataSet.Kitchen". При необходимости она может быть перемещена или удалена.
            this.kitchenTableAdapter.Fill(this.ruppGostinicaDataSet.Kitchen);

        }
    }
}
