using System.Collections.Generic;


namespace MorseCodee.MorseCode
{
    public static class MorseMap
    {
        public static readonly Dictionary<char, string> TextToMorse = new()
        {
            { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." }, { 'E', "." },
            { 'F', "..-." }, { 'G', "--." }, { 'H', "...." }, { 'I', ".." }, { 'J', ".---" },
            { 'K', "-.-" }, { 'L', ".-.." }, { 'M', "--" }, { 'N', "-." }, { 'O', "---" },
            { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" },
            { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" }, { 'Y', "-.--" },
            { 'Z', "--.." }, { '0', "-----" }, { '1', ".----" }, { '2', "..---" }, { '3', "...--" },
            { '4', "....-" }, { '5', "....." }, { '6', "-...." }, { '7', "--..." }, { '8', "---.." },
            { '9', "----." }, { ' ', "/" },

            { '.', ".-.-.-" }, { ',', "--..--" }, { '?', "..--.." }, { '!', "-.-.--" },
            { '-', "-....-" }, { '/', "-..-." }, { '(', "-.--." }, { ')', "-.--.-" },
            { '&', ".-..." }, { ':', "---..." }, { ';', "-.-.-." }, { '=', "-...-" },
            { '+', ".-.-." }, { '_', "..--.-" }, { '"', ".-..-." }, { '$', "...-..-" },
            { '@', ".--.-." }
        };

        public static readonly Dictionary<string, char> MorseToText = new();

        static MorseMap()
        {
            foreach (var kvp in TextToMorse)
            {
                MorseToText[kvp.Value] = kvp.Key;
            }
        }

        public static string GetMorse(char c)
        {
            c = char.ToUpper(c);
            if (!TextToMorse.TryGetValue(c, out var morse))
            {
                Console.WriteLine($"Warning: Unknown character '{c}'");
                return "?";
            }

            return morse;
        }

        public static char GetChar(string morse)
        {
            if (!MorseToText.TryGetValue(morse, out var ch))
            {
                Console.WriteLine($"Warning: Unknown morse code \"{morse}\"");
                return '?';
            }

            return ch;
        }
    }
}
