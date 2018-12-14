using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace F2018Letterkenny.Models
{
    public class EFCharacter : IMockCharacter
    {
        private DatabaseModel db = new DatabaseModel();
        //public IQueryable<Characters> IMockCharacter.Characters { get { return db.Characters;  } }
        public IQueryable<Character> Characters { get { return db.Characters; } }
        Character IMockCharacter.Save(Character character)
        {
            throw new NotImplementedException();
        }

    }
}