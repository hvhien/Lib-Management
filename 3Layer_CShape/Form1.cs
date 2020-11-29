using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Layer_CShape
{
    public partial class Form1 : Form
    {
        BLL bll = new BLL();
        public Form1()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            dateTimePicker1.Text ="";
            nameBOOKtxt.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = bll.getAllData();
            x.DataSource = dt;
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
