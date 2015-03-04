using System;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using PFSheets.Account;
using PFSheets.Models;

namespace PFSheets
{
    public partial class CharacterSheet : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_OnClick(object sender, EventArgs e)
        {
            var charId = CreateNewCharacter();
            AddClasses(charId);
        }
        /*
        private object GetId()
        {
            var db = new ApplicationUser()
        }
        */
        private void AddClasses(int charId)
        {
            var level1 = GetLevels(1);
            var level2 = GetLevels(2);
            var level3 = GetLevels(3);
            var level4 = GetLevels(4);
            var level5 = GetLevels(5);
           
            var classes = new Class
            {
                Class1 = Request.Form["class1"],
                Level1 = level1,
                Class2 = Request.Form["class2"],
                Level2 = level2,
                Class3 = Request.Form["class3"],
                Level3 = level3,
                Class4 = Request.Form["class4"],
                Level4 = level4,
                Class5 = Request.Form["class5"],
                Level5 = level5,
                Character = charId
            };
            
            var db = new SheetsContext();
            db.Classes.Add(classes);
            db.SaveChanges();
        }

        private int GetLevels(int numLevel)
        {
            var formToRequest = "level";
            switch (numLevel)
            {
                case 1:
                    formToRequest += "1";
                    break;
                case 2:
                    formToRequest += "2";
                    break;
                case 3:
                    formToRequest += "3";
                    break;
                case 4:
                    formToRequest += "4";
                    break;
                case 5:
                    formToRequest += "5";
                    break;

            }
            int value;
            var level = 0;
            if (int.TryParse(Request.Form[formToRequest], out value))
            {
                level = value;
            }
            return level;
        }

        private int CreateNewCharacter()
        {
            var character = new Character
            {
                
                PlayerName = Request.Form["playerName"],
                CharName = Request.Form["charName"],
                Alignment = Request.Form["alignment"],
                Deity = Request.Form["deity"],
                Race = Request.Form["race"],
                UserID = HttpContext.Current.User.Identity.Name

            };
           
            var db = new SheetsContext();
            db.Characters.Add(character);
            db.SaveChanges();

            var charId = from q in db.Characters
                         where q.CharName.Equals(character.CharName) && q.UserID.Equals(HttpContext.Current.User.Identity.Name)
                         select q.ID;
            return Convert.ToInt32(charId.Max());

            
        }
    }
}