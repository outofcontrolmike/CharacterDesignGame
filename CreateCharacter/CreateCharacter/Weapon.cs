using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class Weapon
    {
        private string wName;
        private int attackPower;
        private string wDescription;
        private int goldValue;


        // no arg constructor
        public Weapon()
        {

        }
        //Constructor - must meet three variables
        public Weapon(string wname, int attackpower, string wdescription, int goldvalue)
        {
            this.wName = wname;
            this.attackPower = attackpower;
            this.wDescription = wdescription;
            this.goldValue = goldvalue;
        }

        //Getters & Setters
        
        public string Wname
        {
            get
            {
                return wName;
            }
            set
            {
                wName = value;
            }
        }

        public int AttackPower
        {
            get
            {
                return attackPower;
            }
            set
            {
                attackPower = value;
            }
        }

        public int Gvalue
        {
            get
            {
                return goldValue;
            }
            set
            {
                goldValue = value;
            }
        }
        public string WDescription
        {
            get
            {
                return wDescription;
            }
            set
            {
                wDescription = value;
            }
        }

        public override string ToString()
        {
            WriteLine("Weapon Name: " + wName);
            WriteLine("Weapon Attack Power: " + attackPower);
            WriteLine("Weapon Gold Value: " + goldValue);
            WriteLine("Description : " + wDescription);
            return null;
             
        }
        }
        
    }

