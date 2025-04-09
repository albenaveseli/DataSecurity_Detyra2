
using System.Text;
using MorseCodeApp.MorseCode;

namespace MorseCodee.MorseCode
{
    public class MorseEncoder
    {
        public string Encode(string text)
        {
            var sb = new StringBuilder();
            foreach (char c in text.ToUpper())
            {
                if (MorseMap.TextToMorse.TryGetValue(c, out var morse))
                {
                    sb.Append(morse).Append(" ");
                }
            }
            return sb.ToString().Trim();
        }
    }
}