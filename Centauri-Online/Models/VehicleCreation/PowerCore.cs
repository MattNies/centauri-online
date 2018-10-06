using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Models.VehicleCreation
{
    public class PowerCore
    {
        public int Complexity { get; private set; }
        public double Size { get; private set; }
        public int MaxArmor { get; private set; }
        public int HardPoints { get; private set; }
        public int BasePerkPoints { get; private set; }
        public int[] PoorRange { get; private set; }
        public int[] AverageRange { get; private set; }
        public int[] ExceptionalRange { get; private set; }
        public int ExceptionalBonus { get; private set; }
        public int CuttEdge { get; private set; }
        public int Cost { get; private set; }

        public int AdditionalPerks { get; set; }

        public PowerCore(int complexity, double size, int basePerkPoints, int maxArmor,
            int hardPoints, int[] poorRange, int[] averageRange, int[] exceptionalRange,
            int cuttingEdge, int exceptionalBonus, int cost)
        {
            Complexity = complexity;
            Size = size;
            BasePerkPoints = basePerkPoints;
            MaxArmor = maxArmor;
            HardPoints = hardPoints;
            PoorRange = poorRange;
            AverageRange = averageRange;
            ExceptionalRange = exceptionalRange;
            CuttEdge = cuttingEdge;
            ExceptionalBonus = exceptionalBonus;
            Cost = cost;
            AdditionalPerks = 0;
        }
    }
}
