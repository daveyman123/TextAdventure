using System;

namespace TextAdventure
{
    class RaspberryPi
    {
        public bool Has_an_led { get; set; }
        public bool Has_power { get; set; }
    }
    class DeskChoices
    {
        public static string AttachObject(string Object)
        {
            return string.Format("you have attached {0} to the raspberry pi",Object);
        }
    }

    class Game
    {
        //Arrays
        static string[] PartOne = { "Which will you choose? A or B?", "you chose option A", "you chose option B", "more story for both", "more on story for option A", "more on story for option A", "transition"  };
        static string[] PartTwo = { "Which will you choose? A1 or B1?", "you chose option A", "you chose option B", "more story for both", "more on story for option A", "more on story for option A", "transition" };
        static string[] PartThree = { "Which will you choose? A2 or B2?", "you chose option A", "you chose option B", "more story for both", "more on story for option A", "more on story for option A", "transition" };

        //Strings
        static string CharacterName = "john Doe";
        static string CharacterIntroduction;

        // Integers
        static int Scenarios = 3;
        static int RandomNumberGenerator()
        {
            // Random number for character name
            Random random = new Random();
            int randomNumber = random.Next(100, 10000);
            return randomNumber;
        }

        // Make the choices

        static void Choice()
        {
            for (int scenario = 1; scenario <= Scenarios; scenario++)
            {
                switch (scenario)
                {
                    case 1:
                        //if scenario equals 1, statements here run
                        string input = "";

                        //write the beginning of the scenario 
                        //and ask for a choice between a or b
                        Console.WriteLine(PartOne[0]);

                        Console.Write("Enter your choice: ");

                        //read in the choice and save it
                        input = Console.ReadLine();

                        //make whatever was typed in lowercase
                        //    we could also use ToUpper() and then 
                        //    capitalize the A and B in the if statements 
                        //    either way it allows the player to type in lower or capital letters 
                        input = input.ToLower();

                        //if the choice was a, print out the second element in the array [1]
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[1]);
                        }

                        //if the player types b (or anything else) we'll assume they want the second choice
                        else
                        {
                            Console.WriteLine(PartOne[2]);
                        }

                        //write out the next part of the story for everyone
                        Console.WriteLine(PartOne[3]);

                        //if the choice was a, print out the second element in the array [4]
                        if (input == "a")
                        {
                            Console.WriteLine(PartOne[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartOne[5]);
                        }

                        //write out the transition to the next part of the story for everyone
                        Console.WriteLine(PartOne[6]);
                        break;

                    case 2:
                        //if scenario  equals 2, statements here run
                        string input1 = "";

                        //write the beginning of the scenario 
                        //and ask for a choice between a or b
                        Console.WriteLine(PartTwo[0]);

                        Console.Write("Enter your choice: ");

                        //read in the choice and save it
                        input1 = Console.ReadLine();

                        //make whatever was typed in lowercase
                        //    we could also use ToUpper() and then 
                        //    capitalize the A and B in the if statements 
                        //    either way it allows the player to type in lower or capital letters 
                        input1 = input1.ToLower();

                        //if the choice was a, print out the second element in the array [1]
                        if (input1 == "a")
                        {
                            Console.WriteLine(PartTwo[1]);
                        }

                        //if the player types b (or anything else) we'll assume they want the second choice
                        else
                        {
                            Console.WriteLine(PartTwo[2]);
                        }

                        //write out the next part of the story for everyone
                        Console.WriteLine(PartOne[3]);

                        //if the choice was a, print out the second element in the array [4]
                        if (input1 == "a")
                        {
                            Console.WriteLine(PartTwo[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartTwo[5]);
                        }

                        //write out the transition to the next part of the story for everyone
                        Console.WriteLine(PartTwo[6]);
                        break;
                      
                    case 3:
                        //if scenario  equals 3, statements here run
                        string input2 = "";

                        //write the beginning of the scenario 
                        //and ask for a choice between a or b
                        Console.WriteLine(PartThree[0]);

                        Console.Write("Enter your choice: ");

                        //read in the choice and save it
                        input2 = Console.ReadLine();

                        //make whatever was typed in lowercase
                        //    we could also use ToUpper() and then 
                        //    capitalize the A and B in the if statements 
                        //    either way it allows the player to type in lower or capital letters 
                        input2 = input2.ToLower();

                        //if the choice was a, print out the second element in the array [1]
                        if (input2 == "a")
                        {
                            Console.WriteLine(PartThree[1]);
                        }

                        //if the player types b (or anything else) we'll assume they want the second choice
                        else
                        {
                            Console.WriteLine(PartThree[2]);
                        }

                        //write out the next part of the story for everyone
                        Console.WriteLine(PartThree[3]);

                        //if the choice was a, print out the second element in the array [4]
                        if (input2 == "a")
                        {
                            Console.WriteLine(PartThree[4]);

                        }
                        else
                        {
                            Console.WriteLine(PartThree[5]);
                        }

                        //write out the transition to the next part of the story for everyone
                        Console.WriteLine(PartThree[6]);
                        break;

                    default:
                        //if scenario does not match any above
                        break;
                }
            }
        }  

        public static void StartScreen()
        {
            Console.WriteLine("super awesome \nrobot escape room game");
            ASCii_art.art.RobotArt();
            Console.Clear();

        }

        // print out game title and overview
        public static void StartGame()
        {
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("You are a robot with rudementary movement and speach.");
            Console.WriteLine();
            Console.ReadLine();
            NameCharacter();
            Console.ReadLine();
            
            Choice();
            Console.ReadLine();

            
        }
        static void NameCharacter()
        {
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();
            CharacterName = CharacterName + " Version " + RandomNumberGenerator();
            CharacterIntroduction = string.Format("Great! Your character is now named {0}", CharacterName);
            Console.WriteLine(CharacterIntroduction);
        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game.StartScreen();
            Game.StartGame();
        }
            
        
    }
}
