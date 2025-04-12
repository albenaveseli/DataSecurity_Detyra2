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
        }
    }
}
