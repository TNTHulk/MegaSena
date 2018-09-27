using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TreinoMVC.Models;

namespace TreinoMVC.Models
{
    public class Jogo
    {
        public static List<Jogo> jo = new List<Jogo>();
        public Jogo()
        {
            this.Id = -1;
            this.Data = DateTime.Now;
            this.Numeros = new List<Numero>();
        }
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<Numero> Numeros { get; set; }
    }

}