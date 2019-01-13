using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Data
{
    public class PaymentDAO
    {
        private readonly string paymentDocumentName = "payments";

        public IEnumerable<PaymentModel> FindAll()
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<PaymentModel>(paymentDocumentName);
                return weapons.FindAll();
            }
        }

        public PaymentModel Find(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<PaymentModel>(paymentDocumentName);
                return weapons.FindById(id);
            }
        }

        public bool Upsert(PaymentModel weapon)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<PaymentModel>(paymentDocumentName);
                return weapons.Upsert(weapon);
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(ConnectionHelper.DBFileName))
            {
                var weapons = db.GetCollection<PaymentModel>(paymentDocumentName);
                return weapons.Delete(id);
            }
        }

    }

}
