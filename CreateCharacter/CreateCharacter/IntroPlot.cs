using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class IntroPlot : IntroWalkthough
    {
        // Create a method for the very first part

        public static void TheWakeUp()
        {
            Console.Clear();
            ContinueToGame();

            WriteLine("Welcome to the very beginning of the adventure\n");
            ReadKey();
     
            WriteLine("You feel cold, and you're trying to open your eyes.  You don't remember " +
                " anything recent but you know your name" + " is " + playerSheet.Name + ".  " +
                " You also remember that you are " + playerSheet.Age + " years old.");
            WriteLine("-----------------------------------------------------------------------------");
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
