using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        private DataTable table;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        } 
        private void Form1_Load_1(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Massages", typeof(String));
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Massages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 200;
        }
   
        private void buttnew_Click(object sender, EventArgs e)
        {
            texttitle.Clear();
            textmassage.Clear();
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(texttitle.Text, textmassage.Text);
            texttitle.Clear();
            textmassage.Clear();
        }

        private void butread_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                texttitle.Text = table.Rows[index].ItemArray[0].ToString();
                textmassage.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

      
        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
