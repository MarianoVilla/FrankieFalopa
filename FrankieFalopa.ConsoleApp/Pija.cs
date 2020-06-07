using System;
using System.Collections.Generic;
using System.Text;

namespace FrankieFalopa.ConsoleApp
{
    public class Pija
    {
        public int Tamanio;
        public Pija()
        {
            Tamanio = 1;
        }
        public string Eyacular()
        {
            return "Placer";
        }
        public void Erectarse(string Porno)
        {
            if (Porno.Length > 30)
            {
                throw new ArgumentException("El tamaño es inhumano.");
            }
            int i = 0;
            while (Porno.Length > i)
            {
                Tamanio++;
                i++;
            }
        }
        public void Erectarse(string MarcaViagra, int Cantidad)
        {
            string MarcaSinEspaciosEnMinuscula = MarcaViagra.ToLower().Replace(" ", "");

            switch (MarcaSinEspaciosEnMinuscula)
            {
                case "lachiquita": Tamanio += Cantidad; break;
                case "lamedianita": Tamanio += Cantidad * 2; break;
                case "mandinga": Tamanio += Cantidad * 4; break;
                default: return;
            }
        }

    }
}
