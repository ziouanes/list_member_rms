using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_member_rms1
{
  public  class Commissions
    {
        public int id { get; set; }
        public byte[] photos { get; set; }
        public string nomf { get; set; }
        public string nomA { get; set; }
        public string Parti { get; set; }
        public string Fonction_Fr { get; set; }
        public string ProvinceFr { get; set; }
        public string Sigle { get; set; }
        public int type_member { get; set; }
    }
}
