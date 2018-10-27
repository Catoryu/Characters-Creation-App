﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardianOfTime
{
    class World
    {
        public static int PeopleMinHeight = 100;
        public static int PeopleMaxHeight = 221;
        public static int GodMinHeight = 240;
        public static int GodMaxHeight = 260;

        public List<string> Elements;

        //Creates a simple World
        public World()
        {
            Elements.Add("Feu");
            Elements.Add("Glace");
            Elements.Add("Eau");
            Elements.Add("Terre");
            Elements.Add("Vent");
            Elements.Add("Foudre");
            Elements.Add("Lumière");
            Elements.Add("Ténèbres");
        }
    }

    struct LastName
    {
        public string Name;
        public Race Race;
        public List<string> FirstNames;

        public LastName(string Name, Race Race)
        {
            this.Name = Name;
            this.Race = Race;
            this.FirstNames = new List<string>();
        }
    }

    struct Race
    {
        public string Name;

        public Race(string Name)
        {
            this.Name = Name;
        }
    }

    struct Hair
    {
        public string Color;
        public string Length;

        public Hair(string Color, string Length)
        {
            this.Color = Color;
            this.Length = Length;
        }
    }

    struct Timeline
    {
        public string Name;
        public DateTime MainDate;

        public Timeline(string Name, DateTime MainDate)
        {
            this.Name = Name;
            this.MainDate = MainDate;

        }
    }

    struct Thing
    {
        public string Name;

        public Thing(string Name)
        {
            this.Name = Name;
        }
    }

    struct Power
    {
        public string Name;

        public Power(string Name)
        {
            this.Name = Name;

        }
    }

    struct Activity
    {
        public string Title;
        public Timeline Timeline;

        public Activity(string Title, Timeline Timeline)
        {
            this.Title = Title;
            this.Timeline = Timeline;
        }
    }

    struct BackStory
    {
        public string Title;
        public string Story;
        public Timeline Timeline;

        public BackStory(string Title, string Story, Timeline Timeline)
        {
            this.Title = Title;
            this.Story = Story;
            this.Timeline = Timeline;
        }
    }

    struct Weapon
    {
        public string Name;
        public string Element;
        public bool Special;

        public Weapon(string Name)
        {
            this.Name = Name;
            this.Element = null;
            this.Special = false;
        }

        public Weapon(string Name, bool Special)
        {
            this.Name = Name;
            this.Element = null;
            this.Special = Special;
        }

        public Weapon(string Name, bool Special, string Element)
        {
            this.Name = Name;
            this.Element = Element;
            this.Special = Special;
        }
    }
}