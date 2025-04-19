using System;
using System.IO;

namespace MorseCodee.MorseCode
{
    public class MorseFileSaver
    {
        public void SaveToFile(string morseCode, string decodedText)
        {
            try
            {
                string projectRootPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
                string filePath = Path.Combine(projectRootPath, "morse_code.txt");
                string content = $"Morse Code:\n{morseCode}\nDecoded Text:\n{decodedText}\n\n";
                File.AppendAllText(filePath, content);
                Console.WriteLine("Morse Code është ruajtur në skedarin morse_code.txt.");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Gabim gjatë ruajtjes në skedar: {ex.Message}");
            }
        }
    }
}

