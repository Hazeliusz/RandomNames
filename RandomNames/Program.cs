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
            Console.Write("\nPodaj długość nazwy: ");
            int lenght = 1;
            try
            {
                lenght = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Długość nazwy musi być liczbą.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("\nPodaj ilość nazw do wygenerowania: ");
            int amount = 1;
            try
            {
                amount = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ilość musi być liczbą.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("\nPodaj \"twardość\" nazwy (1-50): ");
            int twardosc = 50;
            try
            {
                twardosc = Convert.ToInt32(Console.ReadLine());
                if (twardosc < 1 || twardosc > 50)
                    throw new InvalidCastException();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ilość musi być liczbą między 1 a 50.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            bool rotation = Convert.ToBoolean(rand.Next(0, 1));
            Console.WriteLine();
            for (int j = 0; j < amount; j++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (rotation)
                    {
                        if(rand.Next(1 + (50 - twardosc), 100) <= 50 || twardosc == 25)
                            Console.Write(vowels[rand.Next(0, vowels.Length - 1)]);
                        else
                            Console.Write(consonants[rand.Next(0, consonants.Length - 1)]);
                    }
                    else
                    {
                        if (rand.Next(1 + twardosc, 100) <= 50 || twardosc == 25)
                            Console.Write(consonants[rand.Next(0, consonants.Length - 1)]);
                        else
                            Console.Write(vowels[rand.Next(0, vowels.Length - 1)]);
                    }
                    rotation = !rotation;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
