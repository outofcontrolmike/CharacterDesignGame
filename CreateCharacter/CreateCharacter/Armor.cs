using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCharacterMain
{
    /// <summary>
    /// Class for building Armor objects that characters can use
    /// </summary>
    class Armor
    {
        // What will Armor have?
        private string armorName = "";
        private int armorDefense = 0;
        private string armorDesc = "";
        private int goldValue = 0;

        // Constructor for Armor Objec

        // no arg constructor - so we can instantiate
        public Armor()
        {

        }

        //Constructor Expecting all fields
        public Armor(string armorname, int armordefense, string armordesc, int goldvalue)
        {
            this.armorName = armorname;
            this.armorDefense = armordefense;
            this.armorDesc = armordesc;
            this.goldValue = goldvalue;
            
        }

        // Getters and Setter methods

        // Work like a constructor

            // Get returns a value - Gets it
            // Set sets a value - sets a value

        public string ArmorName
        {
           get
            {
                return armorName;
            }
            set
            {
                armorName = value;
            }
        }// end ArmorName

        public int ArmorDefense
        {
            get
            {
                return armorDefense;
            }
            set
            {
                value = armorDefense;
            }
        }// end Armor Defense

        // build getter and setter for armor desc

        public string ArmorDesc
        {
            get
            {
                return armorDesc;
            }

            set
            {
                value = armorDesc;
            }
        }// end Armor Description

        public int GoldValue
        {
            get
            {
                return goldValue;
            }
            set
            {
                value = goldValue;
            }
        }
    }// end class
}// end namepsace
