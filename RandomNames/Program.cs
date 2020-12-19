using System;

namespace RandomNames
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'b', 'c', 'ć', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'ł', 'm', 'n', 'p', 'r', 's', 't', 'w', 'z', 'ż', 'ź' };
            char[] consonants = { 'a', 'ą', 'e', 'ę', 'i', 'o', 'u', 'y' };
            Random rand = new Random();
            Console.WriteLine("Podaj długość nazwy: ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj ilość nazw do wygenerowania");
            int amount = Convert.ToInt32(Console.ReadLine());
            bool rotation = Convert.ToBoolean(rand.Next(0, 1));
            Console.WriteLine();
            for (int j = 0; j < amount; j++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (rotation)
                        Console.Write(vowels[rand.Next(0, vowels.Length - 1)]);
                    else
                        Console.Write(consonants[rand.Next(0, consonants.Length - 1)]);
                    rotation = !rotation;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
