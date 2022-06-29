using System;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int codigoUnico = int.Parse(Console.ReadLine());
                set.Add(codigoUnico);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int codigoUnico = int.Parse(Console.ReadLine());
                set1.Add(codigoUnico);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int codigoUnico = int.Parse(Console.ReadLine());
                set2.Add(codigoUnico);
            }

            HashSet<int> total = new HashSet<int>(set);
            total.UnionWith(set1);
            total.UnionWith(set2);

            Console.WriteLine("Total students: " + total.Count);
        }
    }
}

