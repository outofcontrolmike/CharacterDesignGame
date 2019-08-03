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
            Console.Clear();
            ContinueToGame();
            Clear();

            WriteLine("Welcome to the very beginning of the adventure\n");
            NameGame();
            ReadKey();

            WriteLine("\nYou feel cold, and you're trying to open your eyes. You don't remember " +
                "anything recent but you know your name" + " is " + playerSheet.Name + ".  " +
                " You also remember that you are " + playerSheet.Age + " years old." + " Because of your age, you realize that you can only be a " + playerSheet.Race + ".");
                
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
