using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreinoMVC.Controllers;
using System.Web.Mvc;
using System.Web.WebPages;
using TreinoMVC.Models;


namespace TreinoMVCTeste
{
    [TestClass]
    public class TreinoMVCteste
    {
        GerarJogoController gerarJogoController = new GerarJogoController();
        HomeController homeController = new HomeController();
        NovoJogoController novoJogoController = new NovoJogoController();
        ResultadoController resultadoController = new ResultadoController();
        Numero numero = new Numero();
 
        [TestInitialize]
        public void IniciarTestes()
        {

        }

        [TestMethod]
        public void TestGerarJogos()
        {
            gerarJogoController.Gerarjogo();
        }

        [TestMethod]
        public void TestNovoJogo()
        {
            novoJogoController.NovojogoCadastro(2, 3, 4, 5, 6, 7);
        }

        [TestMethod]
        public void Limparjogo()
        {
            gerarJogoController.Limparjogo();
        }

        [TestMethod]
        public void TestResultado()
        {
            resultadoController.Resultado();
        }

        [TestMethod]
        public void GerarNumeros()
        {
            numero.GerarNumeros();
        }

        [TestCleanup]
        public void FinalizarTestes()
        {

        }
    }
}
