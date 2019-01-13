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

        private CharacterDAO charDAO;
        private TransactionDAO transDAO;

        public PaymentService()
        {
            this.charDAO = new CharacterDAO();
            this.transDAO = new TransactionDAO();
        }

        public bool creditAccount(CharacterModel character, decimal amount)
        {
            decimal charBalance = getBalance(character);
            if (canCreditAccount(amount, charBalance))
            {
                character.Balance = charBalance - amount;
                charDAO.Upsert(character);
                transaction(character, null, amount, "credit");
                return true;
            }
            return false;
        }

        public void debitAccount(CharacterModel character, decimal amount)
        {
            decimal charBalance = getBalance(character);
            character.Balance = charBalance + amount;
            charDAO.Upsert(character);
            transaction(character, null, amount, "debit");
        }

        public void transfer(CharacterModel sendChar, CharacterModel recChar, decimal amount)
        {
            bool creditPassed = creditAccount(sendChar, amount);
            if (creditPassed)
            {
                debitAccount(recChar, amount);
                transaction(sendChar, recChar, amount, "transfer");
            }
        }

        public void transaction(CharacterModel sendChar, CharacterModel recChar, decimal amount, string type)
        {
            TransactionModel transaction = new TransactionModel();
            transaction.CharacterSendId = sendChar.ID;
            transaction.CharacterRecId = recChar?.ID;
            transaction.Amount = amount;
        }

        public decimal getBalance(CharacterModel character)
        {
            CharacterModel dbCharacter = charDAO.Find(character.ID);

            return dbCharacter.Balance;
        }

        public bool canCreditAccount(decimal creditAmount, decimal accountAmount)
        {
            return accountAmount >= creditAmount;
        }

    }
}
