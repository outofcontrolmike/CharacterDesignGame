using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{

    
    class IntroPlot : IntroWalkthough
    {

        private static string gameName = "Unknown Quest";
        // Create a method for the very first part

        public static void TheWakeUp()
        {
            Part1_1();

        }

        public static void Part1_1()
        {
            firstPar();
            secondPar();
            

            
        }

        public static void secondPar()
        {
            Clear();
            WriteLine("Now that you're out of the rope you decided to stand up and observe the cave.");
            WriteLine("From what you can tell, you're at the back of a cave. The fire pit you are by looks abandoned.  " +
                "There is no trace of whoever brought you here, so you decide to leave the cave");
            Console.WriteLine("Press Enter to procced.");
            ReadKey(false);
            Clear();
            WriteLine("You stumble out of the cave and find that you're at the top of a small hill.  You can see a " +
                " rugged path through some weak woods that is followed by a very thick swamp and in the other direction there is a fairly " +
                " used path.");
            WriteLine("You decide to look up at the sun to figure out how much daylight you have and to figure out your directions. "
                + "You reailze the Swamp faces North and the nicer trail is to the West.");
            ReadKey(false);
            Clear();



        }
        public static void firstPar()
        {


            Clear();
            ContinueToGame();
            Clear();

            NameGame();
            ReadKey();

            WriteLine("\nWelcome to the very beginning of the adventure\n");
            WriteLine("\nYou feel cold, and you're trying to open your eyes. You don't remember " +
                "anything recent but you know your name" + " is " + playerSheet.Name + ".  " +
                " You also remember that you are " + playerSheet.Age + " years old." + " Because of your age, you realize that you can only be a " + playerSheet.Race + ".");
            WriteLine("\nYou finally managed to open your eyes you notice a quaint fire pit in front of you." +
                " Your hands are tied together, it's like someone caputred and drugged you.");
            WriteLine("You know you need to get out of this place, good thing you are a " + playerSheet.CharClass + ".  You know just the trick to get out of this situation!");
            ReadKey(false);
            getOutOfRope();
        }
        /// <summary>
        /// Gets out of rope
        /// </summary>
        public static void getOutOfRope()
        {
            Clear();
            if(playerSheet.CharClass == "Warrior")
            {
                WriteLine("You use your imense strength to break out of the rope.");
            }
            if(playerSheet.CharClass == "Mage")
            {
                WriteLine("Your intelligence makes you think outside of the box. You come up with a quick way" +
                    " to combust the area around the rope into fire.  Once the rope has burned just enough, you rip out of the bondage");
            }
            if(playerSheet.CharClass == "Theif")
            {
                WriteLine("Since you're a Theif you already got yourself out of the bondage.");
            }
            if(playerSheet.CharClass == "Cleric")
            {
                WriteLine("The bondage is so tight aroudn your hands, it's very hard for you to get out.  Usually in tight situations" +
                    " you send a prayer off.  You go into deep mediation and relay a connection with your entity and the bondage starts to loosen.  " +
                    "You're safely able break loose");
            }
            ReadKey();
        }
        public static void NameGame()
        {
            
            WriteLine("Would you like to rename this game? Enter y if so\n");
            string choice = Console.ReadLine();

           
            if(choice == "y")
            {
                WriteLine("Enter a new name, otherwise press the enter key: ");
                string newName = Console.ReadLine();
                gameName = newName;
                WriteLine("You've decided to name the game: \t\t" + gameName.ToUpper());
                Clear();

            }
            else
            {
                WriteLine("\nWelcome to " + gameName.ToUpper());
                
            }
           
            

        }
        public static void ContinueToGame()
        {
            Console.Clear();
            WriteLine("Are you happy with your decisions?  If not type n now if you want to restart the set up");
            string choice = ReadLine();

            if (choice.ToUpper() == "N")
            {
                Console.Beep();
                Console.Clear();
                IntroWalkthough.AskForName();
                IntroWalkthough.GetRace();
                IntroWalkthough.GetClass();
                IntroWalkthough.GetStats();
             
                Clear();
            }

            else
            {

                Console.WriteLine("Press enter to continue to Main game.");
                ReadKey();
                Clear();
            }
            }

            
        }
    }
