using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace HASTATAKIPV1
{
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=Hastane;Integrated Security=True");
        string imagepath;
        string resim1;
        private void kayitol_Load(object sender, EventArgs e)
        {
           OpenFileDialog ofg=new OpenFileDialog();
            ofg.Title = "resim seç";
            ofg.Filter = "Jpeg Dosyalari(*.jpg)|*.jpg|Gif dosyalari(*.gif)|*.gif";
            ofg.FilterIndex = 1;
            ofg.RestoreDirectory = true;
            if(ofg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofg.FileName); 
                imagepath = ofg.FileName;
                resim1 = ofg.FileName;
            }
        }

        public  void button2_Click(object sender, EventArgs e)
        {
            
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into users(ISIM,SOYISIM,UZMANLIK,TELEFON,RESIM,SIFRE) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", textBox4.Text);
            cmd.Parameters.AddWithValue("@p5", resim1);
            cmd.Parameters.Add("@p6",textBox5.Text);
            cmd.ExecuteNonQuery();
            conn.Close();



        }
    }
}
