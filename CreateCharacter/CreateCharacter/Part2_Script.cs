using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class Part2_Script : Part1_Script
    {
        // Make ideas for the Tavern
        // Player should sit down
        // Player should look at menu
        // Menu should print Names and Descriptions from an array
        // Name
        // Description
        // Price

        // Player should be able to buy drinks
        //Limit 10

        //Three Dimensional Array's
        //Name String array
        //Desc String
        //Price long

        // should be a for loop that iterates the names
        // Also a for loop that itterates a ToString Method

      
        /// <summary>
        /// Where the main plot of chapter gets called to
        /// </summary>
        public static void Tavern()
        {
            BarDesc();
            DrinkTime();
        }

        /// <summary>
        /// Description of bar/Sit down
        /// </summary>
        public static void BarDesc()
        {
            //Start from outside
            
            WriteLine("After a little bit of a walk you finally reach the foundation of the tavern." +
                "\nThe building seems to be made by the inspiration of a log cabin, it's two stories tall." +
                "\n\nThere is a logo that displays two hands each holding a mug and they are bumping together to" +
                "simulate a cheers for good times.\n" +
                "Under the logo the name of the tavern is displayed -- " +
                "\n\nFRIENDS INN");
            WriteLine("You push the heavy oak doors open and make your entrance into the bar.");
            ReadKey(false);
            OpenDoors();
            



            ReadKey(false);
        }// end BarDesc

        public static void OpenDoors()
        {
            Clear();

            //Testing below
            CharacterSheet.playerSheet.Race = "Hobbit";
            string caseSwitch = CharacterSheet.playerSheet.Race;

            switch (caseSwitch)
            {
                case "Human":
                    WriteLine("Everyone raises their mugs to your entrance." +
                        " You confidently stride over to the main seating and take a seat down.");
                    break;
                case "Elf":
                    WriteLine("Most of the people in the tavern are giving you a weird look." +
                        " You notice that there are no other elves in the tavern." +
                        "\nYou awkwardly walk over to the main seating of the bar and take a seat.");
                    break;
                case "Dwarf":
                    WriteLine("As you bounce your way in everyone in the tavern gives you a nice wave" +
                        " seems like your race is respected around here. You notice there are other dwarves" +
                        " having a good time at a table, however you decide to go to the bar to figure out" +
                        " what the tavern has to offer.");
                    break;
                case "Hobbit":
                    WriteLine("Right when you walk in everyone seems to be happy that you're around." +
                        " People love the hospitallity and friendliness of Hobbits. You walk up to the main bar" +
                        " to see what what drinks are offered, you're in need of one.");
                        break;

            }
        }//End BartenderIntro

        /// <summary>
        /// This is where a menu will be called to
        /// </summary>
        public static void DrinkTime()
        {
            // One method should be called here that populates a list
            WriteLine("Would you like to view the simple menu or the the detailed menu?\n" +
                "--The simple menu is one page and shows everything but the descriptions." +
                "\n--The Detailed menu shows each beverage one page at a time.");

            BeverageString();
        }// end DrinkTime

        /// <summary>
        /// This will take from the 3 array's below and form an ouput menu
        /// </summary>
        public static void BeverageString()
        {
            string[] bNames = new string[] { "Water", "Lager", "Mead", "Eldberberry Wine", "Red Wine", "Old Town IPA" };

            int[] bPrices = new int[] { 3, 10, 20, 30, 50, 40 };

            int[] bABV = new int[] { 0, 4, 7, 11, 14, 8 };

            string[] bDesc = new string[] {"Delicious Well Water", "A fine well bodied lager", "Sweet Honey mead made locally",
            "Healthy wine made from local berries", "Imported Red Wine", "India Pale Ale - You've never heard of such a thing"};
            

            Clear();

            //Somehow incorporate a for loop that access each elements in array
            for(int i = 0; i < bNames.Length; i++)
            {
                WriteLine("-------------------------------------------------------------");
                WriteLine(bNames[i] + "\t%" + bABV[i] + "\t$" + bPrices[i] +
                    "\n\nDescription: " + bDesc[i]);
                ReadKey(false);
               

             
            }
            WriteLine("-------------------------------------------------------------");
            WriteLine("Any of this Interesting?");
            WriteLine("Press Enter to go to choose a selection.");
            ReadKey(false);
        }//end BeverageString

        public static void chooseBeverage()
        {

        }


    }
}
