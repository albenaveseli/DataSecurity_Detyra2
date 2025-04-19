
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
                sb.Append(MorseMap.GetChar(code));
            }

            return sb.ToString();
        }
    }
}

