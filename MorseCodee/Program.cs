using System;
using MorseCodee.MorseCode;

namespace MorseCodee
{
    class Program
    {
        static void Main()
        {

            var encoder = new MorseEncoder();
            var decoder = new MorseDecoder();
            var player = new MorsePlayer();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("        MORSE CODE TOOL        ");
                Console.WriteLine("====================================");
                Console.WriteLine("1.  Encode text to Morse code");
                Console.WriteLine("2.  Decode Morse code to text");
                Console.WriteLine("3.  Exit");
                Console.Write("Choose an option (1-3): ");

//Anita
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter text to encode: ");
                        string textInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(textInput))
                        {
                            Console.WriteLine("Input cannot be empty!");
                            Pause();
                            continue;
                        }

//deri ketu Anita
//Alba

//deri ketu Alba
//Agnesa

//deri ketu Agnesa


                static void Pause()
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}

