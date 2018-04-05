using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmigoProximo.Negocio;
using System.Collections.Generic;
using System.Linq;

namespace AmigoProximo.TesteUnitario.Negocio
{
    [TestClass]
    public class AmigoTeste
    {

        private AmigoNegocio _amigoNegocio;

        public AmigoTeste()
        {
            _amigoNegocio = new AmigoNegocio();
        }
        

        [TestMethod]
        public void ObterAmigosProximos_Teste()
        {
            var amigosProximos = _amigoNegocio.ObterAmigosProximos(1);
            Assert.AreEqual(3, amigosProximos.Count);   
        }
    }
}
