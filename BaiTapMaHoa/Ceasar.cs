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

        public static string Encrypt(string clearText, int k)
        {
            var result = new StringBuilder();

            //chuyển thành mảng số
            var numberData = ConvertStringToArrayNumber(clearText);

            //mã hóa
            foreach(var number in numberData)
            {
                var encode = (number + k) % 26;
                var encodeChar = MapNumberToCharacter(encode);
                result.Append(encodeChar);
            }

            return result.ToString();
        }

        public static string Decrypt(string cipherText, int k)
        {
            var result = new StringBuilder();

            //chuyển thành mảng số
            var numberData = ConvertStringToArrayNumber(cipherText);

            //giải hóa
            foreach (var number in numberData)
            {
                var decode = (26 + number - k) % 26;
                var decodeChar = MapNumberToCharacter(decode);
                result.Append(decodeChar);
            }

            return result.ToString();
        }
    }
}
