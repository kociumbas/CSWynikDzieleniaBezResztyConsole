using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5WynikDzieleniaCalkowitego
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 37;
            int b = 11;
            int wynik = 0;
            Console.WriteLine("Program oblicza wynik dzielenia calkowitego dla liczb 37 i 11");
            wynik = a / b; //C# podaje wynik dzielenia int bez reszty
            Console.WriteLine("Wynik dzielenia calkowitego liczb wynosi: {0}", wynik);
            Console.ReadLine();
        }
    }
}
