using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using System.Data.SqlClient;
using DAL;

namespace HASTATAKIPV1
{
    public partial class hastakayit : Form
    {
        public hastakayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity ent = new Entity();
            ent.ISIM1 = textBox1.Text;
            ent.SOYISIM1= textBox2.Text;
            ent.TC1 = textBox3.Text;
            ent.DOGUMTARIHI1 = dateTimePicker1.Value.ToString();
            ent.TELEFON1= textBox4.Text;
            ent.ADRES1 = richTextBox1.Text;
            ent.KANGRUBU1 = comboBox1.Text;
            ent.TESHIS1 = richTextBox2.Text;
            ent.TEDAVIPLANI1 = richTextBox3.Text;
            ent.AMELIYAT1 = textBox5.Text;
            ent.KRONIKHASTALIK1 = textBox6.Text;
            ent.RANDEVUTARIHI1 =DateTime.Parse( dateTimePicker2.Value.ToString());
            ent.UCRET1 = int.Parse(textBox7.Text);
            ent.BORC1 = int.Parse(textBox8.Text);
            CRUD.hastaekle(ent);
            MessageBox.Show("Kayıt Başırıyla Oluşturuldu.");
        }
    }
}
