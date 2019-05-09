using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator___wzorzec_projektowy
{
    class CurrentConditions : Obserwator, DisplayElement
    {
        private float temperature, humidity;
        private Subject danePogodowe;

        public CurrentConditions(Subject danePogodowe)
        {
            this.danePogodowe = danePogodowe;
            danePogodowe.zarejestrujObserwatora(this);
        }

        public void aktualizuj(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Obecne warunki: {0}C stopni i {1}% wilgotności", temperature, humidity);
        }
    }
}
