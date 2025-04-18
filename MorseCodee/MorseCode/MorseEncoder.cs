using System.Linq;
using System.Text;
using MorseCodeApp.MorseCode;

namespace MorseCodee.MorseCode
{
    public class MorseEncoder
    {
        public string Encode(string text)
        {

            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return string.Join(" ",
                text.ToUpper().Select(c =>
            {
                if (!MorseMap.TextToMorse.TryGetValue(c, out var morse))
                {
                   
                }
                return morse;
            }));
        }
    }

}