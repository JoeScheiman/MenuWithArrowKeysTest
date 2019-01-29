using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KittyAnimationTest2
{
    class Program
    {
        static ConsoleColor[] MenuColors = {
            ConsoleColor.Blue,
            ConsoleColor.Black,
            ConsoleColor.DarkBlue,
            ConsoleColor.White
        };

        static void MenuHighlight(int selectionNum)
        {
            Console.Clear();

            Console.WriteLine("\n\n\n");

            if (selectionNum == 1) Console.BackgroundColor = MenuColors[2];
            Console.WriteLine("\t1: Feed");
            if (selectionNum == 1) Console.ResetColor();

            if (selectionNum == 2) Console.BackgroundColor = MenuColors[2];
            Console.WriteLine("\t2: Play");
            if (selectionNum == 2) Console.ResetColor();

            if (selectionNum == 3) Console.BackgroundColor = MenuColors[2];
            Console.WriteLine("\t3: Nap");
            if (selectionNum == 3) Console.ResetColor();

            if (selectionNum == 4) Console.BackgroundColor = MenuColors[2];
            Console.WriteLine("\t4: Go Back");
            if (selectionNum == 4) Console.ResetColor();
        }

        static void Main(string[] args)
        {

            int menuSelectionCurrent = 1;
            int menuSelectionNext = 0;
            bool selected = false;

            MenuHighlight(1);

            do
            {
                var ch = Console.ReadKey(false).Key;
                switch (ch)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine("ESCAPE! ");
                        return;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("up!");
                        menuSelectionCurrent--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down!");
                        menuSelectionCurrent++;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("up!");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Down!");
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 1;
                        selected = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 2;
                        selected = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 3;
                        selected = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 4;
                        selected = true;
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("Decision Has Been Made!!!");
                        selected = true;
                        break;
                    default:
                        break;
                }
                if (menuSelectionCurrent > 4) menuSelectionCurrent = 4;
                else if (menuSelectionCurrent < 1) menuSelectionCurrent = 1;
                if (selected)
                {
                    switch (menuSelectionCurrent)
                    {
                        case 1:
                            Console.WriteLine("....#1 Chosen!");
                            break;
                        case 2:
                            Console.WriteLine("....#2 Chosen!");
                            break;
                        case 3:
                            Console.WriteLine("....#3 Chosen!");
                            break;
                        case 4:
                            Console.WriteLine("....#4 Chosen!");
                            break;
                        default:
                            Console.WriteLine("....NOPE Chosen!");
                            break;
                    }
                }
                else
                    MenuHighlight(menuSelectionCurrent);
            } while (!selected);




            //VirtualPet.Kitty(12,1);
            /******************************************************************************
            // Get an array with the values of ConsoleColor enumeration members.
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            // Save the current background and foreground colors.
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;

            // Display all foreground colors except the one that matches the background.
            Console.WriteLine("All the foreground colors except {0}, the background color:",
                              currentBackground);
            foreach (var color in colors)
            {
                if (color == currentBackground) continue;

                Console.ForegroundColor = color;
                Console.WriteLine("   The foreground color is {0}.", color);
            }
            Console.WriteLine();
            // Restore the foreground color.
            Console.ForegroundColor = currentForeground;

            // Display each background color except the one that matches the current foreground color.
            Console.WriteLine("All the background colors except {0}, the foreground color:",
                              currentForeground);
            foreach (var color in colors)
            {
                if (color == currentForeground) continue;

                Console.BackgroundColor = color;
                Console.WriteLine("   The background color is {0}.", color);
            }

            // Restore the original console colors.
            Console.ResetColor();
            Console.WriteLine("\nOriginal colors restored...");



            //This will read a single key and show its char value - Useful for menu
            if (Console.ReadKey().KeyChar == 'k')
                Console.WriteLine("yoyoyoyo!!!!!");
            ***************************************************************************************/
            Console.ReadKey();
        }
    }





    public class VirtualPet
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Fullness { get; set; }
        public int Energy { get; set; }
        public int Happiness { get; set; }
        public const int IncreaseAmount = 5;

        public VirtualPet()
        {
            Name = "default";
            Energy = 5;
            Happiness = 5;
            Fullness = 5;

        }
        public void TimeIncrement()
        {
            Console.Beep();
            Energy--;
            Happiness--;
            Fullness--;
        }
        public void Feed()
        {
            Fullness += IncreaseAmount;
            Console.Clear();
            Console.WriteLine("\tYou just FED " + Name + " !");

        }
        public void Play()
        {
            Happiness += IncreaseAmount;
            Console.Clear();
            Console.WriteLine("\tYou just PLAYED with " + Name + " !");
        }

        public void Nap()
        {
            Energy += IncreaseAmount;
            Console.Clear();
            Console.WriteLine("\t" + Name + " took a NAP!");
        }
        public static void Kitty(int tabs, int milliSec)
        {

            //int milliseconds = 400;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            for (int i = 0; i < tabs; i++)
            {

                foreach (var color in colors)
                {
                    //if (color == currentForeground) continue;

                    //Console.BackgroundColor = color;
                    Console.ForegroundColor = color;
                    Console.Clear();
                    if (i < (tabs / 2))
                    {
                        for (int t = 0; t < i; t++)
                            Console.Write("\n\n\n");
                    }
                    else
                    {
                        for (int t = tabs; t > i; t--)
                            Console.Write("\n\n\n");
                    }


                    //Console.WriteLine("   The background color is {0}.", color);



                    Console.WriteLine("\n\n");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@" _");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"( \");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@" \ \");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@" / /                 |\\");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"/ /     .-`````-.    / ^`-.");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"\ \    /         \_ /  {|} `o");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@" \ \  /   .-- -.   \\ _  ,--'");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"  \ \/   /     \,   \( `^^^");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"   \   \/\      (\  )");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"    \   ) \     ) \ \                    ____()()");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"     ) / __ \__  ) (\ \___             /       @@");
                    for (int t = 0; t < i; t++)
                        Console.Write("\t");
                    Console.WriteLine(@"   (___)))__))(__))(__)))        `~~~~~\_;m__m._ >o");
                    //Thread.Sleep(milliSec);

                }
                Thread.Sleep(milliSec);
            }

            //        ____()()
            //       /       @@
            // `~~~~~\_;m__m._ >o
        }



        public static void PrintStatusBar(int howMuch, int spaceMult)
        {
            //ConsoleColor currentBackground = Console.BackgroundColor;
            //ConsoleColor currentForeground = Console.ForegroundColor;

            //max is the number which will show 100% full bar
            int max = 10;
            //spaceMult is how many "blocks" per 1 unit, this is just for readability & aesthetics
            //int spaceMult = 2;

            Console.ForegroundColor = ConsoleColor.DarkBlue; //make font color easier to read inside bar
            //3 Color Scale: Green, Yellow, Red

            if (howMuch > ((2.0 / 3.0) * (double)max))//If number is between MAX and 2/3 of MAX
            {
                //Console.WriteLine("1st if green");
                Console.BackgroundColor = ConsoleColor.Green;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            else if (howMuch > ((1.0 / 3.0) * (double)max))//If number is < 2/3 and > 1/3 of MAX
            {
                //Console.WriteLine("2nd if yellow");
                Console.BackgroundColor = ConsoleColor.Yellow;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            else //If number is less than 1/3 of MAX
            {
                //Console.WriteLine("3rd if red");
                Console.BackgroundColor = ConsoleColor.Red;
                for (int i = 1; i <= howMuch * spaceMult; i++)
                    Console.Write(" ");
            }
            if (howMuch > 99)
                Console.Write("\b\b");// Add 2 extra backspaces in case number is 3 digits
            else if (howMuch > 9)
                Console.Write("\b");// Add 1 extra backspace in case number is 2 digits

            Console.Write("\b" + howMuch + "\n");
            Console.ResetColor();
        }
        /********
        public static void DisplayPetInfo(VirtualPet petty)
        {
            Console.WriteLine("\n\tYour pet is a " + petty.Species + ".");
            Console.WriteLine("\n\tYour pet's name is: " + petty.Name);
            Console.WriteLine("\n\tYour pet's age is: " + petty.Age);
            Console.Write("\n\tYour pet's fullness level is: ");
            PrintStatusBar(petty.Fullness, 2);
            Console.Write("\n\tYour pet's happiness level is: ");
            PrintStatusBar(petty.Happiness, 2);
            Console.Write("\n\tYour pet's energy level is: ");
            PrintStatusBar(petty.Energy, 2);
        } *****/
        public void DisplayPetInfo()
        {
            Console.Write("\n\tYour " + Species + ", " + Name + ", is " + Age + " years old.\n\n");
            //"\n\tYour pet's name is: " + Name);
            //"\n\tYour pet's age is: " + Age);
            Console.Write("\n\tFullness:  ");
            PrintStatusBar(Fullness, 2);
            Console.Write("\n\tHappiness: ");
            PrintStatusBar(Happiness, 2);
            Console.Write("\n\tEnergy:    ");
            PrintStatusBar(Energy, 2);
            Console.WriteLine("\n");
        }
        public bool DisplayInteractionMenu()
        {

            bool interacted = true;

            Console.WriteLine("\n_____________________________________________\n");

            Console.WriteLine("\n\tChoose an action from the menu:\n");
            Console.WriteLine("\tF - Feed ");
            Console.WriteLine("\tP - Play");
            Console.WriteLine("\tN - Nap");
            Console.WriteLine("\tE - Go Back to Main Menu");
            Console.Write("\n\tEntry.........: ");
            string entry = Console.ReadLine();
            switch (entry.ToLower())
            {
                case "f":
                    Feed();
                    break;
                case "p":
                    Play();
                    break;
                case "n":
                    Nap();
                    break;
                default:
                    interacted = false;
                    break;
            }
            return (interacted);
        }
        public bool IsAlive()
        {
            bool alive = true;
            if ((Fullness < 1) || (Happiness < 1) || (Energy < 1))
            {
                alive = false;
            }
            return (alive);
        }

    }
}