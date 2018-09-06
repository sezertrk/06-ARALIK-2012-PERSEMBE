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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection
            ("Data Source=PC\\PC14;Initial Catalog=og;Integrated Security=True");
            bag.Open();
            SqlDataAdapter kur = new SqlDataAdapter("select id,AdıSoyadı from bilgi", bag);
            DataTable hamal = new DataTable();
            kur.Fill(hamal);
            dataGridView1.DataSource = hamal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

            Form1 frm1 = new Form1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = 0;
            for (row = 0; row < dataGridView1.Rows.Count; row++)
            if (dataGridView1.Rows[row].Cells[0].Selected == true || dataGridView1.Rows[row].Cells[1].Selected==true)
            {
                break;
            }
            textBox1.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
        }
    }
}
