using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HASTATAKIPV1
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=Hastane;Integrated Security=True");
            string sorgu = "select* from users where ISIM=@user and SIFRE=@pass";
            SqlCommand cmd=new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@user",textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            conn.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm1=new Form1();
                frm1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Giriş Başarısız");
        }
    }
}
