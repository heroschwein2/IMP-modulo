using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IMP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); //Input der ersten Zahl
            int b = Convert.ToInt32(Console.ReadLine()); //Input der zweiten Zahl 
            double result;
            double DivisionResult;
            double DecimalPlace;
            double FullNumber;
            DivisionResult = (double)a / b; //Division der Zahlen
            FullNumber = Math.Floor(DivisionResult); //Abrunden für ganze Zahl
            DecimalPlace = DivisionResult - FullNumber; //Herausfinden der Nachkommastellen
            result = DecimalPlace*b; //Den Rest bestimmen
            Console.WriteLine(FullNumber);//Ausgabe
            Console.WriteLine("Rest:" + result);
            Thread.Sleep(99999999);


        }
    }
}
