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
        private int wValue;


        // no arg constructor
        public Weapon()
        {

        }
        //Constructor - must meet three variables
        public Weapon(string wname, int attackpower, string wdescription, int wvalue)
        {
            this.wName = wname;
            this.attackPower = attackpower;
            this.wDescription = wdescription;
            this.wValue = wvalue;
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

        public int WValue
        {
            get
            {
                return wValue;
            }
            set
            {
                wValue = value;
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
            WriteLine("Weapon Name:         " + wName);
            WriteLine("Weapon Attack Power: " + attackPower);
            WriteLine("Weapon Gold Value:   " + wValue);
            WriteLine("Description : \n" + wDescription);
            return null;
             
        }
        }
        
    }

