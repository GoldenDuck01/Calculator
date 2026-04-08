// See https://aka.ms/new-console-template for more information
// Made by GoldenDuck, startet on 07.04.2026
using System;
using System.Collections;

namespace Calculator
{
    public class Programm()
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

        string helpText = @"
    Seems like you need some Help!
    Its easy, just write your equasion almost like you would normaly!
    Type in a Number like 3 or any other number and then type in a Operator like + or - for example

    Here is every possible Operator:

    + for Addition
    - for Subtraction
    * for Multiplication
    / for Division
    This is an example of how a Equation should look like: 1 + 1 + 3

    Thats it! Hope you now know how to use this Calculator!
    Press any Key to return to the Beginning
            ";


        public static void Main()
        {
            Programm main = new();
            main.Start();
        }

        public void Start()
        {

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

            if (input == "help")
            {
                Console.Clear();
                System.Console.WriteLine(logo);
                System.Console.WriteLine(helpText);
                Console.ReadKey();
                Start();
            }
            if (input == "exit")
            {
                Environment.Exit(0);
            }

            string[] tokens = input.Split(" ");

            for (int i = 0; i < tokens.Length; i++)
            {

            }
        }
    }
}