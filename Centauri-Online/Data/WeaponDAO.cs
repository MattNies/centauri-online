using Centauri_Online.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Data
{
    public class WeaponDAO
    {
        private readonly string weaponDocumentName = "weapons";

        public IEnumerable<WeaponModel> FindAll()
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<WeaponModel>(weaponDocumentName);
                return weapons.FindAll();
            }
        }

        public WeaponModel Find(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<WeaponModel>(weaponDocumentName);
                return weapons.FindById(id);
            }
        }

        public bool Upsert(WeaponModel weapon)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<WeaponModel>(weaponDocumentName);
                return weapons.Upsert(weapon);
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<WeaponModel>(weaponDocumentName);
                return weapons.Delete(id);
            }
        }
    }
}
