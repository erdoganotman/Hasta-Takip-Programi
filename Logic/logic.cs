using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DAL;
using System.Data.SqlClient;

namespace Logic
{
    public class logic
    {
        public static List<Entity> hastalist()
        {
            
            return CRUD.hastanelistesi();
        }
       
        public static int  hastaekle(Entity p)
        {
            return CRUD.hastaekle(p);
        }
    }
}
