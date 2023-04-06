using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using EntityLayer;
using System.Data.SqlClient;


namespace HASTATAKIPV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=Hastane;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand doktorbilgileri = new SqlCommand("select ISIM,SOYISIM,UZMANLIK,TELEFON,RESIM from users", conn);
            conn.Open();
            SqlDataReader dr = doktorbilgileri.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr["ISIM"].ToString();
                label6.Text = dr["SOYISIM"].ToString();
                label7.Text = dr["UZMANLIK"].ToString();
                label8.Text = dr["TELEFON"].ToString();
                string resim = dr["RESIM"].ToString();
                pictureBox1.ImageLocation = resim;
                
            }
            conn.Close();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           user users=new user();
            users.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele frm2=new listele();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastakayit fr=new hastakayit();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hastaguncelle fr2=new hastaguncelle();
            fr2.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
