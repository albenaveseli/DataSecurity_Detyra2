using System;
using MorseCodee.MorseCode;

namespace MorseCodee
{
    class Program1
    {
        static void Main()
        {
        //pjesa1, masanej i fshijm komentet
          Console.WriteLine("Enter text to encode in Morse code:");
          string input = Console.ReadLine();

        //pjesa2
        var encoder = new MorseEncoder();
        string morse = encoder.Encode(input);
        Console.WriteLine("Morse Code: " + morse);


        //pjesa3
MorsePlayer player = new MorsePlayer();
player.Play(morse);

        //pjesa 4
        Console.WriteLine("\nEnter Morse code to decode:");
        string morseInput = Console.ReadLine();
        var decoder = new MorseDecoder();
        string decoded = decoder.Decode(morseInput);
        Console.WriteLine("Decoded Text: " + decoded);
        }
    }
}
