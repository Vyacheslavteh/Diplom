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
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Kursach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=kurssdb;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            if (logname.Text == String.Empty || logpass.Text == String.Empty)
            {
                MessageBox.Show("Поля ввода не должны быть пустыми!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }
            else
            con.Open();
            string log = "SELECT * FROM users WHERE name= '" + logname.Text + "' and password= '" + logpass.Text + "'";
            cmd = new SqlCommand(log, con);
            SqlDataAdapter dr = cmd.ExecuteReader();

            if(dr.Read()==true)
            {
                new Mainform().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверный логин или пароль", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

        }

     
    }
}
