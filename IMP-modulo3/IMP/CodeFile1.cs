using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IMP
{
    class kongruent
    {
        public static int a;
        public static int m;
        public static double ResultA;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            int first = Convert.ToInt32(Console.ReadLine()); //Input der ersten Zahl
            a = first;
            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine()); //Input der zweiten Zahl
            Console.WriteLine("Enter m:");
            m = Convert.ToInt32(Console.ReadLine()); //Input der zweiten Zahl
            RestA();
            a = b;
            double resultA = ResultA;
            RestA();
            if(resultA==ResultA)
            {
                Console.WriteLine(first+" und "+b+" sind kongruent modulo "+m);
            }
            else
            {
                Console.WriteLine(first+" und "+b+" sind NICHT kongruent modulo "+m);
            }
            Thread.Sleep(99999);
        }

        public static void RestA()
        {
            //Test
            double DivisionResult;
            double DecimalPlace;
            double FullNumber;
            DivisionResult = (double)a / m; //Division der Zahlen
            FullNumber = Math.Floor(DivisionResult); //Abrunden für ganze Zahl
            DecimalPlace = DivisionResult - FullNumber; //Herausfinden der Nachkommastellen
            ResultA = DecimalPlace * m; //Den Rest bestimmen
        }
    }
}