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

        private GenericDataAccess<CharacterModel> charDAO;
        private GenericDataAccess<TransactionModel> transDAO;

        public PaymentService()
        {
            this.charDAO = new GenericDataAccess<CharacterModel>();
            this.transDAO = new GenericDataAccess<TransactionModel>();
        }

        public bool creditAccount(CharacterModel character, decimal amount)
        {
            decimal charBalance = getBalance(character);
            if (canCreditAccount(amount, charBalance))
            {
                character.Balance = charBalance - amount;
                charDAO.Upsert(character, ConnectionHelper.CHARACTER_DOC_NAME);
                transaction(character, null, amount, "credit");
                return true;
            }
            return false;
        }

        public void debitAccount(CharacterModel character, decimal amount)
        {
            decimal charBalance = getBalance(character);
            character.Balance = charBalance + amount;
            charDAO.Upsert(character, ConnectionHelper.CHARACTER_DOC_NAME);
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
            transDAO.Upsert(transaction, ConnectionHelper.TRANSACTION_DOC_NAME);
        }

        public decimal getBalance(CharacterModel character)
        {
            CharacterModel dbCharacter = charDAO.Find(character.ID, ConnectionHelper.CHARACTER_DOC_NAME);

            return dbCharacter.Balance;
        }

        public bool canCreditAccount(decimal creditAmount, decimal accountAmount)
        {
            return accountAmount >= creditAmount;
        }

    }
}
