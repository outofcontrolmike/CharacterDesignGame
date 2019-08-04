using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace CreateCharacterMain
{
    class Part1_Script : IntroPlot
    {

        private static string gameName = "Unknown Quest";
        public static void FirstPart()
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
            GetOutOfRope();
        }
        /// <summary>
        /// Gets out of rope
        /// </summary>
        /// 
        public static void SecondPart()
        {
            Clear();
            WriteLine("Now that you're out of the rope you decided to stand up and observe the cave.");
            WriteLine("From what you can tell, you're at the back of a cave. The fire pit you are by looks abandoned.  " +
                "There is no trace of whoever brought you here, so you decide to leave the cave");
            Console.WriteLine("Press Enter to procced.");
            ReadKey(false);
            Clear();
            WriteLine("You stumble out of the cave and find that you're at the top of a small hill.  You can see a " +
                "rugged path through some weak woods that is followed by a very thick swamp and in the other direction there is a fairly" +
                " used path.");
            WriteLine("You decide to look up at the sun to figure out how much daylight you have and to figure out your directions. "
                + "You reailze the Swamp faces North and the nicer trail is to the West.");
            ReadKey(false);
            Clear();
            SwampOrWest();
            West();
            StrangerEncounter();





        }
        public static void GetOutOfRope()
        {
            Clear();
            if (playerSheet.CharClass == "Warrior")
            {
                WriteLine("You use your imense strength to break out of the rope.");
            }
            if (playerSheet.CharClass == "Mage")
            {
                WriteLine("Your intelligence makes you think outside of the box. You come up with a quick way" +
                    " to combust the area around the rope into fire.  Once the rope has burned just enough, you rip out of the bondage");
            }
            if (playerSheet.CharClass == "Theif")
            {
                WriteLine("Since you're a Theif you already got yourself out of the bondage.");
            }
            if (playerSheet.CharClass == "Cleric")
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


            if (choice == "y")
            {
                WriteLine("\nEnter a new name, otherwise press the enter key: \n");
                string newName = Console.ReadLine();
                gameName = newName;
                Clear();
                
                WriteLine("\nYou've decided to name the game: " + gameName.ToUpper());
               
                
                
            }
            else
            {
                WriteLine("\nWelcome to " + gameName.ToUpper());

            }



        }// end Rename Game
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
                ReadKey(false);
                Clear();
            }
        }// end ContinueToGame

        public static void SwampOrWest()
        {
            WriteLine("Which direction would you like to go?  Press 's' for swamp or 'w' for west: ");
            string choice = ReadLine();
            choice.ToUpper();

            if (choice == "S")
            {
                Swamp();
            }

            if (choice == "W")
            {
                Clear();
                WriteLine("You decide to head west and take the safe route.");
            }
        }// end SwampOrWest


        public static void Swamp()
        {
            Clear();
            WriteLine("You decide that the swamp looks like a neat place to explore, maybe you'll find out" +
                " more about why you woke up in a cave.\n" +
                "You had no trouble bouldering down the small bluff.  You notice there's an even bigger cave entrance behind you " +
                "facing the south, however it's boarded up.  You press onward on the rugged trail towards the swamp.\n");
            ReadKey(false);
            Clear();
            WriteLine("After about a half mile down the trail, it ends to the entrance of a gross looking swamp." +
                " You hear something that sounds like it's popping and you realize there are bubbles coming out of the swamp water" +
                " near you.");
            ReadKey();
            CheckBubbles();
            WriteLine("After coughing and gagging from the bog fog you realize you made it back to the cave you awoke from." +
                "  You end up heading down the fairly used path, towards the west.");
        }// end Swamp Scenario

        public static void CheckBubbles()
        {
            Clear();
            if (playerSheet.Wisdom >= 14)
            {
                WriteLine("Your Wisdom knows better than to stick your hand into a bubbling part of a swamp." +
                    " You decide to wait a minute or two.\n");

                if (playerSheet.Intelligence >= 15)
                {
                    WriteLine("You're aware that swamps sometimes produce bog gas which is a mixture of natural earth gasses." +
                        " You know best to turn back and quit wasting your time.");
                }
                else
                {
                    WriteLine("You're not sure why the swamp is bubbiling but you know not to get involved.  You decide to turn back.");
                }


            }// end if
            else
            {

                WriteLine("You seem intrigured by this, you've never seen anything like this.");
                WriteLine("Do you want to venture into the swamp and see what this is? Enter 1 for yes, press any other key to leave" +
                    " the swamp");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    int damage = 10;
                    int updatedHealth = playerSheet.TempHealth - damage;

                    WriteLine("You take a few steps into the swamp.  It is very hard to move through and it's suprisingly warm." +
                        "  As you walk closer to the bubbles you realize your about knee deep in the swamp." +
                        "  You notice an awful stench coming from the bubbles, it's worse than any farm work you've delt with" +
                        "  Your knees start to buckle and you start gagging.  You loose your footing and bang your knee into a small " +
                        "structure in the swamp, that really hurt.");
                    WriteLine("You lost " + damage + (" health points.") + " " +
                        "Your current health is " + (updatedHealth) + "/" + playerSheet.Health);

                }// end

                WriteLine("You decided to leave the swamp.");

                ReadKey(false);

            }// end else
        }// end check bubbles

        public static void West()
        {
            Clear();
            WriteLine("You've been walking along this path now for about a mile, the scenery is a lightwooded area" +
                " that looks like is fading away.  Something smells very odd close by, you happen to notice a corpse" +
                " lying on it's back.  You can't tell what sex it is, it looks like it was eaten alive, by you also can't tell" +
                " what from.  ");
            WriteLine("Are you interested in checking the corpse?  Checking corpses is a thing to keep in mind " +
                " since you can salvage useable things from them. ");
            CheckCorpse();
           

        }// end West

        public static void CheckCorpse()
        {

            WriteLine("Press 1 if you are interested in checking the corpse for valuables: ");
            int choice = Convert.ToInt32(ReadLine());
            
            if(choice == 1)
            {
                Clear();
                if(playerSheet.Race == "Human")
                {
                    WriteLine("You happen to spot something shinny beside the corpse.  You realize it's a memento that you " +
                        " completely forgot about.  You grab the sliver ring packed with an amythest.");
                }
                if(playerSheet.Race == "Elf")
                {
                    WriteLine("You found your brooch that you've been missing.  You've had this for Many years.");
                }
                if (playerSheet.Race == "Dwarf")
                {
                    WriteLine("Out of the corner of your eye you notice a leather bag right next to the corpse." +
                        " You quickly snatch it and open it to find a small batch of gold that is worth 100.");
                    playerSheet.Gold += 100;
                }
                if(playerSheet.Race == "Hobbit")
                {
                    WriteLine("You notice a small little journal that looks like was used for notes.  You grabbed and opened it up" +
                        " to find that there are recipies that you could be using for all of your future events.  " +
                        "You stash this away and save it for later.");
                }

                WriteLine("Press any key to contiune.");
                ReadKey(false);
            }// end check Corpse
            
        }

        public static void StrangerEncounter()
        {
            Clear();
            WriteLine("You head down the path for about another half mile and you realize the woods are becoming less abundant" +
                ".  You eventually break out of the woods into a huge valley.");
        }
    }


}
