using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinoMVC.Models;

namespace TreinoMVC.Controllers
{
    
    public class GerarJogoController : Controller
    {
        

        // GET: GerarJogo
        public static Jogo JogosView()
        {
            Jogo j = new Jogo();
            Numero num = new Numero();
            num = num.GerarNumeros();
            
            j.Id = Jogo.jo.Count;
            j.Data = DateTime.Now;
            j.Numeros.Add(num);

            return j;
        }

       
        public ActionResult GerarjogoCadastro()
        {
            Jogo.jo.Add(JogosView());
            return View(Jogo.jo);
        }
 
        [HttpGet]
        public ActionResult Limparjogo()
        {
            Jogo.jo.Clear();
            return View(Jogo.jo);
        }

        public ActionResult Gerarjogo()
        {
            return View(Jogo.jo);
        }

    }


}