using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Halic University";          
            string strnew = " ";            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'c')
                    strnew += 's';
                else
                    strnew += str[i];
            }
            Console.WriteLine(strnew);
            //String str1 = str.Substring(6);
            //Console.WriteLine(str1);
            Console.ReadKey();
            
        }
    }
}
