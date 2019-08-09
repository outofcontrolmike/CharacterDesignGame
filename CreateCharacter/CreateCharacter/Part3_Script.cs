using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CreateCharacterMain
{
    class Part3_Script: Part2_Script
    {

        private static Enemies Bandit = new Enemies();


        /// <summary>
        /// Method that controls the chapter
        /// </summary>
        public static void Battle()
        {
            //Testing
            CharacterSheet.playerSheet.Gold = 1000;
            setEnemy();
            StoryBeforeBattle();


        }//end Battle



        /// <summary>
        /// Programs the functionallity of the battle
        /// </summary>
        public static void mapBattle()
        {

        }//end mapBattle

        /// <summary>
        /// Sets the enemy up
        /// </summary>
        public static void setEnemy()
        {
            Enemies Bandit = new Enemies();

            Bandit.Name = "Jamahl";
            Bandit.Health = 20;
            Bandit.TempHealth = 20;
            Bandit.Mana = 0;
            Bandit.TempMana = 20;
            Bandit.AttackPower = 0;
            Bandit.Defense = 40;
            Bandit.GainedExp = 1400;
            Bandit.GainedGold = 100;
        }//end setEnemy

        public static void StoryBeforeBattle()
        {
            Clear();
            WriteLine("As you walk downstairs you see that this tavern also does well" +
                " as a breakfast place, there are many groups of people participating in breakfast.");
            WriteLine("\nYou take a seat at the bar and a young waitress comes to your attention right away.");
            WriteLine("\n'Hey, you stayed here over night, breakfast is included in your stay." +
                "\nDoes a country skillet and coffee sound good for you.?'");
            WriteLine("You sit there with a grin on your face and defintiley agree with" +
                " the breakfast option.");
            ReadKey(false);
            Clear();
            WriteLine("Over some time you go over a few cups of coffee." +
                "\nYou learn that the town is named Desolation and that there" +
                " are a lot of options for work to be done and even a wanted job list" +
                " that's posted on one of the tavern walls.");
            WriteLine("\nEventually your breakfast comes out and it smells so good." +
                " It's got: " +
                "\n" +
                "________" +
                "\nPotatoes" +
                "\nPeppers" +
                "\nOnions" +
                "\nWildMushrooms" +
                "\nTomatoes" +
                "\nSausage" +
                "\nEggs");
            WriteLine("\nYou savor the food for as long as you can and you greatly appreciate the breakfast." +
                " It's just want you needed.");
            ReadKey(false);
            Clear();
            WriteLine("You finish your plate the the waitress takes cleans up after you." +
                " Your service was so good, maybe you should leave a tip...");
            LeaveTip();
            Clear();
            WriteLine("You see that there's only one other group left so it's almost scarce at the tavern.");
            WriteLine("You decide to go back up to your room to gather your things and start" +
                " on your adventure to see town.");
            WriteLine("\nRight as your about to leave you hear yelling from downstairs.");
            WriteLine("");
            WriteLine(Bandit.Name);
            ReadKey(false);


        }//end StoryBeforeBattle

        public static void LeaveTip()
        {
            Clear();
            WriteLine("You currently have " + playerSheet.Gold + " gold.");
            WriteLine("Enter the amount of gold that you want to tip.");
            int tip = Convert.ToInt32(ReadLine());

            
            if (playerSheet.Gold > tip)
            {
                if (tip > 0)
                {
                    WriteLine("You decided to leave " + tip + " gold for a tip.");
                    playerSheet.Gold -= tip;

                }// Tipped

                if(tip == 0)
                {
                    WriteLine("You didn't want to leave a tip.");
                }

                if(tip < 0)
                {
                    WriteLine("You're trying to break the program.");
                }
            }// end if
            if(tip > playerSheet.Gold)
            {
                WriteLine("You don't have enough money to tip. Missed your chance.");
            }
            
            ReadKey(false);
        }// end LeaveTip


    }//end Part3
}
