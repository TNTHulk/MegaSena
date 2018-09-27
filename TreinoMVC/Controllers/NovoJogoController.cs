using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinoMVC.Models;

namespace TreinoMVC.Controllers
{
    public class NovoJogoController : Controller
    {
        // GET: NovoJogo
        public ActionResult NovojogoCadastro(int? n1, int? n2, int? n3, int? n4, int? n5, int? n6)
        {
            int?[] numeros = { n1, n2, n3, n4, n5, n6 };
            var numerosHashSet = new HashSet<int?>(numeros);
            var repetidos = numeros.Length - numerosHashSet.Count;
            if (repetidos == 0)
            {
                Jogo j = new Jogo();
                Numero r = new Numero();
                {
                    j.Id = Jogo.jo.Count();
                    j.Data = DateTime.Now;
                };
                r.Numeros.Add(n1);
                r.Numeros.Add(n2);
                r.Numeros.Add(n3);
                r.Numeros.Add(n4);
                r.Numeros.Add(n5);
                r.Numeros.Add(n6);
                j.Numeros.Add(r);
                Jogo.jo.Add(j);
            }
            else
            {
                throw new System.ArgumentException("Jogo não pode ter números repetidos", "original");
            }
            return View(Jogo.jo);
        }

        public ActionResult Novojogo()
        {
            return View(Jogo.jo);
        }
    }

}