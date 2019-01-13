using Centauri_Online.Data;
using Centauri_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Logic
{
    public class PaymentService
    {

        private CharacterBalanceDAO payment;

        public PaymentService()
        {
            this.payment = new CharacterBalanceDAO();
        }

        public void creditAccount(CharacterModel character, decimal amount)
        {

        }

        public void debitAccount(CharacterModel character, decimal amount)
        {

        }

        public decimal getBalance(CharacterModel character)
        {
            return payment.Find(character.ID);
        }

        public bool canCreditAccount(decimal creditAmount, decimal accountAmount)
        {
            return accountAmount >= creditAmount;
        }

    }
}
