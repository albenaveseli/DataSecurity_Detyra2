using System.Linq;


namespace MorseCodee.MorseCode
{
    public class MorseEncoder
    {
        public string Encode(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            return string.Join(" ",
                text.ToUpper().Select(MorseMap.GetMorse));
        }
    }
}