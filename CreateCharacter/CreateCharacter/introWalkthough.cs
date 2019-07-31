using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class introWalkthough
    {

        public static string charName = "";
        private static string pRace = "";
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


        //control variables
        private static int count = 1;
        

        public static Weapon wStWeapon = new Weapon();
        public static Armor wStArmor = new Armor();
        public static Item startingItem = new Item();

        public static Weapon StWeapon = new Weapon();
        public static Armor StArmor = new Armor();

        public static MagicSpell mageSpell = new MagicSpell();
      




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

                    pRace = "Human\n";
                    WriteLine("How old do you want to be as a Human?\n" +
                        "You're allowed to be between 15-70\n");
                    while (ageCounter == 1)
                    {

                        try
                        {
                            WriteLine("Enter an age between 15-70: \n");
                            age = Convert.ToInt32(ReadLine());
                            WriteLine("\n");
                        }
                        catch (System.FormatException)
                        {
                            WriteLine("Be sure to actually use numbers.\n");


                        }// End Try Catch for age


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
                            count++;
                            ageCounter++;

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
                        try
                        {
                            WriteLine("Enter an age between 300-700: \n");
                            age = Convert.ToInt32(ReadLine());
                            WriteLine("\n");
                        }
                        catch (System.FormatException)
                        {
                            WriteLine("Be sure to actually use numbers.\n");


                        }// End Try Catch for age

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

                        try
                        {
                            WriteLine("Enter an age between 100-300: \n");
                            age = Convert.ToInt32(ReadLine());
                            WriteLine("\n");
                        }
                        catch (System.FormatException)
                        {
                            WriteLine("Be sure to actually use numbers.\n");


                        }// End Try Catch for age

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

                        try
                        {
                            WriteLine("Enter an age between 22-90: \n");
                            age = Convert.ToInt32(ReadLine());
                            WriteLine("\n");
                         
                        }
                        catch (System.FormatException)
                        {
                            WriteLine("Be sure to actually use numbers.\n");


                        }// End Try Catch for age

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
                            pRace = "Hobbit";
                        }
                       
                        
                    }//end While   
                    
                }//end IF



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
                "\nThere are Five different Classes to choose from and they have unique attributes: \n");

                 ReadKey();
                WriteLine("\nThe Warrior has high Strength and Constitution.  Makes a great close combat fighter.\n" +
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
                    default:
                        WriteLine("\nSince you didn't enter in a value, we assumed you wanted to be a Warrior.  If you're not happy about this, " +
                            "\nThere will be a chance to reset the intro");
                        pClass = "Warrior";
                        counter++;
                        break;
                }// end case statement

                

            }// end of while
            Console.WriteLine("\nYou decided to choose the class of " + pClass);
            

        }

        /// <summary>
        /// <summary>
        /// Displays Stats based on Class
        /// </summary>
        public static void getStats()
        {
            WriteLine();
            Console.WriteLine("Press Enter to view your stats for the " + pClass +"\n");
           
            if (pClass == "Warrior")
            {
               

            
              
                wStWeapon.Wname = "Broad Sword";
                wStWeapon.AttackPower = 20;
                wStWeapon.WDescription = "A nice broadsword to slay with";
                wStWeapon.Gvalue = 20;

             

               
                wStArmor.ArmorName = "Chain Mail";
                wStArmor.ArmorDefense = 10;
                wStArmor.ArmorDesc = "A specially crafteed suit of chain mail, passed on down by the warriors father";
                wStArmor.GoldValue = 100;


                // Instantiate item
           
                startingItem.ItemName = "Potion";
                startingItem.Healchar = 50;
                startingItem.Idamage = 0;
                startingItem.GoldValue = 10;


                // settings variables
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

                statsDesc();
                ReadKey();
                getEquipment();
            

            }

            if (pClass == "Mage")
            {
                

                
                wStWeapon.Wname = "Wooden Stalve";
                wStWeapon.AttackPower = 4;
                wStWeapon.WDescription = "A makeshift wooden stick.";
                wStWeapon.Gvalue = 4;

               
                wStArmor.ArmorName = "Leather Robe";
                wStArmor.ArmorDefense = 5;
                wStArmor.ArmorDesc = "An lightweight armor.";
                wStArmor.GoldValue = 40;

          
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

                buildMageSpell();
                
                statsDesc();
                ReadKey();
                getEquipment();
            }

            if (pClass == "Theif")
            {
                WriteLine("Theif");

                //Instantiate Weapon and Armor for start
               
                wStWeapon.Wname = "Dirk";
                wStWeapon.AttackPower = 15;
                wStWeapon.WDescription = "A stealhty light weight knife";
                wStWeapon.Gvalue = 40;

                wStArmor.ArmorName = "Cloak";
                wStArmor.ArmorDefense = 8;
                wStArmor.ArmorDesc = "A mysterious cloak, looks like it was stolen.";
                wStArmor.GoldValue = 300;

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


                statsDesc();
                ReadKey();
                getEquipment();
            }

            if (pClass == "Cleric")
            {
                WriteLine("Cleric");

                //Instantiate Weapon and Armor for start
               
                wStWeapon.Wname = "Mace";
                wStWeapon.AttackPower = 18;
                wStWeapon.WDescription = "Spiked Mace used to detone with";
                wStWeapon.Gvalue = 40;

               
                wStArmor.ArmorName = "Plated Armor";
                wStArmor.ArmorDefense = 30;
                wStArmor.ArmorDesc = "Armor made to withstand the strongest blows.";
                wStArmor.GoldValue = 300;

        
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


                statsDesc();
                ReadKey();
                getEquipment();

            }



 

        }//end of get stats

        /// <summary>
        /// Get's Equipment Details 
        /// </summary>
        private static void getEquipment()
        {

            WriteLine();

            ReadKey();
            wStWeapon.ToString();

            ReadKey();
            wStArmor.ToString();

            ReadKey();
            WriteLine("Starting Item below.\n");
            WriteLine("");
            startingItem.ToString();

        }
        
        /// <summary>
        /// Gets stats Description
        /// </summary>
        private static void statsDesc()
        {
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

        /// <summary>
        /// sets the mage's build stuff
        /// </summary>
        private static void buildMageSpell()
        {
            mageSpell.Name = "Fire Ball";
            mageSpell.MagicCost = 20;
            mageSpell.MDesc = "A scrorching ball of fire that can incenerate enenmies.";
            mageSpell.magicDamage = 20;
            mageSpell.MHeal = 0;
            mageSpell.RequiredLevel = 1;

            mageSpell.ToString();


        }

    }//end of class

    }// end of namespace
       


