// using System;
// using MorseCodee.MorseCode;
//
// namespace MorseCodeApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Të krijojmë objekte për kodim dhe dekodim
//             MorseEncoder encoder = new MorseEncoder();
//             MorseDecoder decoder = new MorseDecoder();
//             MorsePlayer player = new MorsePlayer();
//
//             // Input nga përdoruesi për tekstin
//             Console.WriteLine("Shkruani tekstin për ta koduar në Morse:");
//             string textToEncode = Console.ReadLine();
//
//             // Kodimi i tekstit në Morse
//             string morseCode = encoder.Encode(textToEncode);
//             Console.WriteLine($"Teksti i koduar në Morse: {morseCode}");
//
//             // Luajtja e kodit Morse përmes tonit të zërit
//             Console.WriteLine("Lojra e kodit Morse...");
//             player.Play(morseCode);
//
//             // Input për të dekoduar një mesazh Morse
//             Console.WriteLine("\nShkruani kodin Morse për ta dekoduar:");
//             string morseToDecode = Console.ReadLine();
//
//             // Dekodimi i kodit Morse në tekst
//             string decodedText = decoder.Decode(morseToDecode);
//             Console.WriteLine($"Mesazhi i dekoduar: {decodedText}");
//         }
//     }
// }