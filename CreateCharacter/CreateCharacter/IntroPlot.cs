using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class IntroPlot : IntroWalkthough
    {
        // Create a method for the very first part

        public static void TheWakeUp()
        {
            WriteLine("\n\n\n\n\n\n\n");
            WriteLine("Welcome to the very beginning of the adventure\n");
            ReadKey();
     
            WriteLine("You feel cold, and you're trying to open your eyes.  You don't remember " +
                " anything recent but you know your name" + " is " + playerSheet.Name + ".  " +
                " You also remember that you are " + playerSheet.Age + " years old.");
            WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
