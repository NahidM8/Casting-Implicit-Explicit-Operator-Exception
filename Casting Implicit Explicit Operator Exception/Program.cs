using Casting_Implicit_Explicit_Operator_Exception.Enums;
using Casting_Implicit_Explicit_Operator_Exception.Models;

namespace Casting_Implicit_Explicit_Operator_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Celsius c = new Celsius(100);
            //Kelvin K = c;
            //Console.WriteLine(K.Degree);

            //Exchange(Currencyy.Usd, 45);
            //Exchange(Currencyy.Try, 150);
            //Exchange(Currencyy.Eur, 22);

            //Book book1 = new("Book1", 25, "Author1", 300, 4);
            //Book book2 = new("Book2", 30, "Author2", 400, 2);

            //book1.Sell();
            //book2.Sell();
            //Console.WriteLine(book1.Count);
            //Console.WriteLine(book2.Count);

            //book1.ShowInfo();

        }
        public static void Exchange(Currencyy c,double azn)
        {
            if (c != Currencyy.Usd && c != Currencyy.Eur && c != Currencyy.Try)
            {
                Console.WriteLine("Invalid currency.");
                return;
            }

            var result = c switch
            {
                Currencyy.Usd => azn * 0.59,
                Currencyy.Eur => azn * 0.52,
                Currencyy.Try => azn * 22.94,
            };
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
