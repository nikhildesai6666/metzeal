//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace metzeal
//{
//    internal class DuplicateWordsAndOccurrences
//    {
//        public static void Main(string[] args)
//        {
//            string str = "I like India";
//            char[] ch = str.ToCharArray();
//            for (int i = 0; i < ch.Length; i++)
//            {
//                int count = 1;
//                for (int j = i + 1; j < ch.Length; j++)
//                {
//                    if (ch[i] == ch[j])
//                    {
//                        count++;
//                        ch[j] = '0';
//                    }
//                    Console.WriteLine(ch[i] + " Occourence" + " " + count);
//                }
//                if (ch[i] != '0' && ch[i] != ' ')
//                {
//                    Console.WriteLine(ch[i] + " Occourence" + " " + count);
//                }
//            }
//        }
//    }
//}
