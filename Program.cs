// See https://aka.ms/new-console-template for more information
// Made by GoldenDuck, startet on 07.04.2026
using System;

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
            System.Console.WriteLine("Bitte geben sie den Term ein, für Hilfe, wie der Taschenrechner zu nutzen ist geben sie help ein");

            string? input = Console.ReadLine();

            if (input == "help")
            {
                System.Console.WriteLine("Es ");
            }
        }

    }
}