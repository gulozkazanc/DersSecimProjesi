using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1
{
   public class EntityBasvuruForm
    {
        int basvuruid;
        int basdersid;
        int basogrid;

        public int Basvuruid { get => basvuruid; set => basvuruid = value; }
        public int Basdersid { get => basdersid; set => basdersid = value; }
        public int Basogrid { get => basogrid; set => basogrid = value; }
    }
}
