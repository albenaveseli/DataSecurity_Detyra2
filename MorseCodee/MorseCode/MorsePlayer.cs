using System;
using System.Threading;
namespace MorseCodee.MorseCode;

public class MorsePlayer
{
    private const int DotDuration = 100;
    private const int DashDuration = DotDuration * 3;
    private const int Frequency = 800;

    public void Play(String morseCode)
    {
        foreach (char symbol in morseCode)
        {
            switch (symbol)
            {
                case '.':
                    Console.Beep(Frequency, DotDuration);
                    Thread.Sleep(DotDuration);
                    break;
                case '-':
                    Console.Beep(Frequency, DashDuration);
                    Thread.Sleep(DotDuration); 
                    break;
                case ' ':
                    Thread.Sleep(DotDuration * 3);
                    break;
            }
        }
        
    }
}