using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMaHoa
{
    public class Ceasar
    {
        public static int MapCharacterToNumber(char ch)
        {
            return ch - 'A';
        }

        public static char MapNumberToCharacter(int num)
        {
            return (char)('A' + num);
        }

        public static int[] ConvertStringToArrayNumber(string input)
        {
            var result = new List<int>();
            foreach(var ch in input)
            {
                result.Add(MapCharacterToNumber(ch));
            }
            return result.ToArray();
        }
    }
}
