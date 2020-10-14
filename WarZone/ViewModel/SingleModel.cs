using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarZone.Models;

namespace WarZone.ViewModel
{
    public class SingleModel
    {
        public string PriName { get; set; }
        public string PriImage { get; set; }

        public string SecName { get; set; }
        public string SecImage { get; set; }

        public string TecName { get; set; }
        public string TecImage { get; set; }

        public string LethName { get; set; }
        public string LethImage { get; set; }

        public List<PerksModel> perks { get; set; }
       
    }
}
