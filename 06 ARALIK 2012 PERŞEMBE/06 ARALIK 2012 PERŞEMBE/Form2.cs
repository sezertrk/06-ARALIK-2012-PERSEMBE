using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace _06_ARALIK_2012_PERŞEMBE
{
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection
            ("Data Source=PC\\PC14;Initial Catalog=og;Integrated Security=True");
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText = "insert into kayit(AdıSoyadı,Bulunma,Gecikme,Dersler)values('" + frm1.textBox1.Text + "', )";
           
           
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
    }
}
