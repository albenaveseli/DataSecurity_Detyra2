using System;
using MorseCodee.MorseCode;

namespace MorseCodee
{
    class Program {
        static void Main()
        {
           
            Console.WriteLine("Enter text to encode in Morse code:");
            string input = Console.ReadLine();

           
            var encoder = new MorseEncoder();
            string morse = encoder.Encode(input);
            Console.WriteLine("Morse Code: " + morse);


         
            MorsePlayer player = new MorsePlayer();
            player.Play(morse);
            
            Console.WriteLine("\nEnter Morse code to decode:");
            string morseInput = Console.ReadLine();
            var decoder = new MorseDecoder();
            string decoded = decoder.Decode(morseInput);
            Console.WriteLine("Decoded Text: " + decoded);
        }
    }
}