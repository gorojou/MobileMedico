using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedico.Models
{
    public class TABLE_COUNTRY
    {
        public TABLE_COUNTRY()
        {
            
        }

        public int ID_COUNTRY { get; set; }
        public string NAME { get; set; }
        public bool STATUS { get; set; }
        public System.DateTime DATECREATED { get; set; }
    }
}
