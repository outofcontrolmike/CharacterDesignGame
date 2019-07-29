using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    /// <summary>
    /// Item either hurts or heals
    /// </summary>
    class Item
    {
        private string itemName = "";
        private int healChar = 0;
        private int iDamage = 0;
        private int goldValue = 0;


        // no arg constructor
        public Item()
        {
            
        }

        // Constructor for two fields
        public Item(string itemname, int healchar, int idamage, int goldvalue)
        {
            this.itemName = itemname;
            this.healChar = healchar;
            this.iDamage = idamage;
            this.goldValue = goldvalue;
        }

        //Getters and setters

            public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                value = itemName;
            }
        }// end ItemName
        
        public int Healchar
        {
            get
            {
                return healChar;
            }
            set
            {
                value = healChar;
            }
        }// get heal

        public int Idamage
        {
            get
            {
                return iDamage;
            }
            set
            {
                value = iDamage;
            }
        }// end iDamage

        //

        public static void healCharacter(string itemName, int healChar)
        {
            WriteLine("You used " + itemName + " to heal yourself by " + healChar + " points");
        }// heal character

        public static void damageEnemy(string itemName, int iDamage)
        {
            WriteLine("You used " + itemName + " to damage the enemy by " + iDamage + " points");
        }// end damage enemy

        public static void itemWorth(string itemName, int itemValue)
        {
            WriteLine(itemName + " is worth " + itemValue + " gold");

        }//end item worth
    }


}
