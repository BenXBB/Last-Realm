using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adventure
{

   // ---------------------------------------------- RACE PICKER ---------------------------------------------- 
    public class Race {
        public string characterRace { get; set; }
        public int characterHealth { get; set; }
        public int characterStr { get; set; }
        public int characterWit {get; set; }

        public Race(string charRace, int charHealth, int charStr, int charWit) {
            characterRace = charRace;
            characterHealth = charHealth;
            characterStr = charStr;
            characterWit = charWit;
            }
        }
    // ---------------------------------------------- GAME CONTROLLERS ----------------------------------------------
    public static class Game
    {

        public static String CharacterNameStore = "";
        public static Race CharacterRaceStore = new Race("Human", 4, 3, 3);
        public static void CharacterStats() {
            DarkBlueTextWriteLine($"\n{Game.CharacterRaceStore.characterRace} {Game.CharacterNameStore}:     HP: {Game.CharacterRaceStore.characterHealth}     STR: {Game.CharacterRaceStore.characterStr}     WIT: {Game.CharacterRaceStore.characterWit}");
        }

        public static void validateGameOver() {
            if (Game.CharacterRaceStore.characterHealth < 1) {
                RedTextWriteLine($"HP: {Game.CharacterRaceStore.characterHealth}");
                RedTextWriteLine("You have died.");
                AcsiiArt.deathArt();
                Console.WriteLine("Try again!");
                Console.ReadLine();
                System.Environment.Exit(0);
            } else if (Game.CharacterRaceStore.characterStr < 1) {
                RedTextWriteLine($"Str: {Game.CharacterRaceStore.characterStr}");
                AcsiiArt.deathArt();
                RedTextWriteLine("You have lost all your energy, you are too weak to continue your quest..");
                Console.WriteLine("Try again!");
                Console.ReadLine();
                System.Environment.Exit(0);
            } else if (Game.CharacterRaceStore.characterWit < 1) {
                RedTextWriteLine($"Wit: {Game.CharacterRaceStore.characterWit}");
                AcsiiArt.deathArt();
                RedTextWriteLine("You have lost your sanity, you are not fit to complete your quest.");
                Console.WriteLine("Try again!");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
        }

        // Rolls a dice based on character HP, Str or Wit and returns a percentage of chance of succeed
        public static int rollDice(string option) {
            int diceRoll = 0;
            if (option == "A") {
                if (Game.CharacterRaceStore.characterRace == "Elf") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterHealth * 100) / 5);
                } else if (Game.CharacterRaceStore.characterRace == "Human") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterHealth * 100) / 6);
                } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterHealth * 100) / 7);
                }
            } else if (option == "B") {
                if (Game.CharacterRaceStore.characterRace == "Elf") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterWit * 100) / 7);
                } else if (Game.CharacterRaceStore.characterRace == "Human") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterWit * 100) / 7);
                } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterWit * 100) / 5);
                }
            } else if (option == "C") {
                if (Game.CharacterRaceStore.characterRace == "Elf") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterStr * 100) / 7);
                } else if (Game.CharacterRaceStore.characterRace == "Human") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterStr * 100) / 7);
                } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                diceRoll = (int)Math.Round((double)(Game.CharacterRaceStore.characterStr * 100) / 5);
                } 
            }
            return diceRoll;
        }

         // --- TEXT COLORS ---
        public static void CyanTextWriteLine(string message) {
                 Console.ForegroundColor = ConsoleColor.Cyan;
                 Console.WriteLine(message);
                 Console.ResetColor();
        }
        public static void DarkBlueTextWriteLine(string message) {
                 Console.ForegroundColor = ConsoleColor.DarkBlue;
                 Console.WriteLine(message);
                 Console.ResetColor();
        }

        public static void RedTextWriteLine(string message) {
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine(message);
                 Console.ResetColor();
        }
        public static void GreenTextWriteLine(string message) {
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(message);
                 Console.ResetColor();
        }
        public static void YellowTextWriteLine(string message) {
                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.WriteLine(message);
                 Console.ResetColor();
        }

        public static void StartGame() {

           Console.WriteLine("------------------------------------------------------\n");
           CyanTextWriteLine(@"                            _                _____ _______   _____  ______          _                         ");
           CyanTextWriteLine(@"               | |        /\    / ____|__   __| |  __ \|  ____|   /\   | |    |  \/  |                        ");
           CyanTextWriteLine(@"               | |       /  \  | (___    | |    | |__) | |__     /  \  | |    | \  / |                        ");
           CyanTextWriteLine(@"               | |      / /\ \  \___ \   | |    |  _  /|  __|   / /\ \ | |    | |\/| |                        ");
           CyanTextWriteLine(@"               | |____ / ____ \ ____) |  | |    | | \ \| |____ / ____ \| |____| |  | |                        ");
           CyanTextWriteLine(@"               |______/_/    \_|_____/   |_|    |_|  \_|______/_/    \_|______|_|  |_|                        ");
           Console.WriteLine(@"        _    .  ,   .           .                              _    .  ,   .           .                      ");
           Console.WriteLine(@"    *  / \_ *  / \_      _  *        *   /\'__        *    *  / \_ *  / \_      _  *        *   /\'__        *");
           Console.WriteLine(@"      /    \  /    \,   ((        .    _/  /  \  *'.         /    \  /    \,   ((        .    _/  /  \  *'.   ");
           Console.WriteLine(@" .   /\/\  /\/ :' __ \_  `          _^/  ^/    `--.     .   /\/\  /\/ :' __ \_  `          _^/  ^/    `--.    ");
           Console.WriteLine(@"    /    \/  \  _/  \-'\      *    /.' ^_   \_   .'\  *    /    \/  \  _/  \-'\      *    /.' ^_   \_   .'\  *");
           Console.WriteLine(@"  /\  .-   `. \/     \ /==~=-=~=-=-;.  _/ \ -. `_/   \   /\  .-   `. \/     \ /==~=-=~=-=-;.  _/ \ -. `_/   \ ");
           Console.WriteLine(@" /  `-.__ ^   / .-'.--\ =-=~_=-=~=^/  _ `--./ .-'  `-   /  `-.__ ^   / .-'.--\ =-=~_=-=~=^/  _ `--./ .-'  `-  ");
           Console.WriteLine(@" /  `-.__ ^   / .-'.--\ =-=~_=-=~=^/  _ `--./ .-'  `-   /  `-.__ ^   / .-'.--\ =-=~_=-=~=^/  _ `--./ .-'  `-  ");
           Console.WriteLine("\n----------------------------------------------------\n");
           Console.WriteLine("Welcome to Last Realm. You will be exploring the world of Vanaheim. \nThe ninth and last realm of Norse Mythology.");
           Console.WriteLine("Please only use the keys as stated when user input is available and let the program run its course until prompted for user interaction");
        }
        
        public static void NameCharacter() {
           Boolean validateNameSelection = false;
            while (!validateNameSelection) {
            Console.WriteLine("\nWhat is your name?");
            CharacterNameStore = Console.ReadLine();
                if (string.IsNullOrEmpty(CharacterNameStore)) {
                    Console.WriteLine("Every adventurer must have a name!");
                    validateNameSelection = false;
                } else { validateNameSelection = true; }
            }
           Console.WriteLine($"{CharacterNameStore}, You have been chosen to to help defend the realm of Vanaheim from it's enemies.");
        }

        public static void CharacterRace() {
           Boolean validateRaceSelection = false;
           String raceChoice = "";
           while (!validateRaceSelection) {
            Console.WriteLine("\nWhat is your race?");
            CyanTextWriteLine("\nA. Elf, B. Human, or C. Dwarf?");

            AcsiiArt.raceArt();

            raceChoice = Console.ReadLine().ToUpper();

            if (raceChoice == "A") {
                CyanTextWriteLine("\nYou are a Light Elf.");
                Console.WriteLine("For years the elves have ruled Alfheim, although in a constant war between the light and dark elves.. elven society is centered on intelligence and flexibility");
                validateRaceSelection = true;
                CharacterRaceStore = new Race("Elf", 3, 2, 5);
            } else if (raceChoice == "B") {
                CyanTextWriteLine("\nYou are a Human");
                Console.WriteLine("The humans are the most populous and the youngest race in Midgard. They favour their youthful ambitions and resilience.");
                validateRaceSelection = true;
                CharacterRaceStore = new Race("Human", 4, 3, 3);
            } else if (raceChoice == "C") {
                CyanTextWriteLine("\nYou are a Dwarf");
                Console.WriteLine("\nBold and adventurous, the Dwarves of Svartalfheim are a hardy people who relish battle and exploration.");
                validateRaceSelection = true;
                CharacterRaceStore = new Race("Dwarf", 5, 4, 2);
            } else {
                CyanTextWriteLine("Please input A, B or C");
                validateRaceSelection = false;
            }
           }
        }
    } // End of Game class

    // --------------------------------------------------- ITEM CONTROLLERS ----------------------------------------------------------------
    public static class Items
    {
        // --------------------------- 1. Beverage -------------------------------
        public static void beverageChoice() {
           Boolean validatebeverageSelection = false; 
           Console.WriteLine("\nIt begins on a cold rainy night. You're sitting in your shack struggling to make a choice of beverage...");
           Thread.Sleep(3000); 
           while (!validatebeverageSelection) {
           Game.CharacterStats();
           Console.WriteLine("\nYou pick... \n\nA. An ice cold beer. \nB. Magical Green Tea. \nC. An unknown green liquid given to you by a Vanir.");
           string beverageChoice = Console.ReadLine().ToUpper();
                    if (beverageChoice == "A") {
                        if (Game.CharacterRaceStore.characterRace == "Elf") {
                            Console.WriteLine("\nYou drink the beer, although being an Elf you would of prefered something with magic.");
                            Game.RedTextWriteLine("- 1 Wit\n");
                            --Game.CharacterRaceStore.characterWit;
                            validatebeverageSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Human") {
                            Console.WriteLine("\nYou drink the beer, being a young human, you trip over your bed and hit your head.");
                            Game.RedTextWriteLine("- 1 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            validatebeverageSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                            Console.WriteLine("\nYou drink the beer, it reminds you of many good memories of your hometown's tavern.");
                            Game.GreenTextWriteLine("+ 1 HP\n");
                            ++Game.CharacterRaceStore.characterHealth;
                            validatebeverageSelection = true;
                        }
                    } else if (beverageChoice == "B") {
                        if (Game.CharacterRaceStore.characterRace == "Elf") {
                            Console.WriteLine("\nYou drink the tea, You feel the magical effects enpower your body.");
                            Game.GreenTextWriteLine("+ 1 Str\n");
                            ++Game.CharacterRaceStore.characterStr;
                            validatebeverageSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Human") {
                            Console.WriteLine("\nYou drink the tea, although its safe to drink, it's embedded with Alfhiemium light magics that drain a little of your stength.");
                            Game.RedTextWriteLine("- 1 Str\n");
                            --Game.CharacterRaceStore.characterStr;
                            validatebeverageSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                            Console.WriteLine("\nYou drink the tea, although its safe to drink, it's embedded with Alfhiemium light magics that drain a little of your stength.");
                            Game.RedTextWriteLine("- 1 Str\n");
                            --Game.CharacterRaceStore.characterStr;
                            validatebeverageSelection = true;
                        }
                    } else if (beverageChoice == "C") {
                        if (Game.CharacterRaceStore.characterRace == "Elf") {
                            Console.WriteLine("\nYou drink the liquid. The Vanir that gave this to you had good intentions however as an Elf, this did not agree with your body.");
                            Game.RedTextWriteLine("- 1 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            validatebeverageSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Human") {
                            Console.WriteLine("\nYou drink the liquid - its a special strength potion made by Freya to aid you on your journey.");
                            Game.GreenTextWriteLine("+ 1 Str\n");
                            ++Game.CharacterRaceStore.characterStr;
                            validatebeverageSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                            Console.WriteLine("\nYou drink the liquid. its a special strength potion made by Freya to aid you on your journey. However it doesn't have much affect on an already strong Dwarf.");
                            Game.YellowTextWriteLine("No change\n");
                            validatebeverageSelection = true;
                        }   
                    } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validatebeverageSelection = false;
                    }
           }
                Thread.Sleep(5000);
        }
        // --------------------------- 2. Hooded man -------------------------------
        public static void hoodedManChoice() {
           Console.WriteLine("You see some light at the end of the woods and see a hooded figure at the edge.\n");
           Thread.Sleep(3000);
           AcsiiArt.mimirArt();
           Thread.Sleep(3000);
           Game.YellowTextWriteLine($"'Greetings {Game.CharacterNameStore}. Well done for making it this far, a fair feat for a {Game.CharacterRaceStore.characterRace} like yourself...'");
           Game.CharacterStats();
           Console.WriteLine("\nYour reaction...\nA. Stay silent \nB. 'Were you waiting for me?' \nC. *Attack the hooded man*");
           string hoodedChoice = Console.ReadLine().ToUpper();
           Thread.Sleep(3000);

            if (hoodedChoice == "A") {
                Game.YellowTextWriteLine($"'Ahh.. the quiet type, highly unexpected from a {Game.CharacterRaceStore.characterRace}....'");
                Console.WriteLine("The hooded man strokes his beard in contemptment and looks you up and down..");
                Thread.Sleep(3000);
                Game.YellowTextWriteLine("\n'I hope Freya has made a wise choice. You will need this on your travels.. My name is Mímir, I was once affiliated with the Aesir, however I now assist Freya with protecting her realm.'");
                Thread.Sleep(2000);
                Console.WriteLine("\nThe hooded man gives you a Vegvisir pendant.. A old protection symbol used on long and perilous journeys.");
                Game.GreenTextWriteLine("+ 1 Str\n");
                Console.WriteLine("\nPress the 'Enter' key..");
                Console.ReadLine();
                ++Game.CharacterRaceStore.characterStr;
            } else if (hoodedChoice == "B") {
                Console.WriteLine("\nThe hooded man chuckles to himself with a friendly pat to the shoulder.. Anyone else and you would of backed away by now, however you can sense the man means you no harm.");
                Thread.Sleep(3000);
                Game.YellowTextWriteLine($"\n'Relax, {Game.CharacterRaceStore.characterRace}. I mean you no harm. Freya has appointed me to give you an item to have on your travels. My name is Mímir, I was once affiliated with the Aesir, however I now assist Freya with protecting her realm.'");
                Console.WriteLine("\nThe hooded man gives you a Vegvisir pendant.. A old protection symbol used on long and perilous journeys.");
                Game.GreenTextWriteLine("+ 1 Str\n");
                Console.WriteLine("\nPress the 'Enter' key..");
                Console.ReadLine();
                ++Game.CharacterRaceStore.characterStr;
            } else if (hoodedChoice == "C") {
                Console.WriteLine("You attack the hooded man with your sword...");
                Thread.Sleep(2000);
                Game.RedTextWriteLine(@"                         ___ _ _   ");
                Game.RedTextWriteLine(@"__/\__  / __\ (_)_ __   __ ___/\__");
                Game.RedTextWriteLine(@"\    / / /  | | | '_ \ / _` \    /");
                Game.RedTextWriteLine(@"/_  _\/ /___| | | | | | (_| /_  _\");
                Game.RedTextWriteLine(@"  \/  \____/|_|_|_| |_|\__, | \/  ");
                Game.RedTextWriteLine(@"                       |___/      ");
                Thread.Sleep(2000);
                Console.WriteLine("Your sword bounces off the man and hits you.");
                Game.RedTextWriteLine("- 10 HP\n");
                Thread.Sleep(2000);
                Game.YellowTextWriteLine("'What a strange creature, why..?'");
                Console.WriteLine("Your journey has ended as fast as it began...\n");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
           Game.YellowTextWriteLine($"'Carry on down this path {Game.CharacterNameStore}... This will lead you to the Yggdrasil portal, you must close the enterance to this realm so peace may finally return.'");
           Thread.Sleep(3000);
           Console.WriteLine("\nYou continue down the path where Mimir directed you. You feel as though your journey has just begun....\n");
           Thread.Sleep(5000);
        }

        // --------------------------- 3. Stone Bridge -------------------------------
        public static void stoneBridgeChoice() {
            Thread.Sleep(2000);
            Console.WriteLine("\nYou see an old stone bridge that looks as though it could give way at any moment"); 
            AcsiiArt.stoneBridge();
            Thread.Sleep(5000);
            switch (Game.CharacterRaceStore.characterRace) {
                case "Elf":
                Console.WriteLine("\nYour Elven Wit welcomes the challenge. It would be a good idea to use your Elven agility..\n");
                break;
                case "Human":
                Console.WriteLine("\nThe constitution of a human will excel here, after all, Humans are the smartest race in Midgard..\n");
                break;
                case "Dwarf":
                Console.WriteLine("\nYour Dwarven strength boils at the promise to demonstrate your strength.\n");
                break;
            }

           Boolean validateBridgeSelection = false; 
           while (!validateBridgeSelection) {
           Game.CharacterStats();
           Console.WriteLine("\nYour action... \nA. Make a rope and swing across \nB. Brave the river \nC. Sprint across");
           string bridgeChoice = Console.ReadLine().ToUpper();
           Thread.Sleep(3000);
                    if (bridgeChoice == "A") {
                        if (Game.CharacterRaceStore.characterRace == "Elf") {
                            Console.WriteLine("\nYou attempt to swing across the river...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYour Elvish hands slip and you fall into the river.. barely making it out to the other side..");
                            Game.RedTextWriteLine("- 2 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            --Game.CharacterRaceStore.characterHealth;
                            validateBridgeSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Human") {
                            Console.WriteLine("\nYou create a make-shift rope from your Human intelligence and swing across successfully..");
                            Game.GreenTextWriteLine("+ 1 Wit\n");
                            ++Game.CharacterRaceStore.characterWit;
                            validateBridgeSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                            Console.WriteLine("\nYou attempt to swing across the river...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYour brutish Dwarven hands break the swing landing on your head.. at least nothing important was damaged..");
                            Game.RedTextWriteLine("- 2 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            --Game.CharacterRaceStore.characterHealth;
                            validateBridgeSelection = true;
                        }
                    } else if (bridgeChoice == "B") {
                        if (Game.CharacterRaceStore.characterRace == "Elf") {
                            Console.WriteLine("\nYou attempt to brave the river...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYour skinny Elven body is unable to withstand the current and you barely make it to the other side..");
                            Game.RedTextWriteLine("- 2 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            --Game.CharacterRaceStore.characterHealth;
                            validateBridgeSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Human") {
                            Console.WriteLine("\nYou attempt to brave the river...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYour skinny Human body is unable to withstand the current and you barely make it to the other side..");
                            Game.RedTextWriteLine("- 2 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            --Game.CharacterRaceStore.characterHealth;
                            validateBridgeSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                            Console.WriteLine("\nYou attempt to brave the river...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYour brutish body of a Dwarf is able to easily get across the river with ease.");
                            Game.GreenTextWriteLine("+ 1 Wit\n");
                            ++Game.CharacterRaceStore.characterWit;
                            validateBridgeSelection = true;
                        }
                    } else if (bridgeChoice == "C") {
                        if (Game.CharacterRaceStore.characterRace == "Elf") {
                            Console.WriteLine("\nYou attempt to sprint across the bridge...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYour Elven agility is unmatched.. you quickly get across the bridge with no harm.");
                            Game.GreenTextWriteLine("+ 1 Wit\n");
                            ++Game.CharacterRaceStore.characterWit;
                            validateBridgeSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Human") {
                            Console.WriteLine("\nYou attempt to sprint across the bridge...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nAlthough you are quick for a Human, you are not able to get across before the bridge collapses. You barely make it out alive.");
                            Game.RedTextWriteLine("- 2 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            --Game.CharacterRaceStore.characterHealth;
                            validateBridgeSelection = true;
                        } else if (Game.CharacterRaceStore.characterRace == "Dwarf") {
                            Console.WriteLine("\nYou attempt to sprint across the bridge...");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYou are a Dwarf and can barely jog, let alone sprint, you are not able to get across before the bridge collapses. You barely make it out alive.");
                            Game.RedTextWriteLine("- 2 HP\n");
                            --Game.CharacterRaceStore.characterHealth;
                            --Game.CharacterRaceStore.characterHealth;
                            validateBridgeSelection = true;
                        }   
                    } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validateBridgeSelection = false;
                    }
           }
                Game.validateGameOver();
                Thread.Sleep(5000);
        }
        

        // --------------------------- 4. Draugr -------------------------------

        public static void draugrChoice() {
            Console.WriteLine("\nYou come across a crpyt.. You don't see any other way round to progress on your journey and decide to go through the decrepit location..."); 
            Thread.Sleep(5000);
            AcsiiArt.crpytEnterance();
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            Console.WriteLine("\nThe door is heavy and takes a lot of your strength to open, as you progress through the fowl smelling labyrinth you sense something is watching or following you."); 
            Thread.Sleep(3000);
            Console.WriteLine("\nYou make no mistake identifying the smell.. remembering the stories of Nord warriors, bound to death, forever to wander their tombs.. you turn with your weapon in hand.."); 
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            AcsiiArt.draugrArt();
            Console.WriteLine("\nIt's a Draugr! This event is chance based on your skills, choose wisely..");
            
            Boolean validateDraugrSelection = false; 
            
                while (!validateDraugrSelection) {
                Game.CharacterStats();
                Random RandomDiceRoll = new Random();
                int draugerDiceRoll = RandomDiceRoll.Next(0, 100);
                Console.WriteLine($"\nA. Attack the creature. {Game.rollDice("A")}% chance.");
                Console.WriteLine($"\nB. Attempt to escape. {Game.rollDice("B")}% chance.");
                Console.WriteLine($"\nC. Stand your ground. {Game.rollDice("C")}% chance.");
                string draugrFightChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (draugrFightChoice == "A") {
                        if (draugerDiceRoll < Game.rollDice("A")) {
                            Console.WriteLine("/nYou charge the creature with all your might, it stands no chance against you.");
                            validateDraugrSelection = true;
                        } else {
                            Console.WriteLine("\nYou charge the creature and lose your footing, the Draugr swipes at you..");
                            Game.RedTextWriteLine("\n- 1 HP");
                            --Game.CharacterRaceStore.characterHealth;
                            Game.validateGameOver();
                            Console.WriteLine("\nYou narrowly escape.. How clumsy..");
                            validateDraugrSelection = true;
                        }
                } else if (draugrFightChoice == "B") {
                        if (draugerDiceRoll < Game.rollDice("B")) {
                            Console.WriteLine("\nYou realise losing your life isnt worth it over your quest. You make a quick get away out of the catacombs..");
                            validateDraugrSelection = true;
                        } else {
                            Console.WriteLine("\nYou attempt to escape past the Draugr, however the undead beast throws it's axe whilst you escape and hits you shoulder..");
                            Game.RedTextWriteLine("\n- 1 HP");
                            --Game.CharacterRaceStore.characterHealth;
                            Game.validateGameOver();
                            Console.WriteLine("\nYou narrowly escape.. How clumsy..");
                            validateDraugrSelection = true;
                        }
                } else if (draugrFightChoice == "C") {
                        if (draugerDiceRoll < Game.rollDice("C")) {
                            Console.WriteLine("\nYou stand your ground.. the Draugr may be undead but it realises your skill in battle and fears death a second time. The monster lets you pass..");
                            validateDraugrSelection = true;
                        } else {
                            Console.WriteLine("\nYou hold your ground against the undead, however it uses this as a chance to strike The Draugr hits your shoulder..");
                            Game.RedTextWriteLine("\n- 1 HP");
                            --Game.CharacterRaceStore.characterHealth;
                            Game.validateGameOver();
                            Console.WriteLine("\nYou narrowly escape.. How clumsy..");
                            validateDraugrSelection = true;
                        }
                } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validateDraugrSelection = false;
                    }
                }
            Thread.Sleep(5000);
        }
    } // end of Items class

    public static class AcsiiArt
    {
        public static void raceArt() {
            Console.WriteLine(@"        ..-.--..    .       ) ( )) )( (( )    .  |/|    \_/   ;;|\  ");
            Console.WriteLine(@"   ,','.-`.-.`.     .   ( (((   )  (  )  ) )  .  | ____       ___ | ");
            Console.WriteLine(@"  :.',;'     `.\.   .  )) (( ) (          ((  . (|  \.\ \__/ /./  |.");
            Console.WriteLine(@"  ||//----,-.--\|   . (  )) )  ____   ____ )  .  |        |       | ");
            Console.WriteLine(@"\`:|/-----`-'--||'/ .  ) ( ) `|<();|-|,()>|   . '|    /-.__.-\    | ");
            Console.WriteLine(@" \\|:    |:'     /  . ( ))(    `--'  \`--'    .  |     |   |     \| ");
            Console.WriteLine(@"  `||      \   |!   . )( ( )       (- )   )   . ~| |  /V""""V\      | ");
            Console.WriteLine(@"  |!|          ;|   .   ))        _____  /    .   \|  ~`^~~^'|   /  ");
            Console.WriteLine(@"  !||:.   --  /|!   .     )   `     --  /     .     \\._____./ /    ");
            Console.WriteLine(@" /||!||:.___.|!||\  .      _ ,  `   __,       .       |   |         ");
            Game.CyanTextWriteLine(@"         ELF        .          Human          .       Dwarf         ");
            Console.WriteLine(@"         HP: 3      .          HP: 4          .       HP: 5         ");
            Console.WriteLine(@"         Str: 2     .          Str: 3         .       Str: 4        ");
            Console.WriteLine(@"         Wit: 5     .          Wit: 3         .       Wit: 2        ");
        }
        public static void woodsArt() {
            Game.GreenTextWriteLine(@"               ,@@@@@@@,                           ,@@@@@@@,");
            Game.GreenTextWriteLine(@"       ,,,.   ,@@@@@@/@@,  .oo8888o.       ,,,.   ,@@@@@@/@@,  .oo8888o.");
            Game.GreenTextWriteLine(@"    ,&%%&%&&%,@@@@@/@@@@@@,8888\88/8o    ,&%%&%&&%,@@@@@/@@@@@@,8888\88/8o");
            Game.GreenTextWriteLine(@"   ,%&\%&&%&&%,@@@\@@@/@@@88\88888/88'*  ,%&\%&&%&&%,@@@\@@@/@@@88\88888/88'");
            Game.GreenTextWriteLine(@"   %&&%&%&/%&&%@@\@@/ /@@@88888\88888'*  %&&%&%&/%&&%@@\@@/ /@@@88888\88888'");
            Game.GreenTextWriteLine(@"   %&&%/ %&%%&&@@\ V /@@' `88\8 `/88' * %&&%/ %&%%&&@@\ V /@@' `88\8 `/88'");
            Game.GreenTextWriteLine(@"   `&%\ ` /%&'    |.|        \ '|8'   *  `&%\ ` /%&'    |.|        \ '|8'");
            Game.GreenTextWriteLine(@"       |o|        | |         | |    * *     |o|        | |         | |");
            Game.GreenTextWriteLine(@"       |.|        | |         | |     *      |.|        | |         | |");
            Game.GreenTextWriteLine(@"    \\/ ._\//_/__/  ,\_//__\\/.  \_//__/_\\/ ._\//_/__/  ,\_//__\\/.  \_//__/_");
        }
        public static void mimirArt() {
            Game.CyanTextWriteLine(@"                         _,-'|         ");
            Game.CyanTextWriteLine(@"                      ,-'._  |         ");
            Game.CyanTextWriteLine(@"            .||,      |####\ |         ");
            Game.CyanTextWriteLine(@"           \.`',/     \####| |         ");
            Game.CyanTextWriteLine(@"           = ,. =      |###| |         ");
            Game.CyanTextWriteLine(@"           / || \    ,-'\#/,'`.        ");
            Game.CyanTextWriteLine(@"             ||     ,'   `,,. `.       ");
            Game.CyanTextWriteLine(@"             ,|____,' , ,;' \| |       ");
            Game.CyanTextWriteLine(@"            (3|\    _/|/'   _| |       ");
            Game.CyanTextWriteLine(@"             ||/,-''  | >-'' _,\\      ");
            Game.CyanTextWriteLine(@"             ||'      ==\ ,-'  ,'      ");
            Game.CyanTextWriteLine(@"             ||       |  V \ ,|        ");
            Game.CyanTextWriteLine(@"             ||       |    |` |        ");
        }
        public static void deathArt() {
            Game.RedTextWriteLine(@"  _____");
            Game.RedTextWriteLine(@" /     \");
            Game.RedTextWriteLine(@"| () () |");
            Game.RedTextWriteLine(@" \  ^  /");
            Game.RedTextWriteLine(@"  |||||");
            Game.RedTextWriteLine(@"  |||||");
        }

        public static void stoneBridge() {
            Console.WriteLine(@"_:_:_:_:_:_:[]:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:[]:_:_:_:_:_:_");
            Console.WriteLine(@"!!!!!!!!!!!![]!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!![]!!!!!!!!!!!!!");
            Console.WriteLine(@"!!!!!!!!!!!![]!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!![]!!!!!!!!!!!!!");
            Console.WriteLine(@"^^^^^^^^^^^^[]]^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[]^^^^^^^^^^^^^");
            Console.WriteLine(@"            []]                                     [[]");
            Console.WriteLine(@"            []]                                     [[]");
            Game.CyanTextWriteLine(@" ~~^-~^_~^~/  \~^-~^~_~^-~_^~-^~_^~~-^~_~^~-~_~-^~_^/  \~^-~_~^-~~-");
            Game.CyanTextWriteLine(@"~ _~~- ~^-^~-^~~- ^~_^-^~~_ -~^_ -~_-~~^- _~~_~-^_ ~^-^~~-_^-~ ~^");
            Game.CyanTextWriteLine(@"   ~ ^- _~~_-  ~~ _ ~  ^~  - ~~^ _ -  ^~-  ~ _  ~~^  - ~_   - ~^_~");
        }

        public static void crpytEnterance() {
            Console.WriteLine(@"|____________________________________________|");
            Console.WriteLine(@"|__||  ||___||  |_|___|___|__|  ||___||  ||__|");
            Console.WriteLine(@"||__|  |__|__|  |___|___|___||  |__|__|  |__||");
            Console.WriteLine(@"|__||  ||___||  |_|___|___|__|  ||___||  ||__|");
            Console.WriteLine(@"||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine(@"|__||  ||___||  |    || |    |  ||___||  ||__|");
            Console.WriteLine(@"||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine(@"|__||  ||___||  |    || |    |  ||___||  ||__|");
            Console.WriteLine(@"||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine(@"|__||  ||___||  |   O|| |O   |  ||___||  ||__|");
            Console.WriteLine(@"||__|  |__|__|  |    || |    |  |__|__|  |__||");
            Console.WriteLine(@"|__||  ||___||  |    || |    |  ||___||  ||__|");
            Console.WriteLine(@"||__|  |__|__|__|____||_|____|  |__|__|  |__||");
            Console.WriteLine(@"|LLL|  |LLLLL|______________||  |LLLLL|  |LLL|");
            Console.WriteLine(@"|LLL|  |LLL|______________|  |  |LLLLL|  |LLL|");
            Console.WriteLine(@"|LLL|__|L|______________|____|__|LLLLL|__|LLL|");
        }

        public static void draugrArt() {
            Game.RedTextWriteLine(@"                    ");
            Game.RedTextWriteLine(@"     /\      _______ ");
            Game.RedTextWriteLine(@"     ||      \_   _/  ");
            Game.RedTextWriteLine(@"     ||     \|0   0|/");
            Game.RedTextWriteLine(@"    _\/_   _(_  ^  _)_");
            Game.RedTextWriteLine(@"   ( () )  `\|''_''|/` ");
            Game.RedTextWriteLine(@"     {}      \_____/   ");
            Game.RedTextWriteLine(@"     ()     |  )=(  |  ");
            Game.RedTextWriteLine(@"     {}    | _/\=/\_ |  ");
        }
    } // end of AcsiiArt class

    // ------------------------------------------------------ MAIN PROGRAM ---------------------------------------------------------------------
    public static class Program
    {

        public static void Main(string[] args)
        {
           // Init 
           Game.StartGame();
           Game.NameCharacter();
           Game.CharacterRace();

           // Introduction 
           Console.WriteLine("------------------------------------------------------\n");
           Console.WriteLine("Your journey begins...\n");
           Console.WriteLine("------------------------------------------------------\n");
           Thread.Sleep(3000);  

           // First decision 
           Items.beverageChoice();

           Console.WriteLine("You collect your things and exit your shack situated in the forest. The road is long and you are starting to get tired and wonder why you were chosen for this quest.");
           Thread.Sleep(3000);
           AcsiiArt.woodsArt();
           Thread.Sleep(3000);

           // Second decision  
           Items.hoodedManChoice(); 

           // Third decision
           Items.stoneBridgeChoice(); 

           Console.WriteLine("\nYou make some distance between you and the bridge.. you walk for what seems for hours, snacking occasionally on your provisions you made for your journey.."); 
           
           // Forth decision
           Items.draugrChoice();

           Console.WriteLine("\nYou make your way out of the decrepit catacombs. You feel as though you can finally breathe when you exit into plains."); 
           Thread.Sleep(3000);
           Console.WriteLine("\nYou look into the distance and see the portal's silhouette.. your end goal. You contine you on your path."); 
           
           // Stops program from closing straight away
           Console.ReadLine();
        }
    }
}