using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursach
{
    public partial class addf : Form
    {
        public addf()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=kurssdb;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void addavt_Click(object sender, EventArgs e)
        {
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[1].NewRow();
            int rc = main.dataGridView1.RowCount + 1;
            con.Open();
            string adda = "INSERT INTO cars VALUES('" + rc + "','" + avt2.Text + "','" + avt3.Text + "','" + avt4.Text + "')";
            cmd = new SqlCommand(adda, con);
             cmd.ExecuteNonQuery();
            con.Close();
                nRow[0] = rc;
                nRow[1] = avt2.Text;
                nRow[2] = avt3.Text;
                nRow[3] = avt4.Text;
                main.kursdbDataSet1.Tables[1].Rows.Add(nRow);
                main.carsTableAdapter1.Update(main.kursdbDataSet1.cars);
                main.kursdbDataSet1.Tables[1].AcceptChanges();
                main.dataGridView1.Update();
                main.dataGridView1.Refresh();
        }

        private void addzak_Click(object sender, EventArgs e)
        {
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[2].NewRow();
            int rcz = main.dataGridView2.RowCount + 1;
            con.Open();
            string adda = "INSERT INTO orders VALUES('" + rcz + "','" + dateTimePicker1.DropDownAlign + "','" + dateTimePicker2.DropDownAlign + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd = new SqlCommand(adda, con);
            cmd.ExecuteNonQuery();
            con.Close();
            nRow[0] = rcz;
            nRow[1] = dateTimePicker1.Text;
            nRow[2] = dateTimePicker2.Text;
            nRow[3] = textBox1.Text;
            nRow[4] = textBox4.Text;
            nRow[5] = textBox5.Text;
            main.kursdbDataSet1.Tables[2].Rows.Add(nRow);
            main.ordersTableAdapter1.Update(main.kursdbDataSet1.orders);
            main.kursdbDataSet1.Tables[2].AcceptChanges();
            main.dataGridView2.Update();
            main.dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainform main = this.Owner as Mainform;
            DataRow nRow = main.kursdbDataSet1.Tables[3].NewRow();
            int rcz = main.dataGridView3.RowCount + 1;
            con.Open();
            string adda = "INSERT INTO clients VALUES('" + rcz + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd = new SqlCommand(adda, con);
            cmd.ExecuteNonQuery();
            con.Close();
            nRow[0] = rcz;
            nRow[1] = textBox2.Text;
            nRow[2] = textBox3.Text;
            nRow[3] = textBox6.Text;
            nRow[4] = textBox7.Text;
            main.kursdbDataSet1.Tables[3].Rows.Add(nRow);
            main.clientsTableAdapter1.Update(main.kursdbDataSet1.clients);
            main.kursdbDataSet1.Tables[3].AcceptChanges();
            main.dataGridView3.Update();
            main.dataGridView3.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
