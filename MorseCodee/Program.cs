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
            var fileSaver = new MorseFileSaver(); 

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
                        string morseCode = encoder.Encode(textInput);
                        Console.WriteLine("\n Morse Code: " + morseCode);

                        fileSaver.SaveToFile(morseCode);
                        

                        Console.Write("\n Do you want to listen to the Morse code? (y/n): ");
                        var response = Console.ReadLine()?.Trim().ToLower();
                        if (response == "y")
                        {
                            player.Play(morseCode);
                        }else if (response != "n")
                        {
                            Console.WriteLine("Invalid input. Skipping audio playback.");
                        }

                        Pause();
                        break;


case "2":
                        Console.Write("\nEnter Morse code to decode: ");
                        string morseInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(morseInput))
                        {
                            Console.WriteLine(" Input cannot be empty!");
                            Pause();
                            continue;
                        }
                        try
                        {
                            string decodedText = decoder.Decode(morseInput);
                            Console.WriteLine("\n Decoded Text: " + decodedText);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($" Error decoding Morse code: {ex.Message}");
                        }

                        Pause();
                        break;

                        
                        

                    case "3":
                        Console.WriteLine("\n Thank you for using the Morse Code Tool!");
                        return;

                    default:
                        Console.WriteLine("Invalid option! Please choose 1, 2 or 3.");
                        Pause();
                        break;
                }
            }
        }



                static void Pause()
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
 

