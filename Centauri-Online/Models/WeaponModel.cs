using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Models
{
    public class WeaponModel
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Accuracy { get; set; }
        public int RateOfFire { get; set; }
        public int BaseRange { get; set; }
        public string Ammo { get; set; }
        public double Weight { get; set; }
        public int Complexity { get; set; }
        public decimal Cost { get; set; }
        public string Extra { get; set; }
    }
}
