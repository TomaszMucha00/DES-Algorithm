using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DES_Algorithm
{
    class JustSomeGlobalTestingStuff
    {
        public static int[] SomeTestArray { get; set; }

        static JustSomeGlobalTestingStuff()
        {
            SomeTestArray = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            string temp = "";
            foreach (var item in SomeTestArray)
            {
                temp += item.ToString();
            }
            MessageBox.Show(temp);
        }
    }
}
