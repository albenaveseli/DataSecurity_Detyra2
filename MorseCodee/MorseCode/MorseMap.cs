﻿using System.Collections.Generic;

namespace MorseCodeApp.MorseCode
{
    public static class MorseMap
    {
        public static readonly Dictionary<char, string> TextToMorse = new()
        {
            {'A', ".-"},    {'B', "-..."},  {'C', "-.-."}, {'D', "-.."},   {'E', "."},
            {'F', "..-."},  {'G', "--."},   {'H', "...."}, {'I', ".."},    {'J', ".---"},
            {'K', "-.-"},   {'L', ".-.."},  {'M', "--"},   {'N', "-."},    {'O', "---"},
            {'P', ".--."},  {'Q', "--.-"},  {'R', ".-."},  {'S', "..."},   {'T', "-"},
            {'U', "..-"},   {'V', "...-"},  {'W', ".--"},  {'X', "-..-"},  {'Y', "-.--"},
            {'Z', "--.."},  {'0', "-----"}, {'1', ".----"},{'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."},{'7', "--..."}, {'8', "---.."},
            {'9', "----."}, {' ', "/"}
        };

        public static readonly Dictionary<string, char> MorseToText = new();

        static MorseMap()
        {
            foreach (var kvp in TextToMorse)
            {
                MorseToText[kvp.Value] = kvp.Key;
            }
        }
    }
}