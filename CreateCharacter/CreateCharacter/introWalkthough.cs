using System;
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
            string charName;
            //Character Name
            Console.WriteLine("Welcome to the create character part of the game!\n");

            Console.WriteLine("First of all, What is your name \n ");
            charName = Console.ReadLine();

            Console.WriteLine("\nWell done " + charName + "!");
        }

        /// <summary>
        /// Asks user to choose Race and set AGE
        /// </summary>


        public static void getRace()
        {
            int count = 1;
            string pRace = "";
            int age = 0;

            while (count == 1)
            {
                // Race
                Console.WriteLine("\nThere are four races you choose from in this program: \n" +
                       "type in H for Human\n" +
                       "type in E for Elf\n" +
                       "type in D for Dwarf\n" +
                       "type in HO for Hobbit\n");
                Console.WriteLine("What Race would you like to be?: \n");

                pRace = Console.ReadLine();
                Console.WriteLine();

                if (pRace == "H")
                {
                    int ageCounter = 1;


                    while (ageCounter == 1)
                    {

                        pRace = "Human\n";
                        WriteLine("How old do you want to be as a Human?\n" +
                            " You're allowed to be between 15-70\n");
                        WriteLine("Enter an age between 15-70: \n");

                        age = Convert.ToInt32(ReadLine());
                        WriteLine();

                        if (age < 15)
                        {
                            WriteLine("You're too young for this adventure");


                        }
                        if (age > 70)
                        {
                            WriteLine("You're too old for this adventure");

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
                            WriteLine("You're too young for this adventure");


                        }
                        if (age > 700)
                        {
                            WriteLine("You're too old for this adventure");

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
                            WriteLine("You're too young for this adventure");


                        }
                        if (age > 300)
                        {
                            WriteLine("You're too old for this adventure");

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
                            WriteLine("You're too young for this adventure");


                        }
                        if (age > 90)
                        {
                            WriteLine("You're too old for this adventure");

                        }
                        if (age >= 22 && age <= 90)
                        {

                            ageCounter++;
                            count++;

                        }

                        
                    }//end While   
                    WriteLine("Enter a correct Age");
                }//end IF


            
                




            }// end While

            WriteLine("You're a " + age + " Year old " + pRace);
            WriteLine("Press Enter");
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
            //Druid


            Console.WriteLine("Here comes the tricky part.\n"

                + "\nWhat class would you like to choose from? \n " +
                "\nThere are Five different Classes to choose from and they have unique attributes: \n" +
                "\nThe Warrior has high Strength and Constitution.  Makes a great close combat fighter.\n" +
                "\nThe Mage has high Intelligence and Wisdom.  Can be very powerful later on. \n" +
                "\nThe Theif has high Dexterity and Charaisma. Accumlates gold very easily and can sneak around. \n" +
                "\nThe Cleric has high Constitution and Wisdom. Can bear high amounts of damage and cast white magic.\n " +
                "\nThe Druid has High Intelligence and Wisdom.  They are bound to nature and can manipuate elements around them.  \n");

            WriteLine("Press Enter to bring up character select");
            ReadKey();
            WriteLine(
                    "\ntype in 1 for Warrior \n" +
                      "\ntype in 2 for Mage \n" +
                      "\ntype in 3 for Theif\n" +
                      "\ntype in 4 for Cleric \n" +
                      "\ntype in 5 for Druid \n");

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
                    case "5":
                        pClass = "Druid";
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


                wStWeapon.ToString();
                wStArmor.ToString();
                startingItem.ToString();
                

            }

            if (pClass == "Mage")
            {

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
                attckPower = Convert.ToInt32(Math.Ceiling(2.2 * strength));
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
            }

            if (pClass == "Theif")
            {
                WriteLine("Theif");

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
                attckPower = Convert.ToInt32(Math.Ceiling(4.2 * strength));
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
            }

            if (pClass == "Cleric")
            {
                WriteLine("Cleric");

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
            }

            if (pClass == "Druid")
            {
             

                strength = 12;
                dexterity = 13;
                intelligence = 18;
                constitution = 13;
                wisdom = 18;
                charisma = 10;

                level = 1;
                experience = 0;
                gold += 100 * charisma;
                health = Convert.ToInt32(Math.Ceiling(8.5 * constitution));
                magicPoints = Convert.ToInt32(Math.Ceiling(3.5 * wisdom));
                magicAttack = Convert.ToInt32(Math.Ceiling(1.5 * intelligence));
                attckPower = Convert.ToInt32(Math.Ceiling(4.2 * strength));
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
            }//end druid

        }//end of get stats

        // things to do
            // Set up an Equiped Weapon
            // Set up an Equiped Armor
            // Set up 

    }//end of class


    }// end of namespace
       


