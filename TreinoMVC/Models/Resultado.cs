using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoMVC.Models
{
    public class Resultado
    {

        public Resultado()
        {
            this.Sena = new List<Jogo>();
            this.Quina = new List<Jogo>();
            this.Quadra = new List<Jogo>();
            this.Sorteado = new List<Jogo>();
        }
 
        public List<Jogo> Sena { get; set; }
        public List<Jogo> Quina { get; set; }
        public List<Jogo> Quadra { get; set; }
        public List<Jogo> Sorteado { get; set; }

    }
}