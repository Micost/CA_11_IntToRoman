using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_11_IntToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 4999;
            Solution s1 = new Solution();
            Console.Write(s1.IntToRoman(input));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public string IntToRoman(int num)
        {
            if (num > 5000)
                return null;
            int[] numArray = { 0, 0, 0, 0 };
            int temp = num;
            String[] strArray = { "", "", "", "" };
            for (int i =0; i<4; i++)
            {
                numArray[3 - i] = temp % 10;
                temp = temp / 10;
            }
            for (int i =0; i<4; i++)
            {
                string tempStr = TransferInt(numArray[i]);
                switch (i)
                {
                    case 0:
                        strArray[i]= tempStr.Replace('I', 'M').Replace("V", "");
                        break;
                    case 1:
                        strArray[i] = tempStr.Replace('I', 'C').Replace('V','D').Replace('X','M');
                        break;
                    case 2:
                        strArray[i] = tempStr.Replace('X', 'C').Replace('I', 'X').Replace('V', 'L');
                        break;
                    default:
                        strArray[i] = tempStr;
                        break;
                }
            }
            String result = strArray[0] + strArray[1] + strArray[2] + strArray[3];
            return result;
        }
        public string TransferInt(int num)
        {
            switch (num)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
                default: return "";
            }
        }

    }
}
