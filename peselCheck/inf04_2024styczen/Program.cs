namespace inf04_2024styczen
{
    internal class Program
    {
        /**
         * nazwa funkcji: jakaPlec
         * opis funcki: sprawdza czy dany numer PESEL należy do kobiety, czy mężczyzny
         * parametry: string - numer pesel do sprawdzenia
         * zwracany typ i opis: char - 'K' jeśli PESEL należy do kobiety, lub 'M' jeśli PESEL należy do mężczyzny
         * autor: 12312312312
         */
        static char jakaPlec(string pesel)
        {
            if ((pesel[9] - '0') % 2 == 0)
            { 
                return 'K';
            }
            return 'M';
        }

        static bool cyfraKontrolna(string pesel)
        {
            int[] wagi = [1,3,7,9,1,3,7,9,1,3];
            int S = 0;

            for (int i = 0; i < pesel.Length-1; ++i)
                S += (pesel[i]-'0') * wagi[i];

            int M = S % 10;
            int R = M==0 ? 0 : 10-M;
            return (R == pesel[10]-'0');
        }

        static void Main(string[] args)
        {
            string pesel = "55030101193";
            string p;
            do
            {
                Console.WriteLine("Podaj pesel: ");
                p = Console.ReadLine();
            } while (p.Length != 11);
            pesel = p;

            Console.WriteLine(jakaPlec(pesel) == 'K' ? "Kobieta" : "Mężczyzna");
            Console.WriteLine("Suma Kontrolna " + (cyfraKontrolna(pesel) ? "zgodna" : "niezgodna"));
        }
    }
}
