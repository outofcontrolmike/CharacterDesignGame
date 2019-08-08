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
        }// end BarDesc

        /// <summary>
        /// This is where a menu will be called to
        /// </summary>
        public static void DrinkTime()
        {
            // One method should be called here that populates a list
        }// end DrinkTime

        /// <summary>
        /// This will take from the 3 array's below and form an ouput menu
        /// </summary>
        public static void BeverageString()
        {
            //Somehow incorporate a for loop that access each elements in array
            for(int i = 0; i <= 5; i++)
            {
                ReadKey(false);
            }
        }//end BeverageString
        
        /// <summary>
        /// Array of Beverage Names
        /// </summary>
        public static void BeverageNames()
        {

        }//end BeverageNames

        /// <summary>
        /// Array for descriptions
        /// </summary>
       public static void BeverageDescriptions()
        {

        }//end Beverage Descriptions

        /// <summary>
        /// Array for prices
        /// </summary>
        public static void BeveragePrices()
        {

        }//end BeveragePrices

    }
}
