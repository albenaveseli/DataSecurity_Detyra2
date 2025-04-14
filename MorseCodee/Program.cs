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

//deri ketu Anita
//Alba

//deri ketu Alba
//Agnesa
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

