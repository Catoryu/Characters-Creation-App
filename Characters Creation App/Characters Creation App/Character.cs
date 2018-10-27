using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianOfTime
{
    class Character
    {
        #region attributes
        private string lastName;
        public string LastName { get { return lastName; } set { lastName = value; } }
        private string firstName;
        public string FirstName { get { return firstName; } set { firstName = value; } }
        private string hairColor;
        public string HairColor { get { return hairColor; } set { hairColor = value; } }
        private string hairLength;
        public string HairLength { get { return hairLength; } set { hairLength = value; } }
        private string eyesColor;
        public string EyesColor { get { return eyesColor; } set { eyesColor = value; } }
        private string race;
        public string Race { get { return race; } set { race = value; } }
        private int height;
        public int Height { get { return height; } set { height = value; } }
        private DateTime birth;
        public DateTime Birth { get { return Birth; } set { birth = value; } }
        private string timeLine;
        public string TimeLine { get { return timeLine; } set { timeLine = value; } }
        public List<string> Likes;
        public List<string> Unlikes;
        public List<string> Elements;
        public List<string> Powers;
        public List<string> Activities;
        public List<string> Backstory;
        public List<string> Weapons;
        #endregion attributes

        #region special attributes
        //Updated is an attribute that says if values should be updated (manualy of course) to a .docx file
        private bool updated;
        public bool Updated { get { return updated; } set { updated = value; } }
        #endregion special attributes

        //Creates a null character
        public Character()
        {
            this.Updated = true;
        }

        //Creates a character without all the lists
        public Character(string LastName, string FirstName, string HairLength, string HairColor, string EyesColor,
            string Race, int Height, DateTime DateOfBirth, string TimeLine)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.HairLength = HairLength;
            this.HairColor = HairColor;
            this.EyesColor = EyesColor;
            this.Race = Race;
            this.Height = Height;
            this.Birth = DateOfBirth;
            this.TimeLine = TimeLine;
            this.Updated = true;
        }

        //Creates a complete character.
        public Character(string LastName, string FirstName, string HairLength, string HairColor, string EyesColor,
            string Race, int Height, DateTime DateOfBirth, List<string> Likes, List<string> Unlikes, List<string> Elements,
            List<string> Powers, List<string> Activities, List<string> Backstory, List<string> Weapons)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.HairLength = HairLength;
            this.HairColor = HairColor;
            this.EyesColor = EyesColor;
            this.Race = Race;
            this.Height = Height;
            this.Birth = DateOfBirth;
            this.TimeLine = TimeLine;
            this.Likes = Likes;
            this.Unlikes = Unlikes;
            this.Elements = Elements;
            this.Powers = Powers;
            this.Activities = Activities;
            this.Backstory = Backstory;
            this.Weapons = Weapons;
            this.Updated = true;
        }

        #region public methods
        /// <summary>
        /// Sets the update state to false if update on .docx was needed.
        /// </summary>
        /// <returns>was Update needed ?</returns>
        public bool Update()
        {
            if (this.Updated)
            {
                this.Updated = false;
                return true;
            } else
            {
                return false;
            }
        }
        #endregion public methods
    }
}
