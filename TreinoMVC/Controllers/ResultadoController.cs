using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinoMVC.Models;

namespace TreinoMVC.Controllers
{
    public class ResultadoController : Controller
    {
        public ActionResult Resultado()
        {
            Resultado resultados = new Resultado();
            Jogo testeJ = new Jogo();
            Numero n = new Numero();
            int count = 0;
            n = n.GerarNumeros();

            foreach (var jogo in Jogo.jo)
            {
                foreach (Numero nu in jogo.Numeros)
                {
                    foreach (int c in nu.Numeros)
                    {
                        if (n.Numeros.Contains(c) == true)
                        {
                            count++;
                        }
                   
                    }                    
                }
                if (count == 6)
                {

                    resultados.Sena.Add(jogo);

                }
                else if (count == 5)
                {

                    resultados.Quina.Add(jogo);

                }
                else if (count == 4)
                {

                    resultados.Quadra.Add(jogo);

                }
                count = 0;
            }
            testeJ.Numeros.Add(n);

            resultados.Sorteado.Add(testeJ);
             
            return View(resultados);
        }
    }
}

