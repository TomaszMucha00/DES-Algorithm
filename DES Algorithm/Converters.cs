using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_Algorithm
{
    class Converters
    {
        public static string BinToHex(string toConvert)
        {
            char[] toConvertCharTab = toConvert.ToCharArray();
            int[] toConvertIntTab = new int[toConvertCharTab.Length];
            for (int i = 0; i < toConvertCharTab.Length; i++)
            {
                toConvertIntTab[i] = (int)toConvertCharTab[i]-48;
            }
            int[] toConvertDecTab = new int[toConvertIntTab.Length/4];
            for (int i = 0; i < toConvertIntTab.Length/4; i++)
            {
                toConvertDecTab[i] = toConvertIntTab[i * 4] * (2*2*2) + toConvertIntTab[i * 4 + 1] * (2 *2) + toConvertIntTab[i * 4 + 2] * 2 + toConvertIntTab[i * 4 + 3];
            }
            string[] toConvertHexTab = new string[toConvertDecTab.Length];
            for (int i = 0; i < toConvertDecTab.Length; i++)
            {
                toConvertHexTab[i] = toConvertDecTab[i].ToString("X");
            }
            string converted = "";
            foreach (var item in toConvertHexTab)
            {
                converted += item;
            }
            return converted;
        }

        public static string BinToText(string toConvert)
        {
            char[] toConvertCharTab = toConvert.ToCharArray();
            int[] toConvertIntTab = new int[toConvertCharTab.Length];
            for (int i = 0; i < toConvertCharTab.Length; i++)
            {
                toConvertIntTab[i] = (int)toConvertCharTab[i] - 48;
            }
            char[] textCharTab = new char[toConvertCharTab.Length / 8]; 
            for (int i = 0; i < toConvertCharTab.Length/8; i++)
            {
                textCharTab[i] = (char)(
                   toConvertIntTab[8 * i]    *Math.Pow(2, 7) +
                   toConvertIntTab[8 * i + 1]*Math.Pow(2, 6) +
                   toConvertIntTab[8 * i + 2]*Math.Pow(2, 5) +
                   toConvertIntTab[8 * i + 3]*Math.Pow(2, 4) +
                   toConvertIntTab[8 * i + 4]*Math.Pow(2, 3) +
                   toConvertIntTab[8 * i + 5]*Math.Pow(2, 2) +
                   toConvertIntTab[8 * i + 6]*Math.Pow(2, 1) +
                   toConvertIntTab[8 * i + 7]*Math.Pow(2, 0));
            }
            string converted = new string(textCharTab);
            return converted;
        }

        public static string TextToBin(string toConvert)
        {
            char[] toConvertCharTab = toConvert.ToCharArray();
            int[] toConvertIntTab = new int[toConvertCharTab.Length];
            for (int i = 0; i < toConvertCharTab.Length; i++)
            {
                toConvertIntTab[i] = (int)toConvertCharTab[i];
            }
            string converted = "";
            for (int i = 0; i < toConvertIntTab.Length; i++)
            {
                converted += Convert.ToString(toConvertIntTab[i],2).PadLeft(8,'0');
            }
            return converted;
        }

        public static string TextToHex(string toConvert)
        {
            return BinToHex(TextToBin(toConvert));
        }

        public static string HexToBin(string toConvert)
        {
            string Converted = String.Join(String.Empty,
             toConvert.Select(
             c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
            )
            );
            //toConvert = Convert.ToString(toConvert /*Convert.ToInt32(toConvert, 16)*/, 2);
            return Converted;
        }

        public static string HexToText(string toConvert)
        {
            return BinToText(HexToBin(toConvert));
        }
    }
}
