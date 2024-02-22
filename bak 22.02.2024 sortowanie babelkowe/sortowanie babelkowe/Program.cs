class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("**********************");
            Console.WriteLine("podaj rozmiar tablicy:");
            Console.WriteLine("**********************");
            string rozmiarString = Console.ReadLine();
            if (int.TryParse(rozmiarString, out int rozmiar) && (rozmiar > 0))
            {
                int[] liczby = new int[rozmiar];

                Random random = new Random();
                for (int i = 0; i < rozmiar; i++)
                {
                    liczby[i] = random.Next(100);
                }

                Console.WriteLine("----------------------");
                Console.WriteLine("oto twoja nieposortowana tablica:");
                foreach (int i in liczby)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                sortowanieBabelkowe(liczby);

                Console.WriteLine("oto twoja posortowana tablica:");
                foreach (int i in liczby)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("podaj prawidlowy rozmiar tablicy");
            }
        }
    }

    static void sortowanieBabelkowe(int[] liczby)
    {
        for (int i = 0; i < liczby.Length - 1; i++)
        {
            for (int j = 0; j < liczby.Length - 1 - i; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    int t = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = t;
                }
            }
        }
    }
}