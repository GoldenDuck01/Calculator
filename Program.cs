// See https://aka.ms/new-console-template for more information
// Made by GoldenDuck, startet on 07.04.2026
using System;
using System.Collections;
using System.ComponentModel;
using System.IO.Pipelines;
using System.Linq;
using System.Runtime.CompilerServices;

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

            List<string> equasion = input.Split(" ").ToList();

            double result = 0;

            for (int i = 0; i < equasion.Count; i++)
            {
                if (equasion[i] == "*" || equasion[i] == "/")
                {
                    double before = double.Parse(equasion[i - 1]);
                    double after = double.Parse(equasion[i + 1]);

                    if (equasion[i] == "*")
                    {
                        result = before * after;
                    }
                    else
                    {
                        result = before / after;
                    }

                    equasion[i - 1] = result.ToString();
                    equasion.RemoveAt(i); // Erst der Operator also * oder / 
                    equasion.RemoveAt(i); // Dann folgt jetzt bei i die andere Zahl

                    i = -1; // Damit i beim nächstem Loop 0 wird
                }
            }

            result = double.Parse(equasion[0]);

            for (int i = 1; i < equasion.Count; i += 2)
            {
                double before = double.Parse(equasion[i - 1]);
                double after = double.Parse(equasion[i + 1]);

                if (equasion[i] == "+")
                {
                    result = before + after;
                }
                else
                {
                    result = before - after;
                }
            }

            System.Console.WriteLine($"The Answer is: {result}");
            System.Console.WriteLine("");
            System.Console.WriteLine("Would you like to calculate another equasion?");
            System.Console.WriteLine("Type yes for another one or no to exit");

            InputMethodAfterEquasion();
        }

        void InputMethodAfterEquasion()
        {
            string? inputAfterEquasion = Console.ReadLine();

            switch (inputAfterEquasion)
            {
                case "yes":
                    Start();
                    break;
                case "no":
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Sorry you must have typed something wrong!");
                    System.Console.WriteLine("Try again!");
                    InputMethodAfterEquasion();
                    break;
            }
        }
    }
}

/*
 String?[] equasion = input.Split(" ");

            double result = 0;

            for (int i = 0; i < equasion.Length; i++)
            {

                if ((equasion[i] == "*" || equasion[i] == "/") && i > 0 && i < equasion.Length - 1)
                {
                    double before = double.Parse(equasion[i - 1]);

                    double after = double.Parse(equasion[i + 1]);


                    switch (equasion[i])
                    {
                        case "*":
                            result = before * after;
                            break;
                        case "/":
                            result = before / after;
                            break;
                        default:
                            System.Console.WriteLine("Seems like something went wrong!");
                            break;
                    }
                }
            }

            System.Console.WriteLine(result);
*/