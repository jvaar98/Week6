using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            // programmm asendab lauses "Hello World!" kõik 'o' tähed '*';


            string helloW = "Hello World!";
            /*for(int i = 0; i < helloW.Length; i++)
            {
                helloW[i] = '*';
            }   */

            helloW = helloW.Replace('o', '*');
            helloW = helloW.Replace('!', '1');
            Console.WriteLine(helloW);
        }
    }
}
