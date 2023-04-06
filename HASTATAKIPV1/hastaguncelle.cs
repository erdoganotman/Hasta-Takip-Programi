using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using EntityLayer;
using System.Data.SqlClient;
using Logic;

namespace HASTATAKIPV1
{
    public partial class hastaguncelle : Form
    {
        public hastaguncelle()
        {
            InitializeComponent();
        }

        private void hastaguncelle_Load(object sender, EventArgs e)
        {
            List<Entity> perlist = logic.hastalist();
            dataGridView1.DataSource = perlist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity ent=new Entity();
            ent.TC1 = textBox1.Text;
            ent.RANDEVUTARIHI1 = dateTimePicker1.Value;
            CRUD.randevuguncelle(ent);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
