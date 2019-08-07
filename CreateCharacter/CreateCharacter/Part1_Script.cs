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
            NameGame();
            Clear();

            WriteLine("\nWelcome to the very beginning of the adventure\n");
            ReadKey(false);
            Clear();
            WriteLine("\nYou feel cold, and you're trying to open your eyes. You don't remember " +
                "anything recent but you know your name is " + playerSheet.Name + "." +
                "\nYou also remember that you are " + playerSheet.Age + " years old." + " " +
                "Because of your age, you realize that you can only be a " + playerSheet.Race + ".");
            WriteLine("\nYou finally managed to open your eyes you notice a smouldered fire pit in front of you." +
                " Your hands are tied together, it's like someone captured and drugged you.\n");
            WriteLine("You know you need to get out of this place, good thing you are a " + playerSheet.CharClass + ". " +
                "You know just the trick to get out of this situation!");
            ReadKey(false);
            GetOutOfRope();
        }// end FirstPart


        /// <summary>
        /// Let's user re enter set up
        /// </summary>
        public static void ContinueToGame()
        {
            Clear();
            WriteLine("Are you happy with your decisions?  If not type n now if you want to restart the set up\n");
            string choice = ReadLine();

            if (choice.ToUpper() == "N")
            {
                Beep();
                Clear();
                AskForName();
                GetRace();
                GetClass();
                GetStats();

                Clear();
            }

            else
            {


                ReadKey(false);
                Clear();
            }
        }// end ContinueToGame

        public static void NameGame()
        {

            WriteLine("Would you like to rename this game? Enter Y if so\n");
            string choice = ReadLine();


            if (choice.ToUpper() == "Y")
            {
                WriteLine("\nEnter a new name, otherwise press the enter key:\n");
                string newName = ReadLine();

                gameName = newName;
                Clear();

                WriteLine("\nYou've decided to name the game:\n" + gameName.ToUpper());
                ReadKey(false);
                Clear();



            }
            else
            {
                Clear();
                WriteLine("\nWelcome to " + gameName.ToUpper());
                ReadKey(false);
                Clear();
            }



        }// end Rename Game

        /// <summary>
        /// Gets out of rope
        /// </summary>
        /// 
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
                    " to combust the area around the rope into fire. Once the rope has burned just enough, you rip out of the bondage!");
            }
            if (playerSheet.CharClass == "Theif")
            {
                WriteLine("Since you're a Theif you already got yourself out of the bondage.");
            }
            if (playerSheet.CharClass == "Cleric")
            {
                WriteLine("The bondage is so tight aroudn your hands, it's very hard for you to get out. Usually in tight situations" +
                    " you send a prayer off.  You go into deep mediation and relay a connection with your entity and the bondage starts to loosen.  " +
                    "You're safely able break loose.");
            }
            ReadKey(false);

        }

        //--------------------------------------------------//

        /// <summary>
        /// Second part of the first -- I know, bad naming
        /// </summary>
        public static void SecondPart()
        {
            Clear();
            WriteLine("Now that you're out of the rope you decided to stand up and observe the cave.\n");
            WriteLine("From what you can tell, you're at the back of a cave. The fire pit you are by looks abandoned.\n" +
                "There is no trace of whoever brought you here, so you decide to leave the cave.\n");
         
            ReadKey(false);
            Clear();
            WriteLine("You stumble out of the cave and find that you're at the top of a small hill. You can see a " +
                "rugged path through some weak woods that is followed by a very thick swamp and in the other direction there is a fairly" +
                " used path.");
            WriteLine("\nYou decide to look up at the sun to figure out how much daylight you have and to figure out your directions."
                + " You reailze the Swamp faces North and the nicer trail is to the West.");
            ReadKey(false);
            SwampOrWest();
            West();
            StrangerEncounter();


        }



        public static void SwampOrWest()
        {
            Clear();

            int counter = 1;
            while (counter == 1)
            {
                WriteLine("Choose a direction:");

                WriteLine("Which direction would you like to go?  Press 's' for swamp or 'w' for west:");
                string choice = ReadLine().ToUpper();

                if (choice == "S")
                {
                    counter++;
                    Swamp();
                    ReadKey(false);

                }

                if (choice == "W")
                {
                    counter++;
                    Clear();
                    WriteLine("You decide to head west and take the safe route.");
                    ReadKey(false);
                }

            }
        }// end SwampOrWest


        public static void Swamp()
        {
            Clear();
            WriteLine("You decide that the swamp looks like a neat place to explore, maybe you'll find out" +
                " more about why you woke up in a cave.\n" +
                "\nYou had no trouble bouldering down the small bluff. You notice there's an even bigger cave entrance behind you " +
                "facing the south, however it's boarded up. You press onward on the rugged trail towards the swamp.");
            ReadKey(false);
            Clear();
            WriteLine("After about a half mile down the trail, the trail opens up to the entrance of a gross looking swamp." +
                " You hear something that sounds like it's popping and you realize there are bubbles coming out of the swamp water" +
                " near you.");
            ReadKey();
         
            CheckBubbles();
            WriteLine("\nAfter coughing and gagging from the bog fog you realize you made it back to the cave you awoke from." +
                "  You end up heading down the fairly used path, towards the west.");
            ReadKey();
        }// end Swamp Scenario

        public static void CheckBubbles()
        {
            Clear();
            if (playerSheet.Wisdom >= 14)
            {
                WriteLine("Your Wisdom knows better than to stick your hand into a bubbling part of a swamp." +
                    " You decide to wait a minute or two.\n");
                ReadKey(false);

                if (playerSheet.Intelligence >= 15)
                {
                    WriteLine("You're aware that swamps sometimes produce bog gas which is a mixture of natural earth gasses." +
                        " You know best to turn back and quit wasting your time.");
                    ReadKey(false);
                }
                else
                {
                    WriteLine("You're not sure why the swamp is bubiling but you know not to get involved. You decide to turn back.");
                    ReadKey(false);
                }


            }// end if
            else
            {

                WriteLine("You seem intrigured by this, you've never seen anything like this.");
                WriteLine("Do you want to venture into the swamp and see what this is? \n\nEnter 1 for yes, press any other key to leave" +
                    " the swamp.");
                string choice = ReadLine();


                if (choice == "1")
                {
                    Clear();
                    int damage = 10;
                    int updatedHealth = playerSheet.TempHealth - damage;

                    WriteLine("You take a few steps into the swamp. It is very hard to move through and it's suprisingly warm." +
                        "\nAs you walk closer to the bubbles you realize your about knee deep in the swamp.\n" +
                        "You notice an awful stench coming from the bubbles, it's worse than any farm work you've delt with." +
                        "\nYour knees start to buckle and you start gagging. You loose your footing and bang your knee into a small " +
                        "structure in the swamp, that really hurt!\n");
                    WriteLine("You lost " + damage + (" health points.") + " " +
                        "Your current health is " + (updatedHealth) + "/" + playerSheet.Health);

                    ReadKey(false);

                }// end



                WriteLine("\nYou decided to back out of the swamp and go back to where it's safe.");

                ReadKey(false);
                Clear();

                ReadKey(false);

            }// end else
        }// end check bubbles

        public static void West()
        {
            Clear();
            WriteLine("You've been walking along this path now for about a mile, the scenery is a lightwooded area" +
                " that looks like is fading away" + 
                "\nSomething smells very odd close by, you happen to notice a corpse" +
                " lying on it's back.  " +
                "\nYou can't tell what sex it is, it looks like it was eaten alive, by you also can't tell" +
                " what from.\n");
            WriteLine("Are you interested in checking the corpse?  Checking corpses is a thing to keep in mind " +
                "since you can salvage useable things from them.");
            CheckCorpse();
        }// end West

        /// <summary>
        /// Option to search a coropse, boolean logic - checks to see if boolean is typed in
        /// </summary>
        public static void CheckCorpse()
        {
            WriteLine("\ntype in 'search' if you are interested in checking the corpse for valuables:\n");
            string search = ReadLine();

            if (search.ToUpperInvariant() == "SEARCH")

            {
                Clear();
                if (playerSheet.Race == "Human")
                {
                    WriteLine("You happen to spot something shinny beside the corpse. You realize it's a memento that you" +
                        " completely forgot about. You grab the sliver ring packed with an amythest.");
                    Beep(3908, 800);
                }
                if (playerSheet.Race == "Elf")
                {
                    WriteLine("You found your brooch that you've been missing.  You've had this for Many years.");
                    Beep(3098, 800);
                }
                if (playerSheet.Race == "Dwarf")
                {
                    WriteLine("Out of the corner of your eye you notice a leather bag right next to the corpse." +
                        " You quickly snatch it and open it to find a small batch of gold that is worth 100.");
                    playerSheet.Gold += 100;
                    Beep(2000, 800);
                }
                if (playerSheet.Race == "Hobbit")
                {
                    WriteLine("You notice a small little journal that looks like was used for notes. You grabbed and opened it up" +
                        " to find that there are recipies that you could be using for all of your future events. \n" +
                        "\nYou stash this away and save it for later.");
                    Beep(1506, 800);
                }
                
              
                ReadKey(false);
            }// end check Corpse

          

        }//End Check Corpse

        ///---------------------------------------------------------------///
        public static void StrangerEncounter()
        {
            Clear();
            WriteLine("You head down the path for about another half mile and you realize the woods are becoming less abundant.\n" +
                "You eventually break out of the woods at the top of huge valley.\n" +
                "This valley has a giant landscape, and a river that flows from the northeast to the southwest, however " +
                "this looks rather far away, at least five miles to the river.\n");
            WriteLine("\nPast the river you see what seems to be a village. This whole place is somewhere you haven't" +
                " been before. " +
                "\nYou honestly don't know how to get back to your home, maybe it's best if you walk" +
                " down towards the river, you're rather thirsty.");
            ReadKey(false);
            ListenFor();


        }// end Stranger Encounter

        /// <summary>
        /// These scenarios branch out, be careful
        /// </summary>
        public static void ListenFor()
        {
            Clear();
            WriteLine("All of a sudden you hear the sound of horse hooves coming up from way you came.");
            ReadKey(false);
            //1st route
            if (playerSheet.Dexterity >= 16)
            {
                Clear();
                WriteLine("You've got plenty of time to hide and possibly sneak up on the stranger that's about to appear.");
                ReadKey(false);
                SneakUp();

                // Add Scenario logic for three sceanrios
                // 1- Wait and follow
                // 2 - Steal horse
                // 3 - Confront/Befriend

                

            }
            //2nd route
            if (playerSheet.Dexterity < 16 && playerSheet.Dexterity >= 13)
            {
                Clear();
                WriteLine("You managed to sneak behind a boulder just before the stranger arrived.\n");
                DescStranger();
                WriteLine("\n The stranger knows that someone is around.");
                WriteLine("\n\n STRANGER: 'Whoever it is, come out now.  I don't have time for these games.'" +
                    " From what you can tell the stranger sounds like a man.");
                ReadKey(false);
                Confortation();

             // Call Scenario Logic for Befriend

            }
            //3rd route
            if (playerSheet.Dexterity < 13)
            {
                Clear();
                WriteLine("You weren't quick enough to hide behind anything, the stranger looks suprised to run into you.");
                if (playerSheet.Charisma > 14)
                {

                    WriteLine("Since your Charisma is one of your best attributes you are easliy able to talk to the stranger easily.");
                    if (playerSheet.CharClass == "Cleric")
                    {
                        WriteLine("\nYou can sense that the stranger has a wound that needs healed up");
                        WriteLine("YOU 'Hey stranger, I know you're in pain at the moment.  I am a cleric and" +
                            " I can heal your wound with a spell.");
                        WriteLine("\nThe stranger trusts you well enough and strugggles" +
                            " to get off his horse and then sits on the ground. ");
                        WriteLine("\nMy foots hurts very badley, I think it's broken.");
                        ReadKey(false);
                        Clear();
                        WriteLine("You tell the stranger to take his boot off and he cries out in pain while he's attempting it.");
                        WriteLine("You can definitley tell his foot is messed up.  You decide a good way to handle this would be" +
                            " to use the Cure Spell you have.");
                        WriteLine("You start concentrating very hard and focusing your energy on mending the wound.");
                        WriteLine("Over the past two minutes you were able to speed up the healing of the foot by tenfold." +
                            " You watch as relief changes the face of the stranger.");
                        ReadKey();
                        Clear();
                        WriteLine("STRANGER: 'Thank the heavens that we ran into eachother' I wasn't sure if I'd be" +
                            " able to fight anything I encountered next.");
                        WriteLine("Would you happen to want a ride down to the village?");
                        WriteLine("You realized your tired and exhausted yourself and there's not way you could make" +
                            " it to the village on foot by the end of the day.");
                        WriteLine("You gladly get on the back of the horse with the stranger and head down into the valley.");

                    }
                    else
                    {
                        WriteLine("STRANGER: 'You look absolutley awful, you need to drink some water quick!'");
                        WriteLine("\nYou struggle your way on to the back of the horse and head down further into the valley.");
                    }
                   

                }

                ReadKey(false);
                // Call logic for befriending
            }

        }// end Listen for

        /// <summary>
        /// Confront the Stranger
        /// </summary>
        public static void Confortation()
        {

            if (playerSheet.Charisma >= 14 && playerSheet.Charisma < 16)
            {
                WriteLine("You step out from behind the boulder, trying not to appear intimidating.");
                WriteLine("\nYOU:  'Hello Stranger, I was not trying to seem like a threat.  I am not familair with the area" +
                    " I woke up in a cave a couple miles back from where you came from and I'm trying to get back home." +
                    "  I don't know where to even start.' ");
                ReadKey(false);
                Clear();
                WriteLine("STRANGER: 'You really look like you could use some water, you probably haven't seen yourself latley.'" +
                    " I could give you a ride down to the river and help you become rejuvinated.\n");
                WriteLine("Normally you would say no to strangers but you can barely think straight at the moment." +
                    "\nYou gladly accept the offer and hop on the back of the stranger's horse.");
                ReadKey(false);

            }
            if (playerSheet.Charisma < 14)
            {
                WriteLine("You step out from behind the boulder, with a weapon in hand.");
                WriteLine("\nYOU: 'I'm not sure where I am, but I don't have time for games either." +
                    " \nI woke up in a cave a couple miles back from where you came from and I'm trying to get back home." +
                    "  \nI don't know where to even start.' ");
                ReadKey(false);
                Clear();
                WriteLine("STRANGER: 'I see that you feel threatned, if you put up that mean face and weapon I could help you out.");
                WriteLine("STRANGER: 'You really look like you could use some water, you probably haven't seen yourself latley.'" +
                    " I could give you a ride down to the river and help you become rejuvinated.\n");
                WriteLine("Normally you would say no to strangers but you can barely think straight at the moment." +
                    "\nYou gladly accept the offer and hop on the back of the strangers horse.");
                ReadKey(false);
            }
        }// end confrotation

        /// <summary>
        /// Called by Listen For - Theif
        /// </summary>
        public static void SneakUp()
        {
            Clear();
            WriteLine("Press 1 if you'd like to hide!\n");
            string choice = ReadLine();

            if (choice == "1")
            {
                WriteLine("\nYou scaled to the top of a nearby tree along the path, no one can tell you're up there.\n");
                WriteLine("After a minute passes by you finally see a traveler appear.");
                DescStranger();
                Clear();
                WriteLine("You definitley have the option to try to steal this stranger's horse.\n" +
                    "Choose from the two options below: \n\n" +
                    "Wait--- type in 'W'" +
                    "\nKnockOut --- type in 'K'");


                string option = ReadLine().ToUpper();

                if (option == "W")
                {
                    WriteLine("\nYou decide to wait out the stranger.");
                    WriteLine("\n Time passes by and you watch the stranger ride his horse further down into the valley," +
                        " and head towards the river. You decide to follow in his steps.");
                    ReadKey();
                }
                if (option == "K")
                {
                    KnockOut();
                }

                ReadKey(false);
            }

            else
            {
                Clear();
                WriteLine("You end up befriending the stranger and heading down with them into the valley");
               
            }
            ReadKey(false);

        }// end SneakUp

        public static void KnockOut()
        {
            int slingChance = playerSheet.Dexterity * 6;
            int chanceToHit = 30;
            Clear();
            WriteLine("You deicde to try to knock out the stranger. Since you have good depth perception you should be able to " +
                "attempt this by using handy dandy sling.\n" +
                "You pull out your far range weapon and load it with one of your dull rocks and stretch back" +
                " as far as you can.");
            WriteLine("\nPress enter to fire ");
            ReadKey(false);
            if (slingChance > chanceToHit)
            {
                Clear();
                WriteLine("The rock zips downward toward the strangers head and knocks him straight down." +
                    " \nThe horse is causing a rampage and about to get away, however you drop from the tree onto the horse" +
                    " and start heading down towards the valley.");
                ReadKey(false);
            }
            /// else

        }// end Knock Out

        /// <summary>
        /// Describes the Stranger
        /// </summary>
        public static void DescStranger()
        {
            Clear();
            WriteLine("The stranger is clothed in long sleeve chestware and wool pants. They have a hood on, otherwise" +
                " you could tell what gender they are. They are sitting riding on a well build dark brown horse, looks" +
                " well fed and taken care of.");
            ReadKey();
        }// end Describe Stranger

        /// <summary>
        /// Scenario for getting down to the river -- Stranger takes you to town
        /// </summary>
        public static void Befriend()
        {
            Clear();
            WriteLine("You watch as the scenery into the valley gets much more beatiful, time slips by" +
                " and you notice you have about two hours of daylight left.");
            WriteLine("\n'STRANGER: 'Oh by the way, I forgot to mention my name, my name is Jobe.  What is yours?");
            WriteLine("\nYOU: 'My name is " + playerSheet.Name + ".");
            WriteLine("\nJobe: 'Okay then " + playerSheet.Name + "!  We are going to stop near the river and make camp for the night, I don't feel comfortable" +
                " riding my horse at night.'");
            WriteLine("You agree with the stranger completley.");
            WriteLine("/nMoment's pass by and the stranger stops at a certain spot a long the river.");
            ReadKey(false);
            Clear();
            WriteLine("Jobe: 'This place looks like a safe place. If you want to search the nearby woods for some firewood" +
                " I can catch some fish for dinner form the river.'");
            WriteLine("You head out towards the woods and find plenty of dry wood ot use to start a fire." +
                "\nYou head back to the camping spot and build a make shift fire pit out of some near by rocks and" +
                " managed to make a cooking pit to easily cook over.");
            WriteLine("\nYou watch Jobe walking the river side with a heafty size net full of fish.");
            WriteLine("\nJobe: 'We ain't going hungry tonight my friend.'");
            WriteLine("You watch Jobe quckily skin and remove the guts from 12 fish and observe him" +
                " skewer them all. \n" +
                "You built a roaring fire and the fish cooks with no problem at all.");
            WriteLine("\nYou guys share some stories about your childhoods and make a plan to leave early the next morning.");
            WriteLine("Eventually the two of you fall asleep covered in cloaks, listening to the roaring sound of the river.");
            ReadKey(false);
            Clear();
            WriteLine("\nYou both awake in the morning and luckily nothing messed with you overnight. Jobe picked a pretty good" +
                " spot to camp and hide out.");
            WriteLine("You both pick up camp and load up on water, You know it will be at least a few hours until you get to town.");
            WriteLine("\nYou both get on the horse and find a small bridge to cross over the river.");
            WriteLine("\nAfter about an 1 hour of riding through the valley, Jobe starts talking your ear off.");
            ReadKey(false);
            Conversation();

            
        }

        public static void Conversation()
        {
            if(playerSheet.Race == "Human")
            {
                Clear();
                WriteLine("It's a good thing that you're a Human. The village we are going to is mainly popoulated " +
                    "by Humans.");
                WriteLine("'You won't have any problems getting along with anybody in town. I'd suggest that you" +
                    " go to the Tavern to learn about what your next step should be.'");
                WriteLine("\nYou question Jobe: 'So you're saying you're not coming to the village?'");
                WriteLine("\nJobe: 'That is a correct assumption, I don't really like a lot of people.  I'm not welcome" +
                    " to the town anyways. I was banished long ago and I've been on my own for years.'");
                WriteLine("\nYOU 'Why were you BANISHED?");
                WriteLine("\nLet's just say me and the mayor have two different ideas on how handle the economy of the town.");
                ReadKey();
            }

            if (playerSheet.Race == "Elf")
            {
                Clear();
                WriteLine("'You might have a little bit of trouble with fitting into the village" +
                    ". The village we are going to is mainly populated " +
                    "by Humans.  I wouldn't stay long if I were you.'");
                WriteLine("' I'd suggest that you" +
                    " go to the Tavern to learn about what your next step should be.'");
                WriteLine("\nYou question Jobe: 'So you're saying you're not coming to the village?'");
                WriteLine("\nJobe: 'That is a correct assumption, I don't really like a lot of people.  I'm not welcome" +
                    " to the town anyways. I was banished long ago and I've been on my own for years.'");
                WriteLine("\nYOU 'Why were you BANISHED?");
                WriteLine("\nLet's just say me and the mayor have two different ideas on how handle the economy of the town.");
                ReadKey();
            }
            
            if (playerSheet.Race == "Dwarf")
            {
                Clear();
                WriteLine("'You shouldn't have too much trouble with fitting into the village" +
                    ". The village we are going to is mainly populated " +
                    "by Humans and they like to trade with the Dwarven. I wouldn't stay long if I were you, the government " +
                    " may try to take advantage of you though. Therefore, be careful.'");
                WriteLine("' I'd suggest that you" +
                    " go to the Tavern to learn about what your next step should be.'");
                WriteLine("\nYou question Jobe: 'So you're saying you're not coming to the village?'");
                WriteLine("\nJobe: 'That is a correct assumption, I don't really like a lot of people.  I'm not welcome" +
                    " to the town anyways. I was banished long ago and I've been on my own for years.'");
                WriteLine("\nYOU 'Why were you BANISHED?");
                WriteLine("\nLet's just say me and the mayor have two different ideas on how handle the economy of the town.");
                ReadKey();
            }

            if (playerSheet.Race == "Hobbit")
            {
                Clear();
                WriteLine("'You shouldn't have too much trouble with fitting into the village" +
                    ". The village we are going to is mainly populated " +
                    "by Humans and they like to be spoiled by Hobbits. I wouldn't stay long if I were you, the townsfolk  " +
                    " may try to take advantage of you though. Therefore, be careful.'");
                WriteLine("' I'd suggest that you" +
                    " go to the Tavern to learn about what your next step should be.'");
                WriteLine("\nYou question Jobe: 'So you're saying you're not coming to the village?'");
                WriteLine("\nJobe: 'That is a correct assumption, I don't really like a lot of people.  I'm not welcome" +
                    " to the town anyways. I was banished long ago and I've been on my own for years.'");
                WriteLine("\nYOU 'Why were you BANISHED?");
                WriteLine("\nLet's just say me and the mayor have two different ideas on how handle the economy of the town.");
                ReadKey();
            }
        }// end Conversation
        /// <summary>
        /// Scenario for getting down to the river 
        /// </summary>
        public static void StolenHorse()
        {

        }

        /// <summary>
        /// Scenario for LoneWolf -- Later run into stranger
        /// </summary>
        public static void LoneWolf()
        {

        }

    }


}
