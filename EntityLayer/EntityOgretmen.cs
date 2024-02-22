using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    class EntityOgretmen
    {
        int ogrtid;
        string ogrtad;
        int ogrtbrans;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public string Ogrtad { get => ogrtad; set => ogrtad = value; }
        public int Ogrtbrans { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
