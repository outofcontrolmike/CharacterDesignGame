﻿using System;
using static System.Console;

namespace CreateCharacterMain
{

    /// <summary>
    /// Project:    Character Builder
    /// Dev:        Michael Wilson
    /// Date:       07/24/2019
    /// Purpose:    Simulates a beginning of a game where user creates a character.  -- Text based.  Version 1.0
    /// </summary>
    /// 

    // Ideas
    // Name
    // Race
    // Class
    // Age
    // Stats
    // Gold
    // Starting Weapon
    // Starting Armor
    // Other


        // Test making changes - Checkin to see if Github works

    class Program
    {
        public static string charName = "";
        private static string pRace = "";
        private static int age = 0;
        private static string pClass = "";
       

        static void Main(string[] args)
        {



            introWalkthough.askForName();
            introWalkthough.getRace();
            introWalkthough.getClass();
            introWalkthough.getStats();
            





        }// end of main




    }



}

