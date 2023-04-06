using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
namespace DAL
{
    public class CRUD
    {
      public static List<Entity> hastanelistesi()
        {
            List<Entity> deger = new List<Entity>();
            SqlCommand cmd = new SqlCommand("select * from hastabilgileri", DAL.con);
            if (cmd.Connection.State != System.Data.ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                Entity ent= new Entity();
                ent.ID1 = int.Parse(dr["ID"].ToString());
                ent.ISIM1 = dr["ISIM"].ToString();
                ent.DOGUMTARIHI1=dr["DOGUMTARIHI"].ToString();
                ent.KANGRUBU1 = dr["KANGRUBU"].ToString();
                ent.KRONIKHASTALIK1 = dr["KRONIKHASTALIK"].ToString();
                ent.AMELIYAT1 = dr["AMELIYAT"].ToString();
                ent.TESHIS1 = dr["TESHIS"].ToString();
                ent.TEDAVIPLANI1 = dr["TEDAVIPLANI"].ToString();
                ent.TELEFON1 = dr["TELEFON"].ToString();
                ent.ADRES1 = dr["ADRES"].ToString();
                ent.RANDEVUTARIHI1 =DateTime.Parse( dr["RANDEVUTARIHI"].ToString()) ;
                ent.TC1 = dr["TC"].ToString();
                
                deger.Add(ent);

            }
            dr.Close();
            return deger;

            

        }
        public static int hastaekle(Entity n)
        {
            SqlCommand add= new SqlCommand("Insert into hastabilgileri (ISIM,SOYISIM,DOGUMTARIHI,TC,KANGRUBU,KRONIKHASTALIK,AMELIYAT,TESHIS,TEDAVIPLANI,TELEFON,ADRES,UCRET,BORC,RANDEVUTARIHI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)",DAL.con);
            if (add.Connection.State != System.Data.ConnectionState.Open)
            {
                add.Connection.Open();
            }
            add.Parameters.Add("@p1",n.ISIM1);
            add.Parameters.Add("@p2", n.SOYISIM1);
            add.Parameters.Add("@p3", n.DOGUMTARIHI1);
            add.Parameters.Add("@p4", n.TC1);
            add.Parameters.Add("@p5", n.KANGRUBU1);
            add.Parameters.Add("@p6", n.KRONIKHASTALIK1);
            add.Parameters.Add("@p7", n.AMELIYAT1);
            add.Parameters.Add("@p8", n.TESHIS1);
            add.Parameters.Add("@p9", n.TEDAVIPLANI1);
            add.Parameters.Add("@p10", n.TELEFON1);
            add.Parameters.Add("@p11", n.ADRES1);
            add.Parameters.Add("@p12",n.UCRET1);
            add.Parameters.Add("@p13", n.BORC1);
            add.Parameters.Add("@p14", n.RANDEVUTARIHI1);

            return add.ExecuteNonQuery();
            
        }

        


        public static int  randevuguncelle(Entity n)
        {
            SqlCommand update = new SqlCommand("update hastabilgileri set RANDEVUTARIHI=@p1 where ID=@p2", DAL.con);
            if (update.Connection.State != System.Data.ConnectionState.Open)
            {
                update.Connection.Open();
            }
            update.Parameters.AddWithValue("@p1", n.RANDEVUTARIHI1);
            update.Parameters.AddWithValue("@p2",n.ID1);
            return update.ExecuteNonQuery() ;
        }

    }
}
