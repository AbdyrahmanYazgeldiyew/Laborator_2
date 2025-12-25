using System;

namespace ProblemeSecvente
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aici poți apela metoda corespunzătoare problemei pe care vrei să o testezi.
            // Exemplu: Problema1();

            Console.WriteLine("Selectati numarul problemei (1-17):");
            int p = int.Parse(Console.ReadLine());

            switch (p)
            {
                case 1: Problema1(); break;
                case 2: Problema2(); break;
                case 3: Problema3(); break;
                case 4: Problema4(); break;
                case 5: Problema5(); break;
                case 6: Problema6(); break;
                case 7: Problema7(); break;
                case 8: Problema8(); break;
                case 9: Problema9(); break;
                case 10: Problema10(); break;
                case 11: Problema11(); break;
                case 12: Problema12(); break;
                case 13: Problema13(); break;
                case 14: Problema14(); break;
                case 15: Problema15(); break;
                case 16: Problema16(); break;
                case 17: Problema17(); break;
                default: Console.WriteLine("Problema inexistenta."); break;
            }
        }

        // 1. Cate numere sunt pare
        static void Problema1()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) count++;
            }
            Console.WriteLine($"Pare: {count}");
        }

        // 2. Negative, Zero, Pozitive
        static void Problema2()
        {
            int n = int.Parse(Console.ReadLine());
            int neg = 0, zero = 0, poz = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0) neg++;
                else if (x == 0) zero++;
                else poz++;
            }
            Console.WriteLine($"Negative: {neg}, Zero: {zero}, Pozitive: {poz}");
        }

        // 3. Suma si Produsul 1..n
        static void Problema3()
        {
            int n = int.Parse(Console.ReadLine());
            long suma = 0, produs = 1;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma: {suma}, Produs: {produs}");
        }

        // 4. Pozitia lui a in secventa
        static void Problema4()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a && poz == -1) poz = i;
            }
            Console.WriteLine(poz);
        }

        // 5. Elemente egale cu pozitia
        static void Problema5()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i) count++;
            }
            Console.WriteLine(count);
        }

        // 6. Daca secventa este crescatoare
        static void Problema6()
        {
            int n = int.Parse(Console.ReadLine());
            bool ok = true;
            int prev = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < prev) ok = false;
                prev = x;
            }
            Console.WriteLine(ok);
        }

        // 7. Max si Min
        static void Problema7()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < min) min = x;
                if (x > max) max = x;
            }
            Console.WriteLine($"Min: {min}, Max: {max}");
        }

        // 8. Al n-lea Fibonacci (f1=0, f2=1)
        static void Problema8()
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 1) Console.WriteLine(0);
            else if (n == 2) Console.WriteLine(1);
            else
            {
                long f1 = 0, f2 = 1, fn = 0;
                for (int i = 3; i <= n; i++)
                {
                    fn = f1 + f2;
                    f1 = f2;
                    f2 = fn;
                }
                Console.WriteLine(fn);
            }
        }

        // 9. Secventa monotona
        static void Problema9()
        {
            int n = int.Parse(Console.ReadLine());
            bool cresc = true, desc = true;
            int prev = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < prev) cresc = false;
                if (x > prev) desc = false;
                prev = x;
            }
            Console.WriteLine(cresc || desc);
        }

        // 10. Max numere consecutive egale
        static void Problema10()
        {
            int n = int.Parse(Console.ReadLine());
            int maxS = 1, crtS = 1;
            int prev = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == prev) crtS++;
                else { if (crtS > maxS) maxS = crtS; crtS = 1; }
                prev = x;
            }
            if (crtS > maxS) maxS = crtS;
            Console.WriteLine(maxS);
        }

        // 11. Suma inverselor
        static void Problema11()
        {
            int n = int.Parse(Console.ReadLine());
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                if (x != 0) suma += 1.0 / x;
            }
            Console.WriteLine(suma);
        }

        // 12. Grupuri de numere (cuvinte)
        static void Problema12()
        {
            int n = int.Parse(Console.ReadLine());
            int grupuri = 0;
            bool inGrup = false;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x != 0 && !inGrup) { grupuri++; inGrup = true; }
                else if (x == 0) inGrup = false;
            }
            Console.WriteLine(grupuri);
        }

        // 13. Secventa crescatoare rotita
        static void Problema13()
        {
            int n = int.Parse(Console.ReadLine());
            int primul = int.Parse(Console.ReadLine());
            int prev = primul, puncteRuptura = 0;
            for (int i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < prev) puncteRuptura++;
                prev = x;
            }
            if (prev > primul) puncteRuptura++; // Verificam rotirea capetelor
            Console.WriteLine(puncteRuptura <= 1);
        }

        // 14. Secventa monotona rotita
        static void Problema14()
        {
            // O secventa monotona rotita este fie crescatoare rotita, fie descrescatoare rotita
            // Logica similara cu P13 pentru ambele cazuri.
            Console.WriteLine("Logica: Verificati puncte de ruptura pt crescator si descrescator.");
        }

        // 15. Secventa bitonica
        static void Problema15()
        {
            int n = int.Parse(Console.ReadLine());
            int prev = int.Parse(Console.ReadLine());
            int i = 1;
            // Urcam
            while (i < n)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < prev) { prev = x; i++; break; }
                prev = x; i++;
            }
            // Coboram
            bool ok = true;
            while (i < n)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > prev) ok = false;
                prev = x; i++;
            }
            Console.WriteLine(ok);
        }

        // 16. Secventa bitonica rotita
        static void Problema16()
        {
            Console.WriteLine("Necesita verificarea tuturor rotirilor posibile sau gasirea punctului de extrem.");
        }

        // 17. Paranteze (0=deschis, 1=inchis)
        static void Problema17()
        {
            int n = int.Parse(Console.ReadLine());
            int nivel = 0, maxNivel = 0;
            bool ok = true;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0) { nivel++; if (nivel > maxNivel) maxNivel = nivel; }
                else { nivel--; }
                if (nivel < 0) ok = false;
            }
            if (nivel != 0) ok = false;
            Console.WriteLine(ok ? $"Corect, nivel {maxNivel}" : "Incorect");
        }
    }
}