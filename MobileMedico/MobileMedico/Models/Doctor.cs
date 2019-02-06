using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedico.Models
{
   public class Doctor
    {
        public int ID_DOCTOR { get; set; }

        public string NAME { get; set; }

        public string LASTNAME { get; set; }

        public string EMAIL { get; set; }


        public string PASSWORD { get; set; }

        public string GENDER { get; set; }

        public int ID_COUNTRY { get; set; }

        public string SPECIALTY { get; set; }
        public string ORDER_NUMBER { get; set; }
        public System.DateTime INIT_DATE_CAREER { get; set; }
        public System.DateTime BIRTH_DATE { get; set; }
        public string LANGUAGES { get; set; }
        public string TAXPAYER { get; set; }
        public string LOCALITY { get; set; }
        public string MOBILE_NUMBER { get; set; }
        public System.DateTime DATECREATED { get; set; }
        public bool STATUS { get; set; }

        public virtual TABLE_COUNTRY TABLE_COUNTRY { get; set; }
    }
}
