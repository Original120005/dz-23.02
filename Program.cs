using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz23_02
{
    internal class Program
    {
        class Bankomat : IPrint, ISum, ICurrency
        {
            private int money;
            private string cur;
            public Bankomat() { }
            public Bankomat(int m, string c)
            {
                money = m;
                cur = c;
            }

            public void Print()
            {
                Console.WriteLine($"Sum: {money} {cur}");
            }
            public void Sum()
            {
                Console.Write($"Enter money amount: ");
                money = Convert.ToInt32(Console.ReadLine());
            }
            public void UAH()
            {
                cur = "UAH";
            }
            public void EUR()
            {
                cur = "EUR";
            }
            public void USD()
            {
                cur = "USD";
            }
        }
        interface IPrint
        {
            void Print();
        }
        interface ISum
        {
            void Sum();
        }
        interface ICurrency
        {
            void UAH();
            void EUR();
            void USD();
        }


        static void Main(string[] args)
        {
            Bankomat bank = new Bankomat();
            bank.Sum();
            bank.USD();
            bank.Print();

        }
    }
}