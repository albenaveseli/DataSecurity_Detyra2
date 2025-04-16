using System.Text;
using MorseCodeApp.MorseCode;

namespace MorseCodee.MorseCode
{
    public class MorseDecoder
    {
        public string Decode(string morse)
        {
            var sb = new StringBuilder();
            string[] codes = morse.Split(' ');

            foreach (var code in codes)
            {
                if (MorseMap.MorseToText.TryGetValue(code, out var letter))
                {
                    sb.Append(letter);
                }
                 else
                {
                    sb.Append('?');
                }
            }

            return sb.ToString();
        }
    }
}
