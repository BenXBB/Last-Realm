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
            CyanTextWriteLine($"\n{Game.CharacterRaceStore.characterRace} {Game.CharacterNameStore}:     HP: {Game.CharacterRaceStore.characterHealth}     STR: {Game.CharacterRaceStore.characterStr}     WIT: {Game.CharacterRaceStore.characterWit}");
        }

        public static Boolean Karma = false;

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
           Console.WriteLine($"{CharacterNameStore}, You have been chosen to to help defend the realm of Vanaheim.");
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
            Console.WriteLine("\nIt's a Draugr! This event is chance based on your skills..");
            
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
                            Console.WriteLine("\nYou charge the creature with all your might, it stands no chance against you.");
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

        // --------------------------- 5. Dwarf Chest -------------------------------
        public static void dwarfChest() {
            Console.WriteLine("\nYou arrive in the plains of Vanaheim.. the air and land is rich with minerals.. you come across a small hut and see a Dwarf scrambling looking for something round the back."); 
            Thread.Sleep(5000);
            AcsiiArt.plainsHouseArt();
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            Console.WriteLine("\nThe Dwarf notices you as you approach.."); 
            Thread.Sleep(3000);
            Game.YellowTextWriteLine("\nAy there, you ain't seen a chest near this house by any chance have ye?!"); 
            Console.WriteLine("\nYou remember passing an object that looked as though its been quickly buried near the treeline...");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            
            Boolean validatePotSelection = false; 
            
                while (!validatePotSelection) {
                Game.CharacterStats();
                Random RandomDiceRoll = new Random();
                int potDiceRoll = RandomDiceRoll.Next(0, 100);
                Console.WriteLine($"\nYou choose to..");
                Console.WriteLine($"\nA. Point the Dwarf to the object.");
                Console.WriteLine($"\nB. Stay quiet and continue on your journey");
                Console.WriteLine($"\nC. Lie and keep the chest to yourself. {Game.rollDice("C")}% chance.");
                string potChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (potChoice == "A") {
                        Console.WriteLine("\nYou point the Dwarf to the chest he was looking for..");
                        Thread.Sleep(3000);
                            switch (Game.CharacterRaceStore.characterRace) {
                            case "Elf":
                            Game.YellowTextWriteLine("\nDwarf: Well damn, I thought for sure being an Elf you'd lie, thank ye!"); 
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Dwarf mutters to himself about how his kind deserved land over some stinking Elves, however..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Console.WriteLine("\nThe Dwarf gives you a Health potion from the chest..");
                            Game.GreenTextWriteLine("+ 1 HP\n");
                            ++Game.CharacterRaceStore.characterHealth;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Human":
                            Game.YellowTextWriteLine("\nDwarf: Ahhh and here I thought a Human would backstab me, thank ye!"); 
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Dwarf mutters to himself about how stupidly tall you are for a Human, however..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Console.WriteLine("\nThe Dwarf gives you a Health potion from the chest..");
                            Game.GreenTextWriteLine("+ 1 HP\n");
                            ++Game.CharacterRaceStore.characterHealth;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Dwarf":
                            Game.YellowTextWriteLine("\nDwarf: Ahh thank ye fellow Dwarf. You can only trust your own kind around here, ay?!"); 
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Dwarf mutters to himself about how much you look like his older deceased brother..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Console.WriteLine("\nYou rest with your fellow Dwarf and share a few ales together.. you leave the next morning feeling refreshed.");
                            Console.WriteLine("\nThe Dwarf gives you a Health potion from his chest and a pat on the back..");
                            Game.GreenTextWriteLine("+ 1 HP\n");
                            ++Game.CharacterRaceStore.characterHealth;
                            Game.GreenTextWriteLine("+ 1 Str\n");
                            ++Game.CharacterRaceStore.characterStr;
                            Game.YellowTextWriteLine($"\nDwarf: Good luck on your journey {Game.CharacterNameStore}, maybe our paths will cross again.."); 
                            Game.Karma = true;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            }
                        validatePotSelection = true;
                } else if (potChoice == "B") {
                        Console.WriteLine("\nYou decide that you do not have time for the Dwarf and continue on your journey..");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validatePotSelection = true;
                } else if (potChoice == "C") {
                        if (potDiceRoll < Game.rollDice("C")) {
                            Console.WriteLine("\nYou lie to the Dwarf about the whereabouts of the chest and you later return to dig up the chest and keep the loot to yourself..");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nInside are various potions which you soon store in your inventory..");
                            Game.GreenTextWriteLine("+ 1 HP");
                            ++Game.CharacterRaceStore.characterHealth;
                            Game.GreenTextWriteLine("+ 1 Str");
                            ++Game.CharacterRaceStore.characterStr;
                            Game.GreenTextWriteLine("+ 1 Wit");
                            ++Game.CharacterRaceStore.characterWit;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validatePotSelection = true;
                        } else {
                            Console.WriteLine("\nYou attempt to lie to the Dwarf..");
                            Thread.Sleep(3000);
                            Game.YellowTextWriteLine($"\nDwarf: You must think I'm dumb! I've seen your stealing eyes looking at my loot!"); 
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Dwarf attacks you but you're able to kill him in one stab to the chest..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Console.WriteLine("\nYour ponder your choice as you loot the Dwarf's body for a Health potion..");
                            Game.GreenTextWriteLine("+ 1 HP");
                            ++Game.CharacterRaceStore.characterHealth;
                            Game.RedTextWriteLine("- 1 Wit");
                            --Game.CharacterRaceStore.characterWit;
                            Game.validateGameOver();
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validatePotSelection = true;
                        }
                } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validatePotSelection = false;
                    }
                }
        }

        // --------------------------- 6. Fairy Choice -------------------------------
        public static void fairyChoice() {
            Console.WriteLine("\nAs you walk through the forest you are unsheathe your weapon.. you sense something approaching you.."); 
            Thread.Sleep(5000);
            Console.WriteLine("\nIt looks to be a distressed Fairy..");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            AcsiiArt.fairyArt();
            Console.WriteLine("\nThe creature begs for you to follow it.."); 
            Thread.Sleep(3000);
            Game.YellowTextWriteLine($"\nPlease {Game.CharacterRaceStore.characterRace}, I need your help! My companion is trapped under a tree branch.. We are too weak to move it!"); 
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            
            Boolean validateFairySelection = false; 
            
                while (!validateFairySelection) {
                Game.CharacterStats();
                Random RandomDiceRoll = new Random();
                int fairytDiceRoll = RandomDiceRoll.Next(0, 100);
                Console.WriteLine($"\nYou choose to..");
                Console.WriteLine($"\nA. Assist the creature");
                Console.WriteLine($"\nB. Continue on your journey, you dont have time to help rodents.");
                Console.WriteLine($"\nC. Kill the creature and use it's magic to empower yourself. {Game.rollDice("B")}% chance.");
                string fairyChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (fairyChoice == "A") {
                        Console.WriteLine("\nYou run to aid the creature..");
                        Thread.Sleep(3000);
                            switch (Game.CharacterRaceStore.characterRace) {
                            case "Elf":
                            Console.WriteLine("\nIt takes some time, however you are able to help move the branch with your weak Elven strength and the creature is saved!");
                            Game.YellowTextWriteLine($"\nFairy: Thank you {Game.CharacterRaceStore.characterRace}, you have saved their life!"); 
                            Thread.Sleep(3000);
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Console.WriteLine("\nThe Fairies bless your strength.. regaining the strength you lost helping the creatures.");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Human":
                            Console.WriteLine("\nIt takes some time, however you are able to help move the branch using your Human intellect by constructing a lever!");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe fairies are both astounded by your wits and pledge themselves to you. The magical strength between a Human and Fairy is strong!");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Game.YellowTextWriteLine($"\nFairy: You have our oath {Game.CharacterRaceStore.characterRace}, when you need us, we will be there!"); 
                            Game.GreenTextWriteLine("+ 1 HP");
                            Game.GreenTextWriteLine("+ 1 Str");
                            ++Game.CharacterRaceStore.characterHealth;
                            ++Game.CharacterRaceStore.characterStr;
                            Game.Karma = true;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Dwarf":
                            Console.WriteLine("\nYour Dwarven strength makes short work of the branch, you remove it easily..");
                            Game.YellowTextWriteLine($"\nFairy: Thank you {Game.CharacterRaceStore.characterRace}, you have saved their life!"); 
                            Thread.Sleep(3000);
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Console.WriteLine("\nThe Fairies bless your strength..");
                            Game.GreenTextWriteLine("+ 1 Str");
                            ++Game.CharacterRaceStore.characterHealth;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            }
                        validateFairySelection = true;
                } else if (fairyChoice == "B") {
                        Console.WriteLine("\nYou decide that you do not have time to assist and continue on your journey..");
                        Console.WriteLine("\nThe Fairy watches you leave, visibly upset.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validateFairySelection = true;
                } else if (fairyChoice == "C") {
                        if (fairytDiceRoll < Game.rollDice("B")) {
                            Console.WriteLine("\nYou grab the creature and siphon it's energy.. you feel empowered but ponder your decision.");
                            Thread.Sleep(3000);
                            Game.GreenTextWriteLine("+ 2 Str");
                            ++Game.CharacterRaceStore.characterStr;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validateFairySelection = true;
                        } else {
                            Console.WriteLine("\nYou attempt to grab the creature..");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Fairy senses your action.. It quickly dodges and casts a weakening spell on you.");
                            Game.YellowTextWriteLine($"\nFairy: No you don't!"); 
                            Thread.Sleep(3000);
                            Game.RedTextWriteLine("- 1 Str");
                            --Game.CharacterRaceStore.characterStr;
                            Game.RedTextWriteLine("- 1 Wit");
                            --Game.CharacterRaceStore.characterWit;
                            Game.validateGameOver();
                            Console.WriteLine("\nYou fall to your knee for a second before getting up and continuing on..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validateFairySelection = true;
                        }
                } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validateFairySelection = false;
                    }
                }
        }

         // --------------------------- 7. Night Elf -------------------------------
        public static void woodElfChoice() {
            if (Game.CharacterRaceStore.characterRace == "Elf") {
                Console.WriteLine("\nThis place almost feels familiar to your home in Alfheim..");
            }
            Console.WriteLine("\nYou walk through the forest and see what looks to be purple bloodprints.."); 
            Thread.Sleep(5000);
            Console.WriteLine("\nYou follow the tracks to what can be described as some kind of Elf.. The humanoid seems to be suffering from an injury, sitting at a campfire..");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            AcsiiArt.woodElfArt();
            Console.WriteLine("\nYou contemplate helping the creature.."); 
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            
            Boolean validateWoodElfSelection = false; 
            
                while (!validateWoodElfSelection) {
                Game.CharacterStats();
                Random RandomDiceRoll = new Random();
                int woodElfDiceRoll = RandomDiceRoll.Next(0, 150);
                Console.WriteLine($"\nYou choose to..");
                Console.WriteLine($"\nA. Bandage the Elf's wounds.");
                Console.WriteLine($"\nB. Leave. This is none of your business.");
                Console.WriteLine($"\nC. Kill the Elf. {Game.rollDice("B")}% chance.");
                string woodElfChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (woodElfChoice == "A") {
                        Console.WriteLine("\nYou walk up to the creature, you notice it's markings to be from the forest.. a Wood Elf.");
                        Thread.Sleep(3000);
                            switch (Game.CharacterRaceStore.characterRace) {
                            case "Elf":
                            Console.WriteLine("\nYou bandage the Elf's wounds whilst comparing its markings to your own, you feel somewhat connected to the Wood Elf.");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYou assist the Wood Elf onto his feet. You have never seen a Wood Elf before, you sense he has never seen a Light Elf before either..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Game.YellowTextWriteLine($"\nWood Elf: Ni 'lassui En"); 
                            Console.WriteLine("\nThe Wood Elf say's he owes you in his native tongue and transfers some of his life essence to you. You feel as though your paths will cross again some day..");
                            Game.GreenTextWriteLine("+ 1 HP");
                            Game.GreenTextWriteLine("+ 1 Str");
                            Game.Karma = true;
                            ++Game.CharacterRaceStore.characterHealth;
                            ++Game.CharacterRaceStore.characterStr;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Human":
                            Console.WriteLine("\nYou bandage the Elf's wounds. The Wood Elf is silent, unable to speak from it's wounds.");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYou assist the Wood Elf onto his feet..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Game.YellowTextWriteLine($"\nWood Elf: Ni 'lassui En"); 
                            Console.WriteLine("\nThe Wood Elf bids you thanks and shares some of their food with you.");
                            Game.GreenTextWriteLine("+ 1 HP");
                            ++Game.CharacterRaceStore.characterHealth;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Dwarf":
                            Console.WriteLine("\nYou bandage the Elf's wounds. The Wood Elf is silent, unable to speak from it's wounds.");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nYou assist the Wood Elf onto his feet..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            Game.YellowTextWriteLine($"\nWood Elf: Ni 'lassui En"); 
                            Console.WriteLine("\nThe Wood Elf bids you thanks and shares some of their food with you.");
                            Game.GreenTextWriteLine("+ 1 HP");
                            ++Game.CharacterRaceStore.characterHealth;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            }
                        validateWoodElfSelection = true;
                } else if (woodElfChoice == "B") {
                        Console.WriteLine("\nYou decide that it's best to stay away from the creature, after all, you don't know what it's capable of.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validateWoodElfSelection = true;
                } else if (woodElfChoice == "C") {
                        if (woodElfDiceRoll < Game.rollDice("B")) {
                            Console.WriteLine("\nYou kill the Elf while it's down and loot his items and food.");
                            Console.WriteLine("\n'It had to be done' you think to yourself, you need his items more than he does..");
                            Thread.Sleep(3000);
                            Game.GreenTextWriteLine("+ 1 HP");
                            ++Game.CharacterRaceStore.characterHealth;
                            Game.GreenTextWriteLine("+ 1 Wit");
                            ++Game.CharacterRaceStore.characterWit;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validateWoodElfSelection = true;
                        } else {
                            Console.WriteLine("\nYou attempt to kill the Elf");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Elf notices your action.. It quickly draw's his bow and fires an arrow at you.");
                            Game.YellowTextWriteLine($"\nElf: lamanwa!"); 
                            Thread.Sleep(3000);
                            Game.RedTextWriteLine("- 1 HP");
                            --Game.CharacterRaceStore.characterStr;
                            Game.RedTextWriteLine("- 1 Wit");
                            --Game.CharacterRaceStore.characterWit;
                            Game.validateGameOver();
                            Console.WriteLine("\nYou tear out the arrow and kill the Elf with one powerful blow.");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validateWoodElfSelection = true;
                        }
                } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validateWoodElfSelection = false;
                    }
                }
        }

        // --------------------------- 8. Wolf Choice -------------------------------
        public static void wolfChoice() {
            Console.WriteLine("\nYou find yourself hiking along the cold heights of a mountain to reach your destination.."); 
            Thread.Sleep(5000);
            Console.WriteLine("\nThe cold is unlike anything you've experienced before, occasionally rubbing your hands together in an attempt to stay warm.");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            Console.WriteLine("\nYou see a natural cave hidden in the mountain and decide to take shelter for a while and gather your strength.");
            Console.WriteLine("\nYou sense something in the darkness of the cave..");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            AcsiiArt.wolfArt();
            Console.WriteLine("\nA mountain wolf edges slowly towards you."); 
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            
            Boolean validateWolfSelection = false; 
            
                while (!validateWolfSelection) {
                Game.CharacterStats();
                Random RandomDiceRoll = new Random();
                int wolfDiceRoll = RandomDiceRoll.Next(0, 80);
                Console.WriteLine($"\nYou choose to..");
                Console.WriteLine($"\nA. Leave the cave immediately.");
                Console.WriteLine($"\nB. Stay still.");
                Console.WriteLine($"\nC. Subdue the wolf. {Game.rollDice("B")}% chance.");
                string mountainWolfChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (mountainWolfChoice == "A") {
                        Console.WriteLine("\nYou leave the cave - the Vanaheim mountain wolves are a huge threat, and there may of been more of them in the cave!");
                        Thread.Sleep(3000);
                        validateWolfSelection = true;
                } else if (mountainWolfChoice == "B") {
                        Boolean validateWolfSmellSelection = false; 
                        Console.WriteLine("\nYou attempt to stay completely still, hoping the wolf ignores you.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        Console.WriteLine("\nThe wolf comes up to you and smells you, you feel it's yellow gaze piercing your soul.");
                        while (!validateWolfSmellSelection) {
                            Console.WriteLine("Your action..");
                            Console.WriteLine($"\nA. Attempt to run out the cave. 50% chance.");
                            Console.WriteLine($"\nB. Continue to stay still. 50% chance.");
                            string mountainWolfSmellChoice = Console.ReadLine().ToUpper();
                            Thread.Sleep(3000);
                            if (mountainWolfSmellChoice == "A") {
                                Console.WriteLine("\nYour wits tell you to get up and make an escape - mountain wolves are not to be messed with!");
                                validateWolfSmellSelection = true;
                            } else if (mountainWolfSmellChoice == "B") {
                                Console.WriteLine("\nYou contine to stay still.. mountain wolves are very observant creatures - it notices a drop of sweat running down your face..");
                                Console.WriteLine("\nPress 'Enter' to continue..");
                                Console.ReadLine();
                                Console.WriteLine("\nThis is enough to make the wolf bark at you. You lose your cool and make a run for the exit, narrowly escaping the beast and losing some of your ego in the process..");
                                Game.RedTextWriteLine("- 1 Wit");
                                --Game.CharacterRaceStore.characterWit;
                                validateWolfSmellSelection = true;
                            } else {
                                Console.WriteLine("You must pick A or B...");
                                validateWolfSmellSelection = false;
                            }
                        }
                        validateWolfSelection = true;
                } else if (mountainWolfChoice == "C") {
                        if (wolfDiceRoll < Game.rollDice("B")) {
                            Console.WriteLine("\nYou quickly get up and subdue the wolf.. carefully not killing it as to not anger the Wolf God Fenrir..");
                            Console.WriteLine("\n'It had to be done' you say to yourself, you had to protect yourself.");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validateWolfSelection = true;
                        } else {
                            Console.WriteLine("\nYou attempt to subdue the wolf..");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Wolf notices your action.. It quickly attacks you with it's claws.");
                            Game.RedTextWriteLine("- 1 HP");
                            --Game.CharacterRaceStore.characterHealth;
                            Game.validateGameOver();
                            Console.WriteLine("\nYou run out of the cave, slipping on the frozen path outside..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            validateWolfSelection = true;
                        }
                } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validateWolfSelection = false;
                    }
                }
        }

            // --------------------------- 9. Raven Choice -------------------------------
        public static void ravenChoice() {
            Thread.Sleep(5000);
            Console.WriteLine("\nYou continue up the branch of the Realm tree towards the portal.. A Raven swoops by you, narrowly missing your face.."); 
            Thread.Sleep(5000);
            Console.WriteLine("\nSoon, another Raven flies by you.. and another one.. until you are swarmed by a murder of Ravens.");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            Console.WriteLine("\nYou stand your ground as the Ravens seem to all come together and morph into a humanoid figure..");
            Console.WriteLine("\nYou recongise the figure to be the All-Father, Odin. He stands tall in front of you, with one glowing eye.");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            AcsiiArt.odinArt();
            Game.YellowTextWriteLine($"Turn back, {Game.CharacterNameStore}.. this battle between the Aesir and Vanir does not concern you."); 
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            
            Boolean validateRavenSelection = false; 
            
                while (!validateRavenSelection) {
                Game.CharacterStats();
                Console.WriteLine($"\nYou choose to..");
                Console.WriteLine($"\nA. Silently draw your weapon..");
                Console.WriteLine($"\nB. Shout obscenities at him..");
                Console.WriteLine($"\nC. Retire - You cannot fight a god..");
                string odinChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (odinChoice == "A") {
                        Console.WriteLine("\nYou draw your weapon.. ready for battle with a god..");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nOdin watches you in contemptment and chuckles to himself as he wields 'Gungnir'.. his spear.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        Console.WriteLine("\nAs you prepare to make your strike you hear someone or something shout from the distance.. you look in the direction of the sound and see someone approaching.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        AcsiiArt.freyaArt();
                        Thread.Sleep(3000);
                        Console.WriteLine("\nIt's Freya! The leader of the Vanir & the one that sent you on this journey.");
                        Game.YellowTextWriteLine($"Freya: {Game.CharacterNameStore}! You must make it to the portal and destroy it, I will deal with Odin!"); 
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        Console.WriteLine("\nOdin attempts to strike you with his spear, but Freya was able to parry the blow.");
                        Console.WriteLine("\nYou continue past the two who were once husband and wife.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validateRavenSelection = true;
                } else if (odinChoice == "B") {
                        Console.WriteLine("\nYou hurl insults at the god, hoping to get him to back down.");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nOdin watches you in contemptment and chuckles to himself as he wields 'Gungnir'.. his spear.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        Console.WriteLine("\nYour plan doesnt seem to be working.. however you hear someone shouting.. you look in the direction of the sound and see someone approaching..");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        AcsiiArt.freyaArt();
                        Thread.Sleep(3000);
                        Console.WriteLine("\nIt's Freya! The leader of the Vanir & the one that sent you on this journey.");
                        Game.YellowTextWriteLine($"Freya: {Game.CharacterNameStore}! You must make it to the portal and destroy it, I will deal with Odin!"); 
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        Console.WriteLine("\nOdin attempts to strike you with his spear, but Freya was able to parry the blow.");
                        Console.WriteLine("\nYou continue past the two who were once husband and wife.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validateRavenSelection = true;
                } else if (odinChoice == "C") {
                        Console.WriteLine("\nYou realise you cannot fight a god and start to retreat..");
                        Console.WriteLine("\nOdin watches you with his arms folded..");
                        Game.YellowTextWriteLine($"Wise choice {Game.CharacterNameStore}.."); 
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        Console.WriteLine("\nAs you prepare to make your retreat, you hear someone or something shout from the distance.. you look in the direction of the sound and see someone approaching.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        AcsiiArt.freyaArt();
                        Thread.Sleep(3000);
                        Console.WriteLine("\nIt's Freya! The leader of the Vanir & the one that sent you on this journey.");
                        Game.YellowTextWriteLine($"Freya: {Game.CharacterNameStore}! You must make it to the portal and destroy it, I will deal with Odin!"); 
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        Console.WriteLine("\nOdin attempts to strike you with his spear, but Freya was able to parry the blow.");
                        Console.WriteLine("\nYou continue past the two who were once husband and wife.");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validateRavenSelection = true;
                } else {
                        Console.WriteLine("You must pick A, B or C...");
                        validateRavenSelection = false;
                    }
                }
        }

                
        // --------------------------- 10. End Choice -------------------------------
        public static void endChoice() {
            Thread.Sleep(5000);
            Console.WriteLine("\nYou come face to face with the portal.. the one thing that is waging war between the realm of Aesir and the Vanir.. The sky is completely black.."); 
            Thread.Sleep(5000);
            Console.WriteLine("\nYou ready yourself to topple down the steep contraption..");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            Console.WriteLine("\nBefore you can destroy the portal, something emerges from it.. you ready yourself for your final battle..");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            AcsiiArt.endBattleArt();
            Console.WriteLine("\nA warrior like yourself comes from the portal, you both know you are destined to fight one another, both picked as a champion by Odin & Freya.");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            
            Boolean validateEndChoiceSelection = false; 
            
                while (!validateEndChoiceSelection) {
                Game.CharacterStats();
                Console.WriteLine($"\nYour action..");
                Console.WriteLine($"\nA. Fight.");
                Console.WriteLine($"\nB. Reason. 15% chance");
                string endFightChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (endFightChoice == "A") {
                        Console.WriteLine("\nYou draw your weapon.. ready to fight what seems to be your nemesis..");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nYou battle for what seems for hours and you are both tired.. the final stage of the battle commences..");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validateEndChoiceSelection = true;
                } else if (endFightChoice == "B") {
                        Console.WriteLine("\nYou attempt to reason with the warrior..");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nIt is no use.. you are both destined to fight each other..");
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        validateEndChoiceSelection = true;
                } else {
                        Console.WriteLine("You must pick A or B...");
                        validateEndChoiceSelection = false;
                    }
                }

            Boolean validateEndFightSelection = false; 
            int VegvisirChance = 1;
                while (!validateEndFightSelection) {
                Game.CharacterStats();
                Console.WriteLine($"\nYour action..");
                Console.WriteLine($"\nA. Attack.");
                Console.WriteLine($"\nB. Block.");
                string endGameChoice = Console.ReadLine().ToUpper();
                Thread.Sleep(3000);

                if (endGameChoice == "A") {
                        Console.WriteLine("\nYou attack the warrior..");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nYour swords clash and you both strike each other at the same time.");
                        Game.RedTextWriteLine("- 3 Str");
                        --Game.CharacterRaceStore.characterStr;
                        --Game.CharacterRaceStore.characterStr;
                        --Game.CharacterRaceStore.characterStr;
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        if (Game.CharacterRaceStore.characterStr < 1 && VegvisirChance == 1) {
                            Console.WriteLine("\nYou are out of strength.. however you use the Vegvisir pendant that Mimir gave you at the start of your journey to re-energise yourself.");
                            VegvisirChance = 0;
                            Game.GreenTextWriteLine("+ 1 HP");
                            Game.GreenTextWriteLine("+ 1 Str");
                            ++Game.CharacterRaceStore.characterHealth;
                            Game.CharacterRaceStore.characterStr = 1;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                        } else if (Game.CharacterRaceStore.characterStr < 1) {
                            validateEndFightSelection = true;
                        }
                } else if (endGameChoice == "B") {
                        Console.WriteLine("\nYou defend yourself..");
                        Thread.Sleep(3000);
                        Console.WriteLine("\nYou block most of the blow from the warrior..");
                        Game.RedTextWriteLine("- 3 HP");
                        --Game.CharacterRaceStore.characterHealth;
                        --Game.CharacterRaceStore.characterHealth;
                        --Game.CharacterRaceStore.characterHealth;
                        Console.WriteLine("\nPress 'Enter' to continue..");
                        Console.ReadLine();
                        if (Game.CharacterRaceStore.characterHealth < 1 && VegvisirChance == 1) {
                            Console.WriteLine("\nYou are out of HP.. however you use the Vegvisir pendant that Mimir gave you at the start of your journey to re-energise yourself and carry on fighting.");
                            VegvisirChance = 0;
                            Game.GreenTextWriteLine("+ 1 HP");
                            Game.GreenTextWriteLine("+ 1 Str");
                            Game.CharacterRaceStore.characterHealth = 1;
                            ++Game.CharacterRaceStore.characterStr;
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                        } else if (Game.CharacterRaceStore.characterHealth < 1) {
                            validateEndFightSelection = true;
                        }
                } else {
                        Console.WriteLine("You must pick A or B...");
                        validateEndFightSelection = false;
                    }
                }

            Console.WriteLine("\nYou are out of energy.. you fall to your knees and look up at the warrior, visibly tired from the fight too.");
            Console.WriteLine("\nThe warrior raises his weapon for the final blow, you replay your life, especially your journey through your mind.. 'was it worth it?'");
            Console.WriteLine("\nPress 'Enter' to continue..");
            Console.ReadLine();
            
            if (Game.Karma == true) {
                switch (Game.CharacterRaceStore.characterRace) {
                            case "Elf":
                            Console.WriteLine("\nJust as you think this is it for you, the Wood Elf you helped before arrives just in time!");
                            Thread.Sleep(3000);
                            Game.YellowTextWriteLine("\nElf: 'auta-lenna!");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            AcsiiArt.endBattleElf();
                            Console.WriteLine("\nThe Wood Elf fires an arrow that deflects the blow of the Warrior.");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Warrior makes a hasty retreat back through the portal..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Human":
                            Console.WriteLine("\nJust as you think this is it for you, the Fairies you helped before arrive just in time!");
                            Thread.Sleep(3000);
                            Game.YellowTextWriteLine("\nFairy: 'Allo-Lustra!");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            AcsiiArt.fairyArt();
                            Console.WriteLine("\nThe Fairies use a spell on you to allow you to quickly regain your strength and parry the blow from the Warrior!");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Warrior makes a hasty retreat back through the portal..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            case "Dwarf":
                            Console.WriteLine("\nJust as you think this is it for you, the Dwarf you helped before arrives just in time!");
                            Thread.Sleep(3000);
                            Game.YellowTextWriteLine("\nDwarf: 'Not on my watch ye vermin!");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            AcsiiArt.endBattleDwarf();
                            Console.WriteLine("\nThe Dwarf jumps in to parry the strike of the warrior.");
                            Thread.Sleep(3000);
                            Console.WriteLine("\nThe Warrior makes a hasty retreat back through the portal..");
                            Console.WriteLine("\nPress 'Enter' to continue..");
                            Console.ReadLine();
                            break;
                            }
                } else if (Game.Karma == false) {
                    Console.WriteLine("\nJust as you think this is it for you, Mimir comes just in time!");
                    Thread.Sleep(3000);
                    Game.YellowTextWriteLine("\nMimir: 'Hold on!");
                    Console.WriteLine("\nPress 'Enter' to continue..");
                    Console.ReadLine();
                    AcsiiArt.mimirArt();
                    Console.WriteLine("\nMimir blesses your body, allowing you enough strength to parry the attack!");
                    Thread.Sleep(3000);
                    Console.WriteLine("\nThe Warrior makes a hasty retreat back through the portal..");
                    Console.WriteLine("\nPress 'Enter' to continue..");
                    Console.ReadLine();
                }

        Console.WriteLine("\nYour ally helps you to your feet..");
        Console.WriteLine("\nYou both take a look at the portal.. You know what to do...");
        Console.WriteLine("\nPress 'Enter' to continue..");
        Console.ReadLine();
        AcsiiArt.portal();
        Console.WriteLine("\nThe portal is bigger than you expected.. Press 'Enter' to continue..");
        Console.ReadLine();
        }

        // --------------------------- 11. Epilogue -------------------------------
        public static void epilogue() {
           Console.WriteLine("\nYou tear down the portal.. a great big flash of light stuns you as the portal closes and the sky turns back to blue.."); 
           Thread.Sleep(3000);  
           Console.WriteLine("\nPeace has once again returned back to the realm"); 
           Console.WriteLine("\nPress 'Enter' to continue..");
           Console.ReadLine();
           Console.WriteLine("\nFreya returns from her battle.. visibly beaten"); 
           Game.YellowTextWriteLine($"\nThank you {Game.CharacterNameStore}.. if not for you we would of never brought peace to this Realm.. you have my thanks..");
           AcsiiArt.celebration();
           Console.WriteLine("\nPress 'Enter' to continue..");
           Console.ReadLine();
           AcsiiArt.endCinematic();
           Console.WriteLine("\nPress 'Enter' to continue..");
           Console.ReadLine();
           System.Environment.Exit(0);
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
            Console.WriteLine(@"  `||      \   |!   . )( ( )       (- )   )   . ~| |   /V""""V\     | ");
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

        public static void plainsHouseArt() {
            Game.GreenTextWriteLine(@"////\\\\///\\\\\ ///\\\//\//\\//\\\ /\///\\//\\ ///\\\/////\\///\\\  /\\");
            Game.GreenTextWriteLine(@"////\\\\\//\\\\\////\\\\////\\\/\\\//\\//\///\\\///\\\\// /\ ///\\\\//\\");
            Game.GreenTextWriteLine(@"////\\\\   \\\\/////\\\\////\\\\\\///\\\/////\\\\//\\\\\ /\\\ //\\\///\\");
            Game.GreenTextWriteLine(@"////\\\  O> \\\/////\\\/////\\\\\////\\\\////\\\\\/\\\\ /\\\\\ /\\////\\");
            Game.GreenTextWriteLine(@"////   _,/)_  \/ __ \\\/////\\\\/////\\\\\///\\\\\/\\\ /UU\\\\\ \/////\\");
            Game.GreenTextWriteLine(@" ,--==|__<__|===/ / \\//////\\\\/////\\\\\///\\\\\\\\ /UUUU\\\\\ /////\\");
            Game.GreenTextWriteLine(@"   ||  `.``    '-' || //////\\\//////\\\\\\//\\\\\\| /UUUUUU\\\/|/////\\");
            Game.GreenTextWriteLine(@"   ||    `._       ||      ||  //////\\\\\\ ||    ||/UUUUUUUU\/ |    ||");
            Game.GreenTextWriteLine(@"            `--.__         ||       ||      ||      |,--. __ |/||    ||");
            Game.GreenTextWriteLine(@"_____             ``--..__          ||              ||__|| /|||/|       ");
            Game.GreenTextWriteLine(@"     ``--.._              ```---...___         _    | _  || || /   _");
            Game.GreenTextWriteLine(@"  ~         `-.                       ````----((=   |(:)_|| ||/  _( )");
            Game.GreenTextWriteLine(@"      ~~ ~     \                                __      / |/|   (    )");
            Game.GreenTextWriteLine(@"    ~  ><> ~    \  '                '          (  )   ,'    ;  (,__)_)");
            Game.GreenTextWriteLine(@"~     ~~~~       |           '            '   |_ | ),'       '        '");
        }

        public static void fairyArt() {
            Game.DarkBlueTextWriteLine(@"                   ,_  .--.");
            Game.DarkBlueTextWriteLine(@"             , ,   _)\/    ;--.");
            Game.DarkBlueTextWriteLine(@"     . ' .    \_\-'   |  .'    \");
            Game.DarkBlueTextWriteLine(@"    -= * =-   (.-,   /  /       |");
            Game.DarkBlueTextWriteLine(@"     ' .\'    ).  ))/ .'   _/\ /");
            Game.DarkBlueTextWriteLine(@"         \_   \_  /( /     \ /(");
            Game.DarkBlueTextWriteLine(@"         /_\ .--'   `-.    //  \");
            Game.DarkBlueTextWriteLine(@"         ||\/        , '._//    |");
            Game.DarkBlueTextWriteLine(@"         ||/ /`(_ (_,;`-._/     /");
            Game.DarkBlueTextWriteLine(@"         \_.'   )   /`\       .'");
            Game.DarkBlueTextWriteLine(@"              .' .  |  ;.   /`");
            Game.DarkBlueTextWriteLine(@"             /      |\(  `.(");
            Game.DarkBlueTextWriteLine(@"            |   |/  | `    `");
            Game.DarkBlueTextWriteLine(@"            |   |  /");
            Game.DarkBlueTextWriteLine(@"            |   |.'");
            Game.DarkBlueTextWriteLine(@"         __/'  /");
            Game.DarkBlueTextWriteLine(@"     _ .'  _.-`");
            Game.DarkBlueTextWriteLine(@"  _.` `.-;`/");
        }

        public static void woodElfArt() {
             Game.GreenTextWriteLine(@"           (               |\,---/|");
             Game.GreenTextWriteLine(@"            )              \ -,- |!");
             Game.GreenTextWriteLine(@"           (  (             \ =__/");
             Game.GreenTextWriteLine(@"               )             ,'-'.");
             Game.GreenTextWriteLine(@"         (    (  ,,      _.__|/ /|");
             Game.GreenTextWriteLine(@"          ) /\ -((      ((_|___/ |");
             Game.GreenTextWriteLine(@"        (  // | (`'      ((  `'--|");
             Game.GreenTextWriteLine(@"      _ -.;_/ \\--._      \\ \-._/.");
             Game.GreenTextWriteLine(@"     (_;-// | \ \-'.\    <_,\_\`--'|");
             Game.GreenTextWriteLine(@"     ( `.__ _  ___,')      <_,-'__,'");
             Game.GreenTextWriteLine(@"      `'(_ )_)(_)_)'");
        }

        public static void wolfArt() {
            Game.RedTextWriteLine(@"           _        _");
            Game.RedTextWriteLine(@"          /\\     ,'/|");
            Game.RedTextWriteLine(@"        _|  |\-'-'_/_/");
            Game.RedTextWriteLine(@"   __--'/`           \");
            Game.RedTextWriteLine(@"       /              \");
            Game.RedTextWriteLine(@"      /        'o.  |o'|");
            Game.RedTextWriteLine(@"      |              \/");
            Game.RedTextWriteLine(@"       \_          ___\");
            Game.RedTextWriteLine(@"         `--._`.   \;//");
            Game.RedTextWriteLine(@"              ;-.___,'");
            Game.RedTextWriteLine(@"             /");
            Game.RedTextWriteLine(@"           ,'");
        }

        public static void odinArt() {
            Game.DarkBlueTextWriteLine(@"      __      _");
            Game.DarkBlueTextWriteLine(@"     /__\__  //");
            Game.DarkBlueTextWriteLine(@"    //_____\///");
            Game.DarkBlueTextWriteLine(@"   _| /-_-\)|/_");
            Game.DarkBlueTextWriteLine(@"  (___\ _ //___\");
            Game.DarkBlueTextWriteLine(@"  (  |\\_/// * \\");
            Game.DarkBlueTextWriteLine(@"   \_| \_((*   *))");
            Game.DarkBlueTextWriteLine(@"   ( |__|_\\  *//");
            Game.DarkBlueTextWriteLine(@"   (o/  _  \_*_/");
            Game.DarkBlueTextWriteLine(@"   //\__|__/\");
            Game.DarkBlueTextWriteLine(@"  // |  | |  |");
            Game.DarkBlueTextWriteLine(@" //  _\ | |___)");
            Game.DarkBlueTextWriteLine(@"//  (___|");
        }

        public static void freyaArt() {
            Game.GreenTextWriteLine(@"   //.---.    .-'.");
            Game.GreenTextWriteLine(@"( (-/==^==.  /    ) ))");
            Game.GreenTextWriteLine(@"  /|))è é()./   .'");
            Game.GreenTextWriteLine(@" ('-((\_/( ))..' /");
            Game.GreenTextWriteLine(@"  \ '-;_.-. ) ))");
            Game.GreenTextWriteLine(@"   '-(_ _)_\ ) )).'");
            Game.GreenTextWriteLine(@"    / ) (/_ ) \");
            Game.GreenTextWriteLine(@"(( ( /\_/\,/|  ) ))");
            Game.GreenTextWriteLine(@"    /  .  '.'.' ");
            Game.GreenTextWriteLine(@"   (  .\  . '.___.");
            Game.GreenTextWriteLine(@"    \_| \  '.___/");
            Game.GreenTextWriteLine(@"     \'._;.___) ");
            Game.GreenTextWriteLine(@"      \_|-.\ |   ");
            Game.GreenTextWriteLine(@"       '--,-\'.");
            Game.GreenTextWriteLine(@"          |/ \ )");
            Game.GreenTextWriteLine(@"        ._/   \|_");
            Game.GreenTextWriteLine(@"               \ )");
            Game.GreenTextWriteLine(@"                \|");
            Game.GreenTextWriteLine(@"               ._)");
        }

        public static void endBattleArt() {
            Game.RedTextWriteLine(@"                 /|");
            Game.RedTextWriteLine(@"  _______________)|.. ");
            Game.RedTextWriteLine(@"<'______________<(,_|) ");
            Game.RedTextWriteLine(@"           .((()))| ))");
            Game.RedTextWriteLine(@"           (======)| \ ");
            Game.RedTextWriteLine(@"          ((( ' '()|_ \");
            Game.RedTextWriteLine(@"         '()))(_)/_/ ' )");
            Game.RedTextWriteLine(@"         .--/_\ /(  /./");
            Game.RedTextWriteLine(@"        /'._.--\ .-(_/ ");
            Game.RedTextWriteLine(@"       / / )\___:___) ");
            Game.RedTextWriteLine(@"      ( -.'.._  |  /");
            Game.RedTextWriteLine(@"       \  \_\ ( | )");
            Game.RedTextWriteLine(@"        '. /\)_(_)|");
            Game.RedTextWriteLine(@"          '-|  XX |");
            Game.RedTextWriteLine(@"           %%%%%%%%");
            Game.RedTextWriteLine(@"          / %%%%%%%\");
            Game.RedTextWriteLine(@"         ( /.-'%%%. \ ");
            Game.RedTextWriteLine(@"        /(.'   %%\ :|");
            Game.RedTextWriteLine(@"       / ,|    %  ) )");
            Game.RedTextWriteLine(@"     _|___)   %  (__|_");
            Game.RedTextWriteLine(@"     )___/       )___(");
            Game.RedTextWriteLine(@"      |x/         \ >");
            Game.RedTextWriteLine(@"      |x)         / '.");
            Game.RedTextWriteLine(@"      |x\       _(____''.__");
            Game.RedTextWriteLine(@"    --\ -\--");
            Game.RedTextWriteLine(@"     --\__|--");
        }

        public static void endBattleElf() {
            Game.GreenTextWriteLine(@"     __                                 /                  `|.");
            Game.GreenTextWriteLine(@"      -\                              /                     |.");
            Game.GreenTextWriteLine(@"        \\                          /                       |.");
            Game.GreenTextWriteLine(@"          \\                      /                         |.");
            Game.GreenTextWriteLine(@"           \|                   /                           |\");
            Game.GreenTextWriteLine(@"             \#####\          /                             ||");
            Game.GreenTextWriteLine(@"         ==###########>     /                               ||");
            Game.GreenTextWriteLine(@"          \##==      \    /                                 ||");
            Game.GreenTextWriteLine(@"     ______ =       =|__/___                                ||");
            Game.GreenTextWriteLine(@" ,--' ,----`-,__ ___/'  --,-`-==============================##==========>");
            Game.GreenTextWriteLine(@"\               '        ##_______ ______   ______,--,____,=##,__");
            Game.GreenTextWriteLine(@" `,    __==    ___,-,__,--'#'  ==='      `-'              | ##,-/");
            Game.GreenTextWriteLine(@"   `-,____,---'       \####\              |        ____,--\_##,/");
            Game.GreenTextWriteLine(@"       #_              |##   \  _____,---==,__,---'         ##");
            Game.GreenTextWriteLine(@"        #              ]===--==\                            ||");
            Game.GreenTextWriteLine(@"        #,             ]         \                          ||");
            Game.GreenTextWriteLine(@"         #_            |           \                        ||");
            Game.GreenTextWriteLine(@"          ##_       __/'             \                      ||");
            Game.GreenTextWriteLine(@"           ####='     |                \                    |/");
            Game.GreenTextWriteLine(@"            ###       |                  \                  |.");
        }

        public static void endBattleDwarf() {
            Game.GreenTextWriteLine(@"                        dMMm.");
            Game.GreenTextWriteLine(@"                      dMMP'_\---.");
            Game.GreenTextWriteLine(@"                      _| _  p ;88;`.");
            Game.GreenTextWriteLine(@"                   ,db; p >  ;8P|  `.");
            Game.GreenTextWriteLine(@"                   (``T8b,__,'dP |   |");
            Game.GreenTextWriteLine(@"                   |   `Y8b..dP  ;_  |");
            Game.GreenTextWriteLine(@"                   |    |`T88P_ /  `\;");
            Game.GreenTextWriteLine(@"                   :_.-~|d8P'`Y/    /");
            Game.GreenTextWriteLine(@"                    \_   TP    ;   7`\");
            Game.GreenTextWriteLine(@"         ,,__        >   `._  /'  /   `\_");
            Game.GreenTextWriteLine(@"         `._ """"~~~~------|`\;' ;     ,'");
            Game.GreenTextWriteLine(@"            '''~~~-----~~~'\__[|;' _.-'  `\");
            Game.GreenTextWriteLine(@"                   ;--..._     .-'-._     ;");
            Game.GreenTextWriteLine(@"                   /      /`~~''   ,'`\_ ,/");
            Game.GreenTextWriteLine(@"                  ;_    /'        /    ,/");
            Game.GreenTextWriteLine(@"                  | `~-l         ;    /");
        }

        public static void portal() {
            Game.CyanTextWriteLine(@"  `XXX' T               ~.                         \                 /                           .~             T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |                 ~.                        .               -                          .~               | ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX                   ~.                       \             /                         .~                 XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX                     ~.                      .6&&&&&&&&&A,                        .~                   XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T                       ~.             .6&&&&&&&&&&&&&&&&&&&&&&&A,               .~                     T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |._                       ~.     .6&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&A,       .~                     _.| ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX  ~-._                     ~.6&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&A,~                   _.-~  XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX      ~-._              6&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&A              _.-~      XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T          ~-._       6&&&&&&&&&&&&&&&&&&/'''''''''''''''''''''\&&&&&&&&&&&&&&&&&&A       _.-~          T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |              ~-._ 6&&&&&&&&&&&&&&&/                               \&&&&&&&&&&&&&&&A _.-~              | ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX                  &&&&&&&&&&&&&/                                       \&&&&&&&&&&&&&                  XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX                  &&&&&&&&&&/          ,              __._    _.'         \&&&&&&&&&&                  XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T                  && $                                    `-.'                   $ &&                  T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |~~..__            &&$         _.      .                                           $&&            __..~~| ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX      ~~..__      && $       ~                  _ -'- _                          $ &&      __..~~      XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX            ~~..__&&$     .-~             _ - '   .-.   ' - _        *            $&&__..~~            XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T                  && $                _~~   .    /7 t\  +     ~~_                $ &&                  T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |                  &&$                ._  -  _   /7   t\  .   _  _.         *'     $&&                  | ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX                  && $     *           '- , _  /7     t\  _ , -'                 $ &&                  XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX                  &&$                         | |     | |                         $&&                  XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T                  && $                        | |_   _| |                        $ &&                  T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |_________________.&&$  . .     . _ .  _    _.-| | /'\ | |-._     _    . ,  _  . . $&&._________________| ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX                  && $__________________.-~   |_|/___\|_|   ~-.__________________$ &&                  XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX                  &&$                  |'-._               _.-'|              ~~  $&&                  XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T                  && $          ~      |####'-._       _.-'####|    ~~_          $ &&                  T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |                  &&$   ~              |#   #.-~  .    ~-.#   #|                  $&&                  | ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX                  && $            ~~   |# .-~   __  _  .  ~-. #|                 $ &&                  XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX            __..~~&&$       ~~-        .-~  __       __  .   ~-.         ~        $&&~~..__            XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T      __..~~      && $              .-~  _     ___        __    ~-.              $ &&      ~~..__      T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX  |__..~~            &&$            .-~      ___         ___      __  ~-.      _~    $&&            ~~..__| ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX                  && $        .-~    ___        ___         ___       ~-.        $ &&                  XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX                  &&$    ~~.-~____        ____        ____        ____   ~-.      $&&                  XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T                  && $  .-~        ________         ________           ___  ~-.  $ &&                  T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |                _.&&$.-~                                                       ~-.$&&._                | ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXX            _.-~ &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& ~-._            XXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX        _.-~   _&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&_   ~-._        XXX. ,XXX");
            Game.CyanTextWriteLine(@"  `XXX' T    _.-~     -'-------------------------------------------------------------------------`-     ~-._    T `XXX'");
            Game.CyanTextWriteLine(@"  ,XXX. |_.-~       _&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&_       ~-._| ,XXX.");
            Game.CyanTextWriteLine(@"XXX` 'XXXT        -'---------------------------------------------------------------------------------`-        TXXX` 'XXX");
            Game.CyanTextWriteLine(@"XXX. ,XXX|      _&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&_      |XXX. ,XXX");
            Game.CyanTextWriteLine(@"XXXXXXXXX!____-'-----------------------------------------------------------------------------------------`-____!XXXXXXXXX");
            Game.CyanTextWriteLine(@"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX               ");
        }

        public static void celebration() {
            Game.GreenTextWriteLine(@"         .* *.               `o`o`");
            Game.GreenTextWriteLine(@"         *. .*              o`o`o`o      ^,^,^");
            Game.GreenTextWriteLine(@"           * \               `o`o`     ^,^,^,^,^");
            Game.GreenTextWriteLine(@"              \     ***        |       ^,^,^,^,^");
            Game.GreenTextWriteLine(@"               \   *****       |        /^,^,^");
            Game.GreenTextWriteLine(@"                \   ***        |       /");
            Game.GreenTextWriteLine(@"    ~@~*~@~      \   \         |      /");
            Game.GreenTextWriteLine(@"  ~*~@~*~@~*~     \   \        |     /");
            Game.GreenTextWriteLine(@"  ~*~@smd@~*~      \   \       |    /     #$#$#        .`'.;.");
            Game.GreenTextWriteLine(@"  ~*~@~*~@~*~       \   \      |   /     #$#$#$#   00  .`,.',");
            Game.GreenTextWriteLine(@"    ~@~*~@~ \        \   \     |  /      /#$#$#   /|||  `.,'");
            Game.GreenTextWriteLine(@"_____________\________\___\____|_/______/_________|\/\___||______");
        }

        public static void endCinematic() {
            Game.CyanTextWriteLine(@"You have completed              O");
            Game.CyanTextWriteLine(@"             LAST-REALM      ,-.|____________________");
            Game.CyanTextWriteLine(@"Thank you for playing     O==+-|(>-------- --  -     .>");
            Game.CyanTextWriteLine(@"       This story has many   `- |'''''''d88b''''''''''");
            Game.CyanTextWriteLine(@"different                     | O     d8P 88b");
            Game.CyanTextWriteLine(@"        Endings...            |  \    88= ,=88");
            Game.CyanTextWriteLine(@"See if you                    |   )   9b _. 88b");
            Game.CyanTextWriteLine(@"find and complete them all    `._ `.   8`--'888");
            Game.CyanTextWriteLine(@"                               \--'\   `-8___");
            Game.CyanTextWriteLine(@"                                \`-.              \");
            Game.CyanTextWriteLine(@"                                 `. \ -       _ / <");
            Game.CyanTextWriteLine(@"                                  \ `---   ___/|_-\");
            Game.CyanTextWriteLine(@"                                   |._      _. |_-|");
            Game.CyanTextWriteLine(@"                                    \  _     _  /.-\");
            Game.CyanTextWriteLine(@"                                     | -! . !- ||   |");
            Game.CyanTextWriteLine(@"                                     \ '| ! |' /\   |");
            Game.CyanTextWriteLine(@"                                      =oO)X(Oo=  \  /");
            Game.CyanTextWriteLine(@"                                      888888888   < \");
            Game.CyanTextWriteLine(@"                                     d888888888b  \_/       ");
            Game.CyanTextWriteLine(@"                                     88888888888");
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

           // Fifth decision
           Items.dwarfChest();

           Console.WriteLine("\nYou enter the southern forest of RingFord, inhabited mostly by Fairies, a sub-race of the Vanir that would aid Humans on their duties.."); 
           Thread.Sleep(3000);

           // Sixth decision
           Items.fairyChoice();

           Console.WriteLine("\nYou continue through the forest.. the trees around you seem to be a lot more taller as you venture through.."); 
           Thread.Sleep(3000);
           
           // Seventh decision
           Items.woodElfChoice();

           Console.WriteLine("\nYou vacate the area where the Wood Elf resided and continue on your path.."); 
           Thread.Sleep(3000);

           // Eighth decision
           Items.wolfChoice();

           Console.WriteLine("\nYou continue up the mountain and onto what can only be described as a giant tree branch of the Yggdrasil tree, you can almost make out the portal fully.."); 
           Thread.Sleep(3000);

           // Ninth decision
           Items.ravenChoice();

           Console.WriteLine("\nYou continue up the world tree's branch and close in to your final destination. Your quest is almost complete.."); 
           Thread.Sleep(3000); 

           // Tenth decision
           Items.endChoice();

           // Epilogue

           Items.epilogue();
        }
    }
}