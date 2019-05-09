using System;

namespace Obserwator___wzorzec_projektowy
{
    class Program
    {
        static void Main(string[] args)
        {
            DanePogodowe danePogodowe = new DanePogodowe();

            CurrentConditions currentDisplay = new CurrentConditions(danePogodowe);

            danePogodowe.ustawWartosci(80, 30, 90);
            danePogodowe.ustawWartosci(30, 10, 70);
            danePogodowe.ustawWartosci(34, 16, 68);


            Console.ReadLine();
        }
    }
}
