﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente_soap_prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int orden = Int32.Parse(textBox1.Text);

            ServiceReference1.WebService1SoapClient qry = new ServiceReference1.WebService1SoapClient(orden);

            System.Data.DataSet ds = new DataSet();

            ds = qry.ListOrders();

            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
