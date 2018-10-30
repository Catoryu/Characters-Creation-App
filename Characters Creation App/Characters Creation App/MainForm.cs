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
        private List<Weapon> Weapons = new List<Weapon>();
        private List<Race> Races = new List<Race>();
        private List<LastName> NdF = new List<LastName>();
        private List<string> EC = new List<string>();
        private List<Hair> HairList = new List<Hair>();
        private List<Thing> Things = new List<Thing>();
        private List<Power> Powers = new List<Power>();
        private List<Character> CharaList = new List<Character>();

        //Random
        private Random Rnd = new Random();

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
                LW.Debug("Initializing World Lists.");
                #region Timelines
                TLs.Add(new Timeline("Originelle", new DateTime(2512, 1, 1)));//2512o, 16100MK
                TLs.Add(new Timeline("MK-0/MK-2", new DateTime(2050, 1, 1)));//2050o, 15638MK
                TLs.Add(new Timeline("MK-1", new DateTime(9260, 1, 1)));//-13588o, 260MK
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
                #region Eyes
                EC.Add("Bleu");
                EC.Add("Brun");
                EC.Add("Gris");
                EC.Add("Vert");
                EC.Add("Rouge");
                EC.Add("Doré");
                EC.Add("Noir");
                EC.Add("Violet");
                #endregion Eyes
                #region Hair
                HairList.Add(new Hair("Noir", "Chauve"));
                HairList.Add(new Hair("Noir", "Court"));
                HairList.Add(new Hair("Noir", "Mi-court"));
                HairList.Add(new Hair("Noir", "Mi-long"));
                HairList.Add(new Hair("Noir", "Long"));
                HairList.Add(new Hair("Noir", "Spécial"));
                HairList.Add(new Hair("Gris", "Chauve"));
                HairList.Add(new Hair("Gris", "Court"));
                HairList.Add(new Hair("Gris", "Mi-court"));
                HairList.Add(new Hair("Gris", "Mi-long"));
                HairList.Add(new Hair("Gris", "Long"));
                HairList.Add(new Hair("Gris", "Spécial"));
                HairList.Add(new Hair("Blanc", "Chauve"));
                HairList.Add(new Hair("Blanc", "Court"));
                HairList.Add(new Hair("Blanc", "Mi-court"));
                HairList.Add(new Hair("Blanc", "Mi-long"));
                HairList.Add(new Hair("Blanc", "Long"));
                HairList.Add(new Hair("Blanc", "Spécial"));
                HairList.Add(new Hair("Brun", "Chauve"));
                HairList.Add(new Hair("Brun", "Court"));
                HairList.Add(new Hair("Brun", "Mi-court"));
                HairList.Add(new Hair("Brun", "Mi-long"));
                HairList.Add(new Hair("Brun", "Long"));
                HairList.Add(new Hair("Brun", "Spécial"));
                HairList.Add(new Hair("Blond", "Chauve"));
                HairList.Add(new Hair("Blond", "Court"));
                HairList.Add(new Hair("Blond", "Mi-court"));
                HairList.Add(new Hair("Blond", "Mi-long"));
                HairList.Add(new Hair("Blond", "Long"));
                HairList.Add(new Hair("Blond", "Spécial"));
                HairList.Add(new Hair("Roux", "Chauve"));
                HairList.Add(new Hair("Roux", "Court"));
                HairList.Add(new Hair("Roux", "Mi-court"));
                HairList.Add(new Hair("Roux", "Mi-long"));
                HairList.Add(new Hair("Roux", "Long"));
                HairList.Add(new Hair("Roux", "Spécial"));
                HairList.Add(new Hair("Spéciale", "Chauve"));
                HairList.Add(new Hair("Spéciale", "Court"));
                HairList.Add(new Hair("Spéciale", "Mi-court"));
                HairList.Add(new Hair("Spéciale", "Mi-long"));
                HairList.Add(new Hair("Spéciale", "Long"));
                HairList.Add(new Hair("Spéciale", "Spécial"));
                #endregion Hair
                #region Things
                Things.Add(new Thing("Nourriture"));
                Things.Add(new Thing("Savoir"));
                Things.Add(new Thing("Entraînement"));
                Things.Add(new Thing("Volaille"));
                Things.Add(new Thing("Fruits"));
                Things.Add(new Thing("Les gens"));
                Things.Add(new Thing("Humains"));
                Things.Add(new Thing("Hommes-bêtes"));
                Things.Add(new Thing("Vampire"));
                Things.Add(new Thing("Nature"));
                Things.Add(new Thing("Aider les gens dans le besoin"));
                Things.Add(new Thing("Violence"));
                Things.Add(new Thing("Combat"));
                Things.Add(new Thing("Faiblesse"));
                Things.Add(new Thing("Force"));
                Things.Add(new Thing("Alcool"));
                Things.Add(new Thing("Légumes"));
                Things.Add(new Thing("Viande"));
                Things.Add(new Thing("Poisson"));
                Things.Add(new Thing("Sang"));
                Things.Add(new Thing("Complications"));
                Things.Add(new Thing("Féculants"));
                Things.Add(new Thing("Perseverance"));
                Things.Add(new Thing("Superiorité"));
                Things.Add(new Thing("Froid"));
                Things.Add(new Thing("Chaleur"));
                Things.Add(new Thing("Charité"));
                Things.Add(new Thing("Paresse"));
                Things.Add(new Thing("Espoir"));
                Things.Add(new Thing("Désespoir"));
                Things.Add(new Thing("Solitude"));
                Things.Add(new Thing("Calme"));
                Things.Add(new Thing("Bruit"));
                Things.Add(new Thing("Abandon"));
                Things.Add(new Thing("Victoire"));
                Things.Add(new Thing("Défaite"));
                Things.Add(new Thing("Vitesse"));
                Things.Add(new Thing("Ce monde"));
                Things.Add(new Thing("Soi-même"));
                Things.Add(new Thing("Amitié"));
                Things.Add(new Thing("Partage"));
                Things.Add(new Thing("Discuter"));
                Things.Add(new Thing("Ignorance"));
                Things.Add(new Thing("Société"));
                Things.Add(new Thing("Guerre"));
                Things.Add(new Thing("Paix"));
                Things.Add(new Thing("Conflits"));
                #endregion Things
                #region Powers
                Powers.Add(new Power("Propagation mentale"));
                Powers.Add(new Power("Contrôle des plantes"));
                Powers.Add(new Power("Apprentissage d'armes accéléré"));
                Powers.Add(new Power("Résurrection temporaire"));
                Powers.Add(new Power("Contrôle des vecteurs de force"));
                Powers.Add(new Power("Manipulation de décisions"));
                Powers.Add(new Power("Zone de ralentissement"));
                Powers.Add(new Power("Paralysie des membres"));
                Powers.Add(new Power("Déplacement accéléré"));
                Powers.Add(new Power("Feu divin"));
                Powers.Add(new Power("Glace divine"));
                Powers.Add(new Power("Eau divine"));
                Powers.Add(new Power("Terre divine"));
                Powers.Add(new Power("Vent divin"));
                Powers.Add(new Power("Foudre divine"));
                Powers.Add(new Power("Lumière divine"));
                Powers.Add(new Power("Ténèbres divins"));
                Powers.Add(new Power("Clonage"));
                Powers.Add(new Power("Rage"));
                Powers.Add(new Power("Déviation"));
                Powers.Add(new Power("Transmission nerveuse"));
                Powers.Add(new Power("Contrôle du sang"));
                Powers.Add(new Power("Armure rocheuse"));
                Powers.Add(new Power("Séparation de l'âme et du corps"));
                Powers.Add(new Power("Trou de ver"));
                Powers.Add(new Power("Téléportation"));
                Powers.Add(new Power("Contrôle mental"));
                Powers.Add(new Power("Télépathie"));
                Powers.Add(new Power("Zone d'accélération"));
                Powers.Add(new Power("Vision externe"));
                Powers.Add(new Power("Corps liquide"));
                Powers.Add(new Power("Corps gazeux"));
                Powers.Add(new Power("Garde imperturbable"));
                Powers.Add(new Power("Endurance illimitée"));
                Powers.Add(new Power("Métamorphose"));
                Powers.Add(new Power("Echolocation"));
                Powers.Add(new Power("Armure d'écailes"));
                Powers.Add(new Power("Clairvoyance"));
                Powers.Add(new Power("Echange d'esprit"));
                Powers.Add(new Power("Substitution spatiale"));
                Powers.Add(new Power("Augmentation de force"));
                Powers.Add(new Power("Déplacement interdimensionnel"));
                Powers.Add(new Power("Dimension personnelle"));
                Powers.Add(new Power("Illusions"));
                Powers.Add(new Power("Pulsions magnétiques"));
                Powers.Add(new Power("Répulsion"));
                Powers.Add(new Power("Attraction"));
                Powers.Add(new Power("Manipulation de souvenirs"));
                Powers.Add(new Power("Double-personnalité"));
                Powers.Add(new Power("Invisibilité"));
                Powers.Add(new Power("Manipulation de gravité"));
                Powers.Add(new Power("Psychométrie"));
                Powers.Add(new Power("Invocation d'esprits"));
                Powers.Add(new Power("Invocation de démons"));
                Powers.Add(new Power("Invocation de créatures"));
                Powers.Add(new Power("Possession d'esprits"));
                Powers.Add(new Power("Possession démoniaque"));
                Powers.Add(new Power("Perception extrasensorielle"));
                Powers.Add(new Power("Préconnaissance"));
                Powers.Add(new Power("Télékinesie"));
                Powers.Add(new Power("Rétrovision"));
                Powers.Add(new Power("Hypnose"));
                Powers.Add(new Power("Postvision"));
                Powers.Add(new Power("Contrôle de poisons"));
                Powers.Add(new Power("Manipulation de poid"));
                Powers.Add(new Power("Pensées accélérées"));
                Powers.Add(new Power("Connaissance de mensonges"));
                Powers.Add(new Power("Immunité aux maladies"));
                Powers.Add(new Power("Immunité à la fatigue"));
                Powers.Add(new Power("Immunité à la faim"));
                Powers.Add(new Power("Immunité à la soif"));
                Powers.Add(new Power("Autosuffisance"));
                Powers.Add(new Power("Corps spirituel"));
                Powers.Add(new Power("Crochetage"));
                Powers.Add(new Power("Odarat sur-développé"));
                Powers.Add(new Power("Ouïe sur-développée"));
                Powers.Add(new Power("Perception des températures"));
                Powers.Add(new Power("Transfert de mana"));
                Powers.Add(new Power("Immortalité"));
                Powers.Add(new Power("Lévitation"));
                Powers.Add(new Power("Détection d'énergie"));
                Powers.Add(new Power("Vision rayon X"));
                Powers.Add(new Power("Régéneration"));
                Powers.Add(new Power("Armure psychique"));
                Powers.Add(new Power("Soins"));
                Powers.Add(new Power("Propagation de sommeil"));
                Powers.Add(new Power("Propagation de peur"));
                Powers.Add(new Power("Perception universelle"));
                Powers.Add(new Power("Manipulation des probabilités"));
                Powers.Add(new Power("Analyse accélérée"));
                Powers.Add(new Power("Force émotionnelle"));
                Powers.Add(new Power("Augmentation de vitesse"));
                Powers.Add(new Power("Armure spirituelle"));
                Powers.Add(new Power("Contrôle des poussières"));
                Powers.Add(new Power("Armure crystallisée"));
                Powers.Add(new Power("Contrôle du bois"));
                Powers.Add(new Power("Contrôle des mineraux"));
                Powers.Add(new Power("Duplication"));
                Powers.Add(new Power("Absorption de dégats physiques"));
                Powers.Add(new Power("Immunité aux dégats physiques"));
                Powers.Add(new Power("Immunité à la douleur"));
                Powers.Add(new Power("Contrôle des gaz"));
                Powers.Add(new Power("Solidification"));
                Powers.Add(new Power("Inversion des vecteurs de force"));
                Powers.Add(new Power("Inversion de gravité"));
                Powers.Add(new Power("Vue sur-développée"));
                Powers.Add(new Power("Manipulation des sens"));
                Powers.Add(new Power("Manipulation des corps physiques"));
                Powers.Add(new Power("Suppression de souvenirs"));
                Powers.Add(new Power("Modification de souvenirs"));
                Powers.Add(new Power("Création de souvenirs"));
                Powers.Add(new Power("Inversion de probabilités"));
                Powers.Add(new Power("Attaque mentale"));
                Powers.Add(new Power("Manipulation des formes"));
                Powers.Add(new Power("Propagation de souvenirs"));
                Powers.Add(new Power("Propagation de connaissances"));
                Powers.Add(new Power("Perception de mana"));
                Powers.Add(new Power("Immunité au feu"));
                Powers.Add(new Power("Immunité à la glace"));
                Powers.Add(new Power("Immunité à l'eau"));
                Powers.Add(new Power("Immunité à la terre"));
                Powers.Add(new Power("Immunité au vent"));
                Powers.Add(new Power("Immunité à la foudre"));
                Powers.Add(new Power("Immunité à la lumière"));
                Powers.Add(new Power("Immunité aux ténèbres"));
                Powers.Add(new Power("Inversion des éléments"));
                #endregion Powers
            }
            catch (Exception ex)
            {
                LW.Error(ex);
            }
        }
    }
}
