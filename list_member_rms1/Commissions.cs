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
        private string _type_member;
        public string type_member {

            get
            {
                return _type_member;
            }
            set
            {
                
                
                 if (value == "2")
                {
                    _type_member = "Budget, finances et de la programmation";

                }
                else if (value == "3")
                {
                    _type_member = "Développement économique, social et environnemental, de la formation professionnelle et de la formation ";

                }
                else if (value == "4")
                {
                    _type_member = "l’Aménagement du territoire";

                }
                else if (value == "5")
                {
                    _type_member = "Action culturelle ";

                }
                else if (value == "6")
                {
                    _type_member = "Tourisme et de l'artisanat";

                }
                else if (value == "7")
                {
                    _type_member = "Coopération et de partenariat";

                }
                else if (value == "8")
                {
                    _type_member = "la femme, l’enfance et la jeunesse";

                }
            }


        }
    }
}
