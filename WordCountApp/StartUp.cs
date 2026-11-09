using BackEnd;
using System;
using System.Collections.Generic;
using System.Text;

namespace WordCountApp;

public class FrontEnd
{
    public void Start()
    {
        
        Console.Write("Skriv din text: ");
        string bruger_input = Console.ReadLine();

       bool running = true;
        while (running)
        {
            Console.WriteLine();

            Console.Write("Hvilken ord vil du søge efter?: ");
            string searchWord = Console.ReadLine();
            Console.WriteLine();

            SearchResult result = Class1.WordCount(bruger_input, searchWord);

            Console.WriteLine($"Antal af ordet {searchWord} kommer: {result.Count} gange.");
            Console.WriteLine($"Søgetid: {result.SearchTime} ms");
            Console.WriteLine();

            Console.WriteLine("1. Vil du søge efter et andet ord i den eksisterende tekst?: : ");
            Console.WriteLine("2. Vil du søge efter et andet ord i en ny tekst?: : ");
            Console.WriteLine("3. Vil du afslutte programmet?: : ");
            Console.WriteLine();

            Console.Write("Skriv dit valg: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    running = true;
                    break;

                case "2":
                    Console.WriteLine("Skriv din nye tekst: ");
                    bruger_input = Console.ReadLine();
                    break;

                case "3":
                    running = false;
                    Console.WriteLine("Programmet afsluttes.");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Programmet afsluttes.");
                    break;
            }
        }

    }

  
}
