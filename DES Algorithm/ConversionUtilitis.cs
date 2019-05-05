using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES_Algorithm
{
    class ConversionUtility
    {
        public static bool isSpecial { get; set; }
        public static bool isBin { get; set; }
        public static bool isHex { get; set; }
        public static bool isText { get; set; }

        static ConversionUtility()
        {
            isSpecial = false;
            isBin = false;
            isHex = false;
            isText = false;
        }

        public static int RecogniseDataSystem(string text)
        {
            int toReturn = 0;
            if (!isSpecial)
            {
                foreach (var item in text)
                {
                    if ((item) != '0' && item != '1')
                    {
                        isBin = false;
                        isHex = true;
                        isText = true;
                        break;
                    }
                    else
                    {
                        isBin = true;
                        isHex = false;
                        isText = false;
                        toReturn = 1;
                    }
                }

                char[] hexSigns = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

                foreach (var item in text)
                {
                    bool isHexSign = false;
                    foreach (var sign in hexSigns)
                    {
                        if (item==sign)
                        {
                            isHexSign = true;
                        }
                    }
                    if (!isBin)
                    {
                        if (!isHexSign)
                        {
                            isBin = false;
                            isHex = false;
                            isText = true;
                            toReturn = 3;
                            break;
                        }
                        else
                        {
                            isHex = true;
                            isBin = false;
                            isText = false;
                            toReturn = 2;
                        }

                    }
                }
            }
            else
            {
                isText = true;
            }

            return toReturn;
        }
    }
}
