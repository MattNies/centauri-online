using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Models
{
    public class CharacterModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }

        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
