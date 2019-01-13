using Centauri_Online.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Data
{
    public class TransactionDAO
    {
        private readonly string characterDocumentName = "character";

        public IEnumerable<TransactionModel> FindAll()
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var character = db.GetCollection<TransactionModel>(characterDocumentName);
                return character.FindAll();
            }
        }

        public TransactionModel Find(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var character = db.GetCollection<TransactionModel>(characterDocumentName);
                return character.FindById(id);
            }
        }

        public bool Upsert(TransactionModel character)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var characters = db.GetCollection<TransactionModel>(characterDocumentName);
                return characters.Upsert(character);
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var character = db.GetCollection<TransactionModel>(characterDocumentName);
                return character.Delete(id);
            }
        }
    }
}
