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
        private string documentName;

        public GenericDataAccess(string documentName)
        {
            this.documentName = documentName;
        }

        public IEnumerable<T> FindAll()
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.FindAll();
            }
        }

        public T Find(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.FindById(id);
            }
        }

        public bool Upsert(T weapon)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.Upsert(weapon);
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<T>(documentName);
                return weapons.Delete(id);
            }
        }
    }
}
