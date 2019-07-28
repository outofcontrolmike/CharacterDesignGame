using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class CharacterSheet
    {
        private string name;
        private string race;
        private string charClass;
        private int age;
        private int level;
        private int experience;
        private int gold;
        private int health;
        private int magicPower;
        private int strength;
        private int dexterity;
        private int intelligence;
        private int constitution;
        private int wisdom;
        private int charisma;
        private string equipedWeapon;
        private string equipedArmor;


        public CharacterSheet()
        {

        }

        public CharacterSheet(string name)
        {
            this.Name = name;
        }

        public CharacterSheet(string name, string race, string charClass, int age, int level, int experience,
            int gold, int health, int magicPower, int strength, int dexterity, int intelligence,
            int constitution, int wisdom, int charisma, string equipedWeapon, string equipedArmor)
        {
            this.Name = name;
            this.Race = race;
            this.CharClass = charClass;
            this.Age = age;
            this.Level = level;
            this.Experience = experience;
            this.Gold = gold;
            this.Health = health;
            this.MagicPower = magicPower;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Constitution = constitution;
            this.Wisdom = wisdom;
            this.Charisma = charisma;
            this.EquipedWeapon = equipedWeapon;
            this.EquipedArmor = equipedArmor;
        }

        public string Name { get => name; set => name = value; }
        public string Race { get => race; set => race = value; }
        public string CharClass { get => charClass; set => charClass = value; }
        public int Age { get => age; set => age = value; }
        public int Level { get => level; set => level = value; }
        public int Experience { get => experience; set => experience = value; }
        public int Gold { get => gold; set => gold = value; }
        public int Health { get => health; set => health = value; }
        public int MagicPower { get => magicPower; set => magicPower = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Constitution { get => constitution; set => constitution = value; }
        public int Wisdom { get => wisdom; set => wisdom = value; }
        public int Charisma { get => charisma; set => charisma = value; }
        public string EquipedWeapon { get => equipedWeapon; set => equipedWeapon = value; }
        public string EquipedArmor { get => equipedArmor; set => equipedArmor = value; }

        public override string ToString()
        {
            WriteLine("Name: " + name);
            WriteLine("race: " + race);
            WriteLine("Class: " + charClass);
            WriteLine("Age:   " + age);
            WriteLine("Level: " + level + "\t exeperience: " + Experience);
            WriteLine("Gold   " + gold);
            WriteLine("Health: " + health + "\t Magic: " + MagicPower);
            WriteLine("Strength: " + strength);
            WriteLine("Dexterity: " + dexterity);
            WriteLine("Intelligence" + intelligence);
            WriteLine("Constitution" + constitution);
            WriteLine("Wisdom: " + wisdom);
            WriteLine("Charimsa: " + charisma);
            WriteLine("Weapon Equiped: " + equipedWeapon);
            WriteLine("Armor Equiped: " + equipedArmor);


            return null;


        }


    }
}
