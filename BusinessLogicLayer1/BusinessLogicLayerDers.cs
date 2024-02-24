using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer1;
using DataAccessLayer1;

namespace BusinessLogicLayer1
{
   public class BusinessLogicLayerDers
    {
        public static List<EntityDers> BllListele()
        {
            return DataAccsessLayerDers.DersListesi();
        }

    }
}
