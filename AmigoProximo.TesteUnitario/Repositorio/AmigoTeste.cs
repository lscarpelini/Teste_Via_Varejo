using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmigoProximo.Repositorio;

namespace AmigoProximo.TesteUnitario.Repositorio
{
    /// <summary>
    /// Summary description for AmigoTeste
    /// </summary>
    [TestClass]
    public class AmigoTeste
    {

        private AmigoRepositorio _amigoRepositorio;

        public AmigoTeste()
        {
            _amigoRepositorio = new AmigoRepositorio();
        }


        [TestMethod]
        public void Obter_Teste()
        {
            var amigos = _amigoRepositorio.Obter();
            Assert.IsNotNull(amigos);
        }

        [TestMethod]
        public void Obter_Por_Amigo_Teste()
        {
            var amigo = _amigoRepositorio.Obter(4);
            Assert.IsNotNull(amigo);
        }


    }
}
