using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarZone.Models;

namespace WarZone.ViewModel
{
    public class AllDataModel
    {
        public List<PrimaryModel> Primary { get; set; }
        public List<SecondaryModel> Secondary { get; set; }
        public List<PerksModel> Perks { get; set; }
        public List<LethalModel> Lethal { get; set; }
        public List<TacticalModel> Tactical { get; set; }
    }
}
