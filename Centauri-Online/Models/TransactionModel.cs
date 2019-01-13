using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Models
{
    public class TransactionModel
    {

        public int CharacterSendId { get; set; }
        public int? CharacterRecId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
