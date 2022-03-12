using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace reversalTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Привет, мир!";
            s = Console.ReadLine();
            char[] sReverse = s.ToCharArray();
            Array.Reverse(sReverse);
            s = new string(sReverse);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
