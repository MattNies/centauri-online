using Centauri_Online.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Data
{
    public class CharacterDAO
    {
        private readonly string characterDocumentName = "character";

        public IEnumerable<CharacterModel> FindAll()
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var character = db.GetCollection<CharacterModel>(characterDocumentName);
                return character.FindAll();
            }
        }

        public CharacterModel Find(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var character = db.GetCollection<CharacterModel>(characterDocumentName);
                return character.FindById(id);
            }
        }

        public bool Upsert(CharacterModel character)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var characters = db.GetCollection<CharacterModel>(characterDocumentName);
                return characters.Upsert(character);
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var character = db.GetCollection<CharacterModel>(characterDocumentName);
                return character.Delete(id);
            }
        }
    }
}
