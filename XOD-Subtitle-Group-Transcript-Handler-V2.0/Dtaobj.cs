using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOD Subtitle Group Transcript Handler V2.0
{
    class Dtaobj
    {
        public string Cn { get; set; }
        public string En { get; set; }
        public int id { get; set; }
        public Dtaobj(int id,string Cn, string En)
        {
            this.id = id;
            this.Cn = Cn;
            this.En = En;
        }
    }
}
