using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kuvab, mitu 'a' tähte onkasutaja ees- ja perekonnanimes kokku

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine().ToLower();

            int aCounter = 0;

            for (int i = 0; i < firstName.Length; i++)
            {
                if (firstName[i] == 'a')
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
            {

                Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu eesnimes {firstName} on {aCounter} 'a' tähte.");
            }
        }
    }
}
