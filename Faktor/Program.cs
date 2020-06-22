using System;

namespace Faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faktor
            // https://open.kattis.com/problems/faktor 
            // (ceiling function)

            var parameters = Enter2Nums();
            var articlesNum = parameters[0];
            var impactFakt = parameters[1];

            Console.WriteLine(MinNumOfScientists(articlesNum, impactFakt));
        }
        private static int MinNumOfScientists(int artNum, int impactfact)
        {
            double art = (double)artNum;
            double b = (double)impactfact;
            double minFact = b - 0.99;
            return (int) Math.Ceiling(minFact * art);
        }
        private static int[] Enter2Nums()
        {
            var arr = new string[2] { "", "" };
            var res = new int[2] { 0,0};
            try
            {
                arr = Console.ReadLine().Split(' ', 2);
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                    if (res[i] < 1 || res[i] > 100)
                        throw new ArgumentException();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enter2Nums();
            }
            return res;
        }
    }
}
