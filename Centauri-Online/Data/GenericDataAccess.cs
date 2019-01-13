using Centauri_Online.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Data
{
    public class GenericDataAccess<T>
    {
        public IEnumerable<T> FindAll(string documentName)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.FindAll();
            }
        }

        public T Find(int id, string documentName)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.FindById(id);
            }
        }

        public bool Upsert(T weapon, string documentName)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.Upsert(weapon);
            }
        }

        public bool Delete(int id, string documentName)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.Delete(id);
            }
        }
    }
}
