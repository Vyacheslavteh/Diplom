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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kursdb.mdb");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursdbDataSet1.Механики". При необходимости она может быть перемещена или удалена.
            this.mechanicsTableAdapter1.Fill(this.kursdbDataSet1.mechanics);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursdbDataSet1.Клиенты". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter1.Fill(this.kursdbDataSet1.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursdbDataSet1.Заказы". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter1.Fill(this.kursdbDataSet1.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursdbDataSet1.Услуги". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter1.Fill(this.kursdbDataSet1.services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursdbDataSet1.Автомобили". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter1.Fill(this.kursdbDataSet1.cars);
        }

        private void addavt_Click(object sender, EventArgs e)
        {
            addf ada = new addf();
            ada.Owner = this;
            ada.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            if (dataGridView1.SelectedRows.Count > 0)
            {
                kursdbDataSet1.Tables[1].Rows[dataGridView1.SelectedRows[0].Index].Delete();
                carsTableAdapter1.Update(kursdbDataSet1.cars);
                kursdbDataSet1.AcceptChanges();
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addf ada = new addf();
            ada.Owner = this;
            ada.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kursdbDataSet1.Tables[2].Rows[dataGridView2.SelectedRows[0].Index].Delete();
            mechanicsTableAdapter1.Update(kursdbDataSet1.mechanics);
            kursdbDataSet1.AcceptChanges();
            dataGridView2.Update();
            dataGridView2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addf ada = new addf();
            ada.Owner = this;
            ada.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kursdbDataSet1.Tables[3].Rows[dataGridView3.SelectedRows[0].Index].Delete();
            clientsTableAdapter1.Update(kursdbDataSet1.clients);
            kursdbDataSet1.AcceptChanges();
            dataGridView3.Update();
            dataGridView3.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addf ada = new addf();
            ada.Owner = this;
            ada.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kursdbDataSet1.Tables[4].Rows[dataGridView4.SelectedRows[0].Index].Delete();
            mechanicsTableAdapter1.Update(kursdbDataSet1.mechanics);
            kursdbDataSet1.AcceptChanges();
            dataGridView4.Update();
            dataGridView4.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addf ada = new addf();
            ada.Owner = this;
            ada.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kursdbDataSet1.Tables[5].Rows[dataGridView5.SelectedRows[0].Index].Delete();
            servicesTableAdapter1.Update(kursdbDataSet1.services);
            kursdbDataSet1.AcceptChanges();
            dataGridView5.Update();
            dataGridView5.Refresh();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
