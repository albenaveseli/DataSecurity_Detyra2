// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
// using System;
// using System.Threading;
// using MorseCodeApp.MorseCode;
//
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter text to encode in Morse code:");
//         string input = Console.ReadLine();
//
//         var encoder = new MorseEncoder();
//         string morse = encoder.Encode(input);
//         Console.WriteLine("Morse Code: " + morse);
//
//         PlayMorseWithBeep(morse);
//
//         Console.WriteLine("\nEnter Morse code to decode:");
//         string morseInput = Console.ReadLine();
//         var decoder = new MorseDecoder();
//         string decoded = decoder.Decode(morseInput);
//         Console.WriteLine("Decoded Text: " + decoded);
//     }
//
//     static void PlayMorseWithBeep(string morse)
//     {
//         foreach (char c in morse)
//         {
//             switch (c)
//             {
//                 case '.':
//                     Console.Beep(1000, 150); // dot
//                     break;
//                 case '-':
//                     Console.Beep(1000, 400); // dash
//                     break;
//                 case ' ':
//                     Thread.Sleep(200); // pause between letters
//                     break;
//                 case '/':
//                     Thread.Sleep(500); // pause between words
//                     break;
//             }
//         }
//     }
// }
