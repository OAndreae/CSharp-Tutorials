using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummary
{
    public class StringUtility
    {
        public static string Summarise(string text, int maxLength)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');

            var summaryList = new List<string>();
            
            var characters = 0;
            foreach (var word in words)
            {
                summaryList.Add(word);
                characters += word.Length + 1; // +1 to account for space

                if (characters > maxLength)
                    break;
            }

            return String.Join(" ", summaryList) + "...";
        }
    }
}
