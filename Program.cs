// See https://aka.ms/new-console-template for more information
// Made by GoldenDuck, startet on 07.04.2026
using System;
using System.Collections;

namespace Calculator
{
    public class Programm()
    {
        public static void Main()
        {
            Programm main = new();
            main.Start();
        }

        public void Start()
        {
            string logo = @"                                                                                                                                                          
  /$$$$$$            /$$                     /$$             /$$                        
 /$$__  $$          | $$                    | $$            | $$                        
| $$  \__/  /$$$$$$ | $$  /$$$$$$$ /$$   /$$| $$  /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$ 
| $$       |____  $$| $$ /$$_____/| $$  | $$| $$ |____  $$|_  $$_/   /$$__  $$ /$$__  $$
| $$        /$$$$$$$| $$| $$      | $$  | $$| $$  /$$$$$$$  | $$    | $$  \ $$| $$  \__/
| $$    $$ /$$__  $$| $$| $$      | $$  | $$| $$ /$$__  $$  | $$ /$$| $$  | $$| $$      
|  $$$$$$/|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$|  $$$$$$$  |  $$$$/|  $$$$$$/| $$      
 \______/  \_______/|__/ \_______/ \______/ |__/ \_______/   \___/   \______/ |__/                                                                          
            ";
            Console.Clear();
            System.Console.WriteLine(logo);
            System.Console.WriteLine();
            System.Console.WriteLine("Type in your equasion under here!");
            System.Console.WriteLine();
            System.Console.WriteLine("If you need help using this Calculator write help instead of your equasion!");
            System.Console.WriteLine();
            System.Console.WriteLine("Type exit if you want to end the Calculator!");
            System.Console.WriteLine();

            string? input = Console.ReadLine();

            switch (input)
            {
                case "help":
                    Console.Clear();
                    System.Console.WriteLine(logo);
                    System.Console.WriteLine();
                    System.Console.WriteLine("Seems like you need some Help ;)");
                    System.Console.WriteLine("Its easy, just write your equasion almost like you would normaly!");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Type in a Number like 3 or any other number and then type in a Operator like + or - for example");
                    System.Console.WriteLine("Heres every possible Operator:");
                    System.Console.WriteLine("+ for Addition");
                    System.Console.WriteLine("- for Subtraction");
                    System.Console.WriteLine("* for Multiplication");
                    System.Console.WriteLine("/ for Division");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Thats it! Hope you now know how to use this Calculator!");
                    System.Console.WriteLine("Press any Key to return to the Beginning");
                    Console.ReadKey();
                    Start();
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    System.Console.WriteLine("Seems like you misstyped something there, try again!");
                    Start();
                    break;
            }
        }

    }
}