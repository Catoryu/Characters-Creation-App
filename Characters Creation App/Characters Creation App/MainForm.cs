using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logs;//LogWriter by Catoryu
using Imports;//FileImporter by Catoryu

namespace GuardianOfTime
{
    public partial class MainForm : Form
    {
        //LogWriter
        private log LW = new log();

        //Initializing the world
        private World W = new World();
        private List<Timeline> TLs = new List<Timeline>();
        private List<Activity> Acts = new List<Activity>();
        private List<BackStory> BS = new List<BackStory>();
        private List<Weapon> Weapons = new List<Weapon>();
        private List<Race> Races = new List<Race>();
        private List<LastName> NdF = new List<LastName>();
        private List<Character> CharaList = new List<Character>();

        /// <summary>
        /// Initialize MainForm.
        /// </summary>
        public MainForm()
        {
            LW.Create(@"C:\logCS");
            try
            {
                LW.Debug("Initializing MainForm.");
                InitializeComponent();
                LW.Debug("Initializing World items.");
                #region Timelines
                TLs.Add(new Timeline("Originelle", new DateTime(15840, 1, 1)));//2512o, 16100MK
                TLs.Add(new Timeline("MK-0/MK-2", new DateTime(15378, 1, 1)));//2050o, 15638MK
                TLs.Add(new Timeline("MK-1", new DateTime(0, 1, 1)));//-13588o, 260MK
                #endregion Timelines
                #region Activities/Titles
                //Originelle
                Acts.Add(new Activity("6th Dragon Council", TLs[0]));
                Acts.Add(new Activity("9th Dragon Council", TLs[0]));
                Acts.Add(new Activity("Demon Lord", TLs[0]));
                Acts.Add(new Activity("Fire God", TLs[0]));
                Acts.Add(new Activity("Ice God", TLs[0]));
                Acts.Add(new Activity("Water God", TLs[0]));
                Acts.Add(new Activity("Earth God", TLs[0]));
                Acts.Add(new Activity("Wind God", TLs[0]));
                Acts.Add(new Activity("Thunder God", TLs[0]));
                Acts.Add(new Activity("Light God", TLs[0]));
                Acts.Add(new Activity("Drakness" +
                    " God", TLs[0]));
                //MK-0|MK-2
                Acts.Add(new Activity("1st Dragon Council", TLs[1]));
                Acts.Add(new Activity("2nd Dragon Council", TLs[1]));
                Acts.Add(new Activity("3rd Dragon Council", TLs[1]));
                Acts.Add(new Activity("4th Dragon Council until 2047o", TLs[1]));
                Acts.Add(new Activity("4th Dragon Council", TLs[1]));
                Acts.Add(new Activity("5th Dragon Council", TLs[1]));
                Acts.Add(new Activity("6th Dragon Council", TLs[1]));
                Acts.Add(new Activity("7th Dragon Council", TLs[1]));
                Acts.Add(new Activity("8th Dragon Council", TLs[1]));
                Acts.Add(new Activity("9th Dragon Council", TLs[1]));
                Acts.Add(new Activity("10th Dragon Council", TLs[1]));
                Acts.Add(new Activity("Magic School Director", TLs[1]));
                Acts.Add(new Activity("Magic School 3rd Year Professor", TLs[1]));
                Acts.Add(new Activity("Magic School 2nd Year Professor", TLs[1]));
                Acts.Add(new Activity("Magic School 1st Year Professor", TLs[1]));
                Acts.Add(new Activity("SRP Leader", TLs[1]));
                Acts.Add(new Activity("Temp SRP Leader", TLs[1]));
                Acts.Add(new Activity("SRP Dragon Leader", TLs[1]));
                Acts.Add(new Activity("SRP Beast Leader", TLs[1]));
                Acts.Add(new Activity("SRP Beast Sub-Leader", TLs[1]));
                Acts.Add(new Activity("SRP Beast Sub-Leader 2", TLs[1]));
                Acts.Add(new Activity("SRP Vampire Leader", TLs[1]));
                Acts.Add(new Activity("SRP Vampire Sub-Leader", TLs[1]));
                Acts.Add(new Activity("SRP Vampire Sub-Leader 2", TLs[1]));
                Acts.Add(new Activity("SRP Vampire Sub-Leader 3", TLs[1]));
                Acts.Add(new Activity("SRP Human Leader", TLs[1]));
                Acts.Add(new Activity("SRP Human Sub-Leader", TLs[1]));
                Acts.Add(new Activity("SRP Human Sub-Leader 2", TLs[1]));
                Acts.Add(new Activity("SENH Leader", TLs[1]));
                Acts.Add(new Activity("SENH Sub-Leader", TLs[1]));
                Acts.Add(new Activity("SENH Sub-Leader 2", TLs[1]));
                Acts.Add(new Activity("SENH Sub-Leader 3", TLs[1]));
                Acts.Add(new Activity("SENH Sub-Leader 4", TLs[1]));
                Acts.Add(new Activity("SENH Sub-Leader 5", TLs[1]));
                Acts.Add(new Activity("SENH Sub-Leader 6", TLs[1]));
                //MK-1
                Acts.Add(new Activity("1st Dragon Council", TLs[2]));
                Acts.Add(new Activity("2nd Dragon Council", TLs[2]));
                Acts.Add(new Activity("3rd Dragon Council", TLs[2]));
                Acts.Add(new Activity("4th Dragon Council", TLs[2]));
                Acts.Add(new Activity("5th Dragon Council", TLs[2]));
                Acts.Add(new Activity("6th Dragon Council", TLs[2]));
                Acts.Add(new Activity("7th Dragon Council", TLs[2]));
                Acts.Add(new Activity("8th Dragon Council", TLs[2]));
                Acts.Add(new Activity("9th Dragon Council", TLs[2]));
                Acts.Add(new Activity("10th Dragon Council", TLs[2]));
                Acts.Add(new Activity("Fire Clan Leader", TLs[2]));
                Acts.Add(new Activity("Fire Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Ice Clan Leader until 262MK", TLs[2]));
                Acts.Add(new Activity("Ice Clan Leader", TLs[2]));
                Acts.Add(new Activity("Ice Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Water Clan Leader", TLs[2]));
                Acts.Add(new Activity("Water Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Earth Clan Leader until 265MK", TLs[2]));
                Acts.Add(new Activity("Earth Clan Leader", TLs[2]));
                Acts.Add(new Activity("Earth Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Wind Clan Leader", TLs[2]));
                Acts.Add(new Activity("Wind Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Thunder Clan Leader", TLs[2]));
                Acts.Add(new Activity("Thunder Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Light Clan Leader", TLs[2]));
                Acts.Add(new Activity("Light Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Darkness Clan Leader", TLs[2]));
                Acts.Add(new Activity("Darkness Clan Sub-Leader", TLs[2]));
                Acts.Add(new Activity("Magic School Director until 267MK", TLs[2]));
                Acts.Add(new Activity("Magic School Director", TLs[2]));
                Acts.Add(new Activity("Magic School 3rd Year Professor", TLs[2]));
                Acts.Add(new Activity("Magic School 2nd Year Professor until 260MK", TLs[2]));
                Acts.Add(new Activity("Magic School 2nd Year Professor", TLs[2]));
                Acts.Add(new Activity("Magic School 1st Year Professor", TLs[2]));
                Acts.Add(new Activity("Fire Master", TLs[2]));
                Acts.Add(new Activity("Ice Master until 260MK", TLs[2]));
                Acts.Add(new Activity("Ice Master", TLs[2]));
                Acts.Add(new Activity("Water Master", TLs[2]));
                Acts.Add(new Activity("Earth Master", TLs[2]));
                Acts.Add(new Activity("Wind Master", TLs[2]));
                Acts.Add(new Activity("Thunder Master until 268MK", TLs[2]));
                Acts.Add(new Activity("Thunder Master", TLs[2]));
                Acts.Add(new Activity("Light Master", TLs[2]));
                Acts.Add(new Activity("Darkness Master", TLs[2]));
                #endregion Activities/Titles
                #region Backstories
                BS.Add(new BackStory("Pas de Parents", "Ses parents sont morts quand il était plus jeune.", TLs[1]));
                BS.Add(new BackStory("Sauvage", "Il a vécu dans la nature.", TLs[1]));
                BS.Add(new BackStory("Sauvage", "Il a vécu dans la nature.", TLs[2]));
                #endregion Backstories
                #region Weapons
                //Simple Weapons
                Weapons.Add(new Weapon("Gun"));
                Weapons.Add(new Weapon("Lame"));
                Weapons.Add(new Weapon("Epée"));
                Weapons.Add(new Weapon("Katana"));
                Weapons.Add(new Weapon("Lance"));
                Weapons.Add(new Weapon("Gantelets"));
                Weapons.Add(new Weapon("Sceptre"));
                Weapons.Add(new Weapon("Dague"));
                Weapons.Add(new Weapon("Arc"));
                Weapons.Add(new Weapon("Grimoire"));
                Weapons.Add(new Weapon("Marteau"));
                Weapons.Add(new Weapon("Hache"));
                Weapons.Add(new Weapon("Eventail"));
                //Legendary Weapons
                Weapons.Add(new Weapon("Muteki", true));
                Weapons.Add(new Weapon("Doku", true));
                Weapons.Add(new Weapon("Jigoku", true));
                Weapons.Add(new Weapon("Tsukuru", true));
                Weapons.Add(new Weapon("Hangeki", true));
                Weapons.Add(new Weapon("Maho", true));
                Weapons.Add(new Weapon("Chiten", true));
                Weapons.Add(new Weapon("Spectre", true));
                Weapons.Add(new Weapon("Hokai", true));
                //Elemental Weapons
                Weapons.Add(new Weapon("Ilamas", true, "Feu"));
                Weapons.Add(new Weapon("Frost Gale", true, "Glace"));
                Weapons.Add(new Weapon("Sruth", true, "Eau"));
                Weapons.Add(new Weapon("Pane", true, "Terre"));
                Weapons.Add(new Weapon("Fengbao", true, "Vent"));
                Weapons.Add(new Weapon("Tsukuyomi", true, "Foudre"));
                Weapons.Add(new Weapon("Solis", true, "Lumière"));
                Weapons.Add(new Weapon("Aloka", true, "Darkness"));
                #endregion Weapons
                #region Races
                Races.Add(new Race("Dragon"));
                Races.Add(new Race("Homme-bête"));
                Races.Add(new Race("Vampire"));
                Races.Add(new Race("Humain"));
                Races.Add(new Race("Démon draconnique"));
                #endregion Races

            }
            catch (Exception ex)
            {
                LW.Error(ex);
            }
        }
    }
}
