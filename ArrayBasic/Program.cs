using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            multiply();
            Console.WriteLine();
            createArray();
            Console.WriteLine();
            arrayContain();
            Console.WriteLine();
            arrayAvgWholeNo();
            Console.WriteLine();
            countPosiNega();
            Console.WriteLine();
            evenodd();

        }

        public static void multiply()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("First");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}

            //Console.WriteLine("Second");
            //for (int i = 0;i < b.Length; i++)
            //{
            //    Console.Write(b[i] + " ");
            //}

            Console.WriteLine("Array1: [{0}]", string.Join(", ", a));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", b));

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] * b[i]);
            }
        }

        public static void createArray()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            int[] c = { 7, 8, 9 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", a));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", b));
            Console.WriteLine("Array3: [{0}]", string.Join(", ", c));


            int[] d = { a[1], b[1], c[1] };

            Console.WriteLine("New Array: [{0}]", string.Join(", ", d));

        }

        public static void arrayContain()
        {
            int[] a = { 1, 3, 4, 5, 6 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", a));

            int n = 3;
            Console.WriteLine("Array contain {0}", n);
            Console.WriteLine(a.Contains(n));

            int n1 = 7;
            Console.WriteLine("Array contain {0}", n1);
            Console.WriteLine(a.Contains(n1));
        }

        public static void arrayAvgWholeNo()
        {
            int[] a = { 1, 2, 3, 5, 4, 2, 3, 4 };
            int[] b = { 2, 4, 2, 6, 4, 8 };

            Console.WriteLine("Array avg is whole no or not");
            Console.WriteLine("Array1: [{0}]", string.Join(", ", a));
            Console.WriteLine(a.Average() % 1 == 0);

            Console.WriteLine("Array2: [{0}]", string.Join(", ", b));
            Console.WriteLine(b.Average() % 1 == 0);
        }


        public static void countPosiNega()
        {
            int[] a = { 1, 2, 3, 4, -2, 5, -11, -5, -7, 8, 9 };

            Console.WriteLine("Array: [{0}]", string.Join(", ", a));

            var pos = a.Where(n => n > 0);
            var neg = a.Where(n => n < 0);

            Console.WriteLine("Positive no: " + pos.Count());
            Console.WriteLine("Negative no: " + neg.Count());
        }


        public static void evenodd()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("Array: [{0}]", string.Join (", ", a));

            Console.WriteLine("Even : ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i] + " ");
                }
               
            }

            Console.WriteLine();
            Console.WriteLine("Odd : ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write(a[i] + " ");
                }

            }
        }
    }
}

 