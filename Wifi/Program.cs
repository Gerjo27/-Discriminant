using System;
using System.Collections.Generic;
namespace Wifi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = ReadInt("Введитие а >> ");
            int b = ReadInt("Введитие b >> ");
            int c = ReadInt("Введитие c >> ");

            int i = 0;
            foreach (int Part in CalcRoot(a, b, c))
            {
                Console.WriteLine("x" + ++i + "=" + Part);
            }
            Console.WriteLine("Пока");
            Console.ReadLine ();
        }

        public static int ReadInt(string text) {
            Console.Write(text);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public static int CalcDiscriminant (int a,int b,int c)
        {
            int Discriminant = ((b * b) - (4 * a * c));
            Console.WriteLine ("Дискриминант = " + Discriminant);
            return Discriminant;
        }
      public static List<int> CalcRoot(int a, int b, int c)
        {
            int discriminant = CalcDiscriminant(a,b,c);
            var roots = new List<int>();

            if (discriminant < 0)
            {
                Console.WriteLine("Корней нет");
            } else if (discriminant == 0)
            {
                int root = ((-b) / (2 * a));
                roots.Add(root);
            } else if (discriminant > 0)
            {
              int root1, root2;
                root1 = ((-b + Convert.ToInt32 (Math.Sqrt(discriminant))) / (2 *a));
                root2 = ((-c - Convert.ToInt32 (Math.Sqrt(discriminant))) / (2 *a));
                
               
                roots.Add(root1);
                roots.Add(root2);
               
            }
            return roots;
        }
    }
}