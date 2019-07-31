﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class introWalkthough
    {

        public static string charName = "";
        public static string pRace = "";
        private static int age = 0;
        private static string pClass = "";
        private static int level;
        private static int experience;
        private static int gold;
        private static int health;
        private static int magicPoints;
        private static int attckPower;
        private static int magicAttack;
        private static int defense;
        private static int strength = 0;
        private static int dexterity = 0;
        private static int intelligence = 0;
        private static int constitution = 0;
        private static int wisdom = 0;
        private static int charisma = 0;
      



        /// <summary>
        /// Asks user for Name
        /// </summary>
        public static void askForName()
        {
            CharacterSheet testCharacter = new CharacterSheet();
            string charName = "";
            int count = 0;
            //Character Name
            Console.WriteLine("Welcome to the create character part of the game!\n");
            Console.WriteLine("First of all, What is your name? \n ");
            charName = Console.ReadLine();

            

            while (charName == "")
            {

                if(charName == "")
                {
                    WriteLine("Enter a name for your charcter please.\n");
                    charName = Console.ReadLine();
                }

               
            }
            Console.WriteLine("\nWell done " + charName + "!");
            WriteLine("Press enter to continue");
            ReadKey();

         
         
        }

        /// <summary>
        /// Asks user to choose Race and set AGE
        /// </summary>


        public static void getRace()
        {
            int count = 1;  // control variable
            string pRace = "";  // empty place to place character race
            int age = 0;        // age variable

            // Race
            Console.WriteLine("\nThere are four races you can choose from in this program: \n");
            WriteLine("Human\n" +
                  "Elf\n" +
                  "Dwarf\n" +
                  "Hobbit\n");

            while (count == 1)  // Testing to see if user choses a race and error handles it
            {
               

                Console.WriteLine("What Race would you like to be?: \n");

                WriteLine("Type in H for Human\n" +
                       "type in E for Elf\n" +
                       "type in D for Dwarf\n" +
                       "type in HO for Hobbit\n");

                
                pRace =  ReadLine().ToUpper();
                
                WriteLine("\n");

                
                // if user enters H
                if (pRace == "H")
                {
                    int ageCounter = 1;


                    while (ageCounter == 1)
                    {

                        pRace = "Human\n";
                        WriteLine("How old do you want to be as a Human?\n" +
                            "You're allowed to be between 15-70\n");
                        WriteLine("Enter an age between 15-70: \n");

                        age = Convert.ToInt32(ReadLine());
                        WriteLine();

                        if (age < 15)
                        {
                            WriteLine("You're too young for this adventure\n");


                        }
                        if (age > 70)
                        {
                            WriteLine("You're too old for this adventure\n");

                        }
                        if (age >= 15 && age <= 70)
                        {

                            ageCounter++;
                            count++;

                        }
                    }//end While   
                }//end IF

                if (pRace == "E")
                {
                    int ageCounter = 1;


                    while (ageCounter == 1)
                    {

                        pRace = "Elf\n";
                        WriteLine("How old do you want to be as an Elf?\n");
                        WriteLine("Enter an age between 300-700: \n");

                        age = Convert.ToInt32(ReadLine());
                        WriteLine();

                        if (age < 300)
                        {
                            WriteLine("You're too young for this adventure\n");


                        }
                        if (age > 700)
                        {
                            WriteLine("You're too old for this adventure\n");

                        }
                        if (age >= 300 && age <= 700)
                        {

                            ageCounter++;
                            count++;

                        }
                    }//end While   
                }//end IF
                if (pRace == "D")
                {
                    int ageCounter = 1;


                    while (ageCounter == 1)
                    {

                        pRace = "Dwarf\n";
                        WriteLine("How old do you want to be as a Dwarf?\n");
                        WriteLine("Enter an age between 100-300: \n");

                        age = Convert.ToInt32(ReadLine());
                        WriteLine();

                        if (age < 100)
                        {
                            WriteLine("You're too young for this adventure\n");


                        }
                        if (age > 300)
                        {
                            WriteLine("You're too old for this adventure\n");

                        }
                        if (age >= 100 && age <= 300)
                        {

                            ageCounter++;
                            count++;

                        }
                    }//end While   
                }//end IF

                if (pRace == "HO")
                {
                    int ageCounter = 1;


                    while (ageCounter == 1)
                    {

                        pRace = "Hobbit\n";
                        WriteLine("How old do you want to be as a Hobbit?\n");
                        WriteLine("Enter an age between 22-90: \n");

                        age = Convert.ToInt32(ReadLine());
                        WriteLine();

                        if (age < 22)
                        {
                            WriteLine("You're too young for this adventure\n");


                        }
                        if (age > 90)
                        {
                            WriteLine("You're too old for this adventure\n");

                        }
                        if (age >= 22 && age <= 90)
                        {

                            ageCounter++;
                            count++;

                        }
                       
                        
                    }//end While   
                    
                }//end IF

                else
                {
                    WriteLine("Please enter the correct letter");
                }// error handle


            }// end While

            WriteLine("You're a " + age + " Year old " + pRace + "\n");
            WriteLine("Press Enter to Continue.\n\n");
            ReadKey();



        }

        /// <summary>
        /// Gets Class from Character
        /// </summary>
        public static void getClass()
        {

            // Class to choose from
            // Classes
            //Warrior
            //Mage
            //Theif
            //Cleric



            Console.WriteLine("Here comes the tricky part.  What class would you like to choose from?\n"

                +
                "\nThere are Five different Classes to choose from and they have unique attributes: \n" +
                "\nThe Warrior has high Strength and Constitution.  Makes a great close combat fighter.\n" +
                "\nThe Mage has high Intelligence and Wisdom.  Can be very powerful later on. \n" +
                "\nThe Theif has high Dexterity and Charaisma. Accumlates gold very easily and can sneak around. \n" +
                "\nThe Cleric has high Constitution and Wisdom. Can bear high amounts of damage and cast white magic.\n ");
               

            WriteLine("Press Enter to bring up character select");
            ReadKey();
            WriteLine(
                    "\ntype in 1 for Warrior \n" +
                      "\ntype in 2 for Mage \n" +
                      "\ntype in 3 for Theif\n" +
                      "\ntype in 4 for Cleric \n");
                 

            pClass = Console.ReadLine();


            int counter = 1;
            while (counter == 1)
            {
                string caseSwitch = pClass;

                switch (pClass)
                {
                    case "1":
                        pClass = "Warrior";
                        counter++;
                        break;
                    case "2":
                        pClass = "Mage";
                        counter++;
                        break;
                    case "3":
                        pClass = "Theif";
                        counter++;
                        break;
                    case "4":
                        pClass = "Cleric";
                        counter++;
                        break;
                }

                Console.WriteLine("\nYou decided to choose the class of " + pClass);
                counter++;

            }// end of while


        }

        /// <summary>
        /// <summary>
        /// Displays Stats based on Class
        /// </summary>
        public static void getStats()
        {
            Console.WriteLine("Your stats are listed below: \n");
            if (pClass == "Warrior")
            {
               

                //Instantiate Weapon and Armor for start
                Weapon wStWeapon = new Weapon();
                wStWeapon.Wname = "Broad Sword";
                wStWeapon.AttackPower = 20;
                wStWeapon.WDescription = "A nice broadsword to slay with";
                wStWeapon.Gvalue = 20;

                Armor wStArmor = new Armor();
                wStArmor.ArmorName = "Chain Mail";
                wStArmor.ArmorDefense = 10;
                wStArmor.ArmorDesc = "A specially crafteed suit of chain mail, passed on down by the warriors father";
                wStArmor.GoldValue = 100;

                Item startingItem = new Item();
                startingItem.ItemName = "Potion";
                startingItem.Healchar = 50;
                startingItem.Idamage = 0;
                startingItem.GoldValue = 10;
                  

                strength = 18;
                dexterity = 14;
                intelligence = 12;
                constitution = 15;
                wisdom = 13;
                charisma = 15;

                level = 1;
                experience = 0;
                gold += 100 * charisma;
                health = Convert.ToInt32(Math.Ceiling(8.5 * constitution));
                magicPoints = Convert.ToInt32(Math.Ceiling(3.5 *  wisdom));
                magicAttack = Convert.ToInt32(Math.Ceiling(1.5 * intelligence));
                attckPower = Convert.ToInt32(Math.Ceiling(4.2 * strength) + wStWeapon.AttackPower);
                defense = Convert.ToInt32(Math.Ceiling(2.1 * dexterity) + wStArmor.ArmorDefense);

                //Todo.. figure out how to bring in a starting weapon for warrior and armor



                Console.WriteLine("\n\tStrength: " + strength +
                                  "\n\tDexterity: " + dexterity +
                                  "\n\tIntelleigence: " + intelligence +
                                  "\n\tConstitution: " + constitution +
                                  "\n\tWisdom: " + wisdom +
                                  "\n\tCharisma: " + charisma +
                                  "\n\n\tCharacter Level: " + level +
                                  "\n\tExperience Points: " + experience +
                                  "\n\tGold: " + gold +
                                  "\n\n\tHealth: " + health +
                                  "\n\tMana: " + magicPoints +
                                  "\n\tMagic Attack: " + magicAttack +
                                  "\n\tAttack Power: " + attckPower +
                                  "\n\tDefense: " + defense);

                WriteLine();


                wStWeapon.ToString();
                wStArmor.ToString();
                startingItem.ToString();

            

            }

            if (pClass == "Mage")
            {
                

                Weapon StWeapon = new Weapon();
                StWeapon.Wname = "Wooden Stalve";
                StWeapon.AttackPower = 4;
                StWeapon.WDescription = "A makeshift wooden stick.";
                StWeapon.Gvalue = 4;

                Armor StArmor = new Armor();
                StArmor.ArmorName = "Leather Robe";
                StArmor.ArmorDefense = 5;
                StArmor.ArmorDesc = "An lightweight armor.";
                StArmor.GoldValue = 40;

                Item startingItem = new Item();
                startingItem.ItemName = "Potion";
                startingItem.Healchar = 50;
                startingItem.Idamage = 0;
                startingItem.GoldValue = 10;

                strength = 10;
                dexterity = 13;
                intelligence = 18;
                constitution = 10;
                wisdom = 18;
                charisma = 13;

                level = 1;
                experience = 0;
                gold += 100 * charisma;
                health = Convert.ToInt32(Math.Ceiling(6.5 * constitution));
                magicPoints = Convert.ToInt32(Math.Ceiling(8.5 * wisdom));
                magicAttack = Convert.ToInt32(Math.Ceiling(4.5 * intelligence));
                attckPower = Convert.ToInt32(Math.Ceiling(2.2 * strength) + StWeapon.AttackPower);
                defense = Convert.ToInt32(Math.Ceiling(2.1 * dexterity) + StArmor.ArmorDefense);

                //Todo.. figure out how to bring in a starting weapon for warrior and armor




                Console.WriteLine("\n\tStrength: " + strength +
                                  "\n\tDexterity: " + dexterity +
                                  "\n\tIntelleigence: " + intelligence +
                                  "\n\tConstitution: " + constitution +
                                  "\n\tWisdom: " + wisdom +
                                  "\n\tCharisma: " + charisma +
                                  "\n\n\tCharacter Level: " + level +
                                  "\n\tExperience Points: " + experience +
                                  "\n\tGold: " + gold +
                                  "\n\n\tHealth: " + health +
                                  "\n\tMana: " + magicPoints +
                                  "\n\tMagic Attack: " + magicAttack +
                                  "\n\tAttack Power: " + attckPower +
                                  "\n\tDefense: " + defense);


                StWeapon.ToString();
                StArmor.ToString();
                startingItem.ToString();

                WriteLine();
            }

            if (pClass == "Theif")
            {
                WriteLine("Theif");

                //Instantiate Weapon and Armor for start
                Weapon wStWeapon = new Weapon();
                wStWeapon.Wname = "Dirk";
                wStWeapon.AttackPower = 15;
                wStWeapon.WDescription = "A stealhty light weight knife";
                wStWeapon.Gvalue = 40;

                Armor wStArmor = new Armor();
                wStArmor.ArmorName = "Cloak";
                wStArmor.ArmorDefense = 8;
                wStArmor.ArmorDesc = "A mysterious cloak, looks like it was stolen.";
                wStArmor.GoldValue = 300;

                Item startingItem = new Item();
                startingItem.ItemName = "Potion";
                startingItem.Healchar = 50;
                startingItem.Idamage = 0;
                startingItem.GoldValue = 10;

                strength = 13;
                dexterity = 18;
                intelligence = 14;
                constitution = 11;
                wisdom = 10;
                charisma = 13;

                level = 1;
                experience = 0;
                gold += 100 * charisma;
                health = Convert.ToInt32(Math.Ceiling(6.5 * constitution));
                magicPoints = Convert.ToInt32(Math.Ceiling(3.5 * wisdom));
                magicAttack = Convert.ToInt32(Math.Ceiling(2.5 * intelligence));
                attckPower = Convert.ToInt32(Math.Ceiling(4.2 * strength) + wStWeapon.AttackPower);
                defense = Convert.ToInt32(Math.Ceiling(2.1 * dexterity) + wStArmor.ArmorDefense);

                //Todo.. figure out how to bring in a starting weapon for warrior and armor




                Console.WriteLine("\n\tStrength: " + strength +
                                  "\n\tDexterity: " + dexterity +
                                  "\n\tIntelleigence: " + intelligence +
                                  "\n\tConstitution: " + constitution +
                                  "\n\tWisdom: " + wisdom +
                                  "\n\tCharisma: " + charisma +
                                  "\n\n\tCharacter Level: " + level +
                                  "\n\tExperience Points: " + experience +
                                  "\n\tGold: " + gold +
                                  "\n\n\tHealth: " + health +
                                  "\n\tMana: " + magicPoints +
                                  "\n\tMagic Attack: " + magicAttack +
                                  "\n\tAttack Power: " + attckPower +
                                  "\n\tDefense: " + defense);

                WriteLine();


                wStWeapon.ToString();
                wStArmor.ToString();
                startingItem.ToString();
            }

            if (pClass == "Cleric")
            {
                WriteLine("Cleric");

                //Instantiate Weapon and Armor for start
                Weapon wStWeapon = new Weapon();
                wStWeapon.Wname = "Mace";
                wStWeapon.AttackPower = 18;
                wStWeapon.WDescription = "Spiked Mace used to detone with";
                wStWeapon.Gvalue = 40;

                Armor wStArmor = new Armor();
                wStArmor.ArmorName = "Plated Armor";
                wStArmor.ArmorDefense = 30;
                wStArmor.ArmorDesc = "Armor made to withstand the strongest blows.";
                wStArmor.GoldValue = 300;

                Item startingItem = new Item();
                startingItem.ItemName = "Potion";
                startingItem.Healchar = 50;
                startingItem.Idamage = 0;
                startingItem.GoldValue = 10;

                strength = 16;
                dexterity = 10;
                intelligence = 12;
                constitution = 18;
                wisdom = 17;
                charisma = 15;

                level = 1;
                experience = 0;
                gold += 100 * charisma;
                health = Convert.ToInt32(Math.Ceiling(10.5 * constitution));
                magicPoints = Convert.ToInt32(Math.Ceiling(4.5 * wisdom));
                magicAttack = Convert.ToInt32(Math.Ceiling(1.5 * intelligence));
                attckPower = Convert.ToInt32(Math.Ceiling(5.2 * strength));
                defense = Convert.ToInt32(Math.Ceiling(2.1 * dexterity));

                //Todo.. figure out how to bring in a starting weapon for warrior and armor




                Console.WriteLine("\n\tStrength: " + strength +
                                  "\n\tDexterity: " + dexterity +
                                  "\n\tIntelleigence: " + intelligence +
                                  "\n\tConstitution: " + constitution +
                                  "\n\tWisdom: " + wisdom +
                                  "\n\tCharisma: " + charisma +
                                  "\n\n\tCharacter Level: " + level +
                                  "\n\tExperience Points: " + experience +
                                  "\n\tGold: " + gold +
                                  "\n\n\tHealth: " + health +
                                  "\n\tMana: " + magicPoints +
                                  "\n\tMagic Attack: " + magicAttack +
                                  "\n\tAttack Power: " + attckPower +
                                  "\n\tDefense: " + defense);

                WriteLine();


                wStWeapon.ToString();
                wStArmor.ToString();
                startingItem.ToString();

            }



 

        }//end of get stats


    }//end of class


    }// end of namespace
       


