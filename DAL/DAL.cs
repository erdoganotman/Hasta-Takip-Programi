using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class DAL
    {
        public static SqlConnection con = new SqlConnection("Data Source=LAPTOP-UID9DVVD;Initial Catalog=Hastane;Integrated Security=True");
    }
}
