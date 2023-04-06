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
using EntityLayer;
using Logic;

namespace HASTATAKIPV1
{
    public partial class listele : Form
    {
        public listele()
        {
            InitializeComponent();
        }

        private void listele_Load(object sender, EventArgs e)
        {
            List<Entity> perlist = logic.hastalist();
            dataGridView1.DataSource= perlist;
        }
    }
}
