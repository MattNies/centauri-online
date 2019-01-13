using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Data
{
    public class CharacterBalanceDAO
    {
        private readonly string characterBalanceDocumentName = "character_balance";

        public CharacterBalanceModel Find(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var balance = db.GetCollection<CharacterBalanceModel>(characterBalanceDocumentName);
                return balance.FindById(id);
            }
        }

        public bool Upsert(CharacterBalanceModel balance)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var balances = db.GetCollection<CharacterBalanceModel>(characterBalanceDocumentName);
                return balances.Upsert(balance);
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var balance = db.GetCollection<CharacterBalanceModel>(characterBalanceDocumentName);
                return balance.Delete(id);
            }
        }

    }

}
