using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Models
{
    public class WeaponModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Accuracy { get; set; }

        [DisplayName("Rate of Fire")]
        public int RateOfFire { get; set; }

        [DisplayName("Base Range")]
        public int BaseRange { get; set; }
        public string Ammo { get; set; }
        public double Weight { get; set; }
        public string Complexity { get; set; }
        public decimal Cost { get; set; }
        public string Extra { get; set; }

        // used to sort weapons by type
        public string MajorTag { get; set; }
        public string MinorTag { get; set; }
        public int Order { get; set; }
    }
}
