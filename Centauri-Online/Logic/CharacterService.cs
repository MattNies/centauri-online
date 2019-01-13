using Centauri_Online.Data;
using Centauri_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centauri_Online.Logic
{
    public class CharacterService
    {
        private GenericDataAccess<CharacterModel> dao;

        public CharacterService()
        {
            this.dao = new GenericDataAccess<CharacterModel>(ConnectionHelper.CHARACTER_DOC_NAME);
        }

        public List<CharacterModel> findCharacters(UserModel user)
        {
            var characters = dao.FindAll();
            return characters.Where(c => c.UserID == user.ID).ToList();
        }

        public CharacterModel create(CharacterModel character)
        {
            bool isInserted = dao.Upsert(character);

            if (isInserted)
            {
                // the character model was inserted
            } else
            {
                // the character model was updated
            }
            return character;
        }

        public void remove(CharacterModel character)
        {
            // log character information so it can be recreated
            bool isRemoved = dao.Delete(character.ID);
            if (!isRemoved)
            {
                // log character is not removed
                // maybe throw an error?
            }
        }

    }
}
