using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metzeal
{
    internal class Uppercase_Lowercase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] - 32);
                }
                else if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }
            }
            string str2 = new string(ch);
            Console.WriteLine(str2);
        }
    }
}
