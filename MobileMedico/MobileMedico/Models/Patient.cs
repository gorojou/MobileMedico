using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedico.Models
{
    public class Patient
    {
                  

        public int IdPatient { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string ConsultationDescription { get; set; }
        public string Diseases { get; set; }
        public string Alergy { get; set; }
        public string Country { get; set; }
        public string Lenguage { get; set; }
        public string TwillioId { get; set; }
        public bool IsTwillioReg { get; set; }

    }
}
