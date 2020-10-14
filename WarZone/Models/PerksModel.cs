using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarZone.Models
{
    public class PerksModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PerkSlot { get; set; }
        public string Image { get; set; }
        public string Des { get; set; }
    }
}
