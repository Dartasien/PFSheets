using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace PFSheets.Models
{
    public class CharacterDbInitializer : DropCreateDatabaseIfModelChanges<SheetsContext>
    {
        protected override void Seed(SheetsContext context)
        {
           getCharacter().ForEach(s => context.Characters.Add(s));
        
        }

        private List<Character> getCharacter()
        {
            var characters = new List<Character>
            {
                new Character
                {
                    PlayerName = "Dart",
                    CharName = "Dartasien",

                }
            };

            return characters;
        }
    }
}