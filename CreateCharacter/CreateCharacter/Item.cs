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

        public static void healCharacter(string itemName)
        {
            WriteLine("You used " + itemName + "")
        }

    }


}
