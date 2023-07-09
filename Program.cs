using System;

namespace Lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
             Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura.
Scrieti functii care vor returna
• Cel mai mare numar din vector
• Cel mai mic numar din vector
• Numerele divizibile cu 3
• Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul
             */

            Console.WriteLine("Introduceti lungimea vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] vectorIntregi;
            vectorIntregi = new int[n];
            //int multipluTrei = 0;


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti al {i + 1} lea numar din vector");
                vectorIntregi[i] = int.Parse(Console.ReadLine());

            }


            Console.WriteLine();

            Console.Write("Vectorul original este ");

            foreach (int i in vectorIntregi)

            {

                Console.Write($"{i} ");

            }

            Console.WriteLine();

            Console.WriteLine($"Cel mai mare numar din vector este: {ObtineCelMaiMareNumar(vectorIntregi)}");

            Console.WriteLine($"Cel mai mic numar din vector este: {ObtineCelMaiMicNumar(vectorIntregi)}");

            Console.Write("Multipli de 3: ");

            foreach (int i in ObtineNumereleDivizibileCuTrei(vectorIntregi))

            {

                Console.Write($"{i} ");

            }

            Console.WriteLine();

            Console.Write($"Vectorul inversat este: ");

            foreach (int i in Vectorinversat(vectorIntregi))

            {

                Console.Write($"{i} ");

            }
            Console.WriteLine();

            Console.Write("Numere prime: ");

            foreach (int i in ObtineNumerePrime(vectorIntregi))

            {

                Console.Write($"{i} ");

            }



        }
        static int ObtineCelMaiMareNumar(int[] n)
        {

            int result = n[0];

            for (int i = 1; i < n.Length; i++)
                if (result <= n[i])
                {
                    result = n[i];
                }


            return result;
        }

        static int ObtineCelMaiMicNumar(int[] n)
        {

            int result = n[0];

            for (int i = 1; i < n.Length; i++)
                if (result >= n[i])
                {
                    result = n[i];
                }


            return result;
        }

        static int[] ObtineNumereleDivizibileCuTrei(int[] n)
        {

            int[] intermediarMultipliDeTrei;
            intermediarMultipliDeTrei = new int[n.Length];
            int contorMultipluTrei = 0;



            for (int i = 0; i < n.Length; i++)

                if (EMultipluDeTrei(n[i]))
                {
                    intermediarMultipliDeTrei[i] = n[i];
                    contorMultipluTrei++;
                }


            int[] multipliTrei;
            multipliTrei = new int[contorMultipluTrei];

            contorMultipluTrei = 0;


            for (int i = 0; i < intermediarMultipliDeTrei.Length; i++)
            {
                if (intermediarMultipliDeTrei[i] != 0)
                {
                    multipliTrei[contorMultipluTrei] = intermediarMultipliDeTrei[i];
                    contorMultipluTrei++;

                }
            }



            return multipliTrei;
        }



        static bool EMultipluDeTrei(int n)
        {
            return n % 3 == 0;
        }


        static int[] Vectorinversat(int[] n)
        {

            int length = n.Length;

            int[] intermediar;
            intermediar = new int[length];

            for (int i = 0; i < length; i++)
            {
                intermediar[length - 1 - i] = n[i];
            }

            for (int i = 0; i < length; i++)
            {
                n[i] = intermediar[i];
            }
            return n;
        }



        static int[] ObtineNumerePrime(int[] n)
        {

            int[] intermediarPrime;
            intermediarPrime = new int[n.Length];
            int contorPrime = 0;



            for (int i = 0; i < n.Length; i++)

                if (EstePrim(n[i]))
                {
                    intermediarPrime[i] = n[i];
                    contorPrime++;
                }


            int[] prime;
            prime = new int[contorPrime];

            contorPrime = 0;


            for (int i = 0; i < intermediarPrime.Length; i++)
            {
                if (intermediarPrime[i] != 0)
                {
                    prime[contorPrime] = intermediarPrime[i];
                    contorPrime++;

                }
            }



            return prime;
        }



        static bool EstePrim(int n)
        {
            bool result = true;
            int zecimale = n;
            double radacina = Math.Sqrt(n);


            for (int i = 2; i <= radacina; i++)
            {
                zecimale = n % i;

                if (zecimale == 0)
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }

    }
}



            
        
