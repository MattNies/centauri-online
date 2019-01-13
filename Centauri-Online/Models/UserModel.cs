using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string AccountName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> CharacterIDs { get; set; }
    }
}
