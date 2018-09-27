using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoMVC.Models
{
    public class Numero
    {
        public Numero()
        {
            this.Numeros = new List<int?>();
        }

        public List<int?> Numeros { get; set; }
        public Numero GerarNumeros()
        {
            var r = new Random();
            Numero num = new Numero();
            while (Numeros.Count < 6)
            {
                int numero = r.Next(1, 61);
                if (Numeros.Contains(numero) == false)
                {
                    Numeros.Add(numero);
                }
            }
            num.Numeros = Numeros;
            return num;
        }
    }
}