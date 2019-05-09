using System;
using System.Collections.Generic;
using System.Text;

namespace Obserwator___wzorzec_projektowy
{
    class DanePogodowe : Subject
    {
        private List<Obserwator> obserwatorzy;
        private float temperature, humidity, pressure;

        public DanePogodowe()
        {
            obserwatorzy = new List<Obserwator>();
        }

        public void powiadomObserwatorow()
        {
            foreach (Obserwator obserwator in obserwatorzy)
            {
                obserwator.aktualizuj(temperature, humidity, pressure);
            }
        }

        public void usunObserwatora(Obserwator o)
        {
            int i = obserwatorzy.IndexOf(o);
            if (i >= 0)
                obserwatorzy.Remove(o);
        }

        public void zarejestrujObserwatora(Obserwator o)
        {
            obserwatorzy.Add(o);
        }

        public void ustawWartosci(float temperature, float humidity, float pressure)
        {
            this.temperature    = temperature;
            this.pressure       = pressure;
            this.humidity       = humidity;
            zmienioneWartosci();
        }

        public void zmienioneWartosci()
        {
            powiadomObserwatorow();
        }
    }
}
