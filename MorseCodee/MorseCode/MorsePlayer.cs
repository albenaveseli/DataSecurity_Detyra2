using System;
using System.Threading;

namespace MorseCodee.MorseCode
{
    public class MorsePlayer
    {
        private const int DotDuration = 100;
        private const int DashDuration = DotDuration * 3;
        private const int Frequency = 800;

        public void Play(string morseCode)
        {
            if (string.IsNullOrWhiteSpace(morseCode))
            {
                Console.WriteLine("Morse code input is empty.");
                return;
            }

            foreach (char symbol in morseCode)
            {
                switch (symbol)
                {
                    case '.': // Dot
                        Console.Beep(Frequency, DotDuration);
                        Thread.Sleep(DotDuration);
                        break;

                    case '-': // Dash
                        Console.Beep(Frequency, DashDuration);
                        Thread.Sleep(DotDuration);
                        break;

                    case ' ': // Space between letters
                        Thread.Sleep(DotDuration * 3);
                        break;

                    case '/': // Slash between words
                        Thread.Sleep(DotDuration * 7);
                        break;

                    default:
                        Console.WriteLine($"Unknown symbol in Morse code: '{symbol}'");
                        break;
                }
            }
        }
    }
}