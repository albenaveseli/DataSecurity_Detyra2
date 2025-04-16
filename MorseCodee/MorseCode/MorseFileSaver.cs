using System;
using System.IO;

namespace MorseCodee.MorseCode
{
    public class MorseFileSaver
    {
        public void SaveToFile(string morseCode)
        {
            try
            {
                
                File.WriteAllText("morse_code.txt", morseCode);
                Console.WriteLine("Morse Code është ruajtur në skedarin morse_code.txt.");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Gabim gjatë ruajtjes në skedar: {ex.Message}");
            }
        }
    }
}

