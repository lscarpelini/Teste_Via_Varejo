using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmigoProximo.Negocio;
using AmigoProximo.Dominio.Interface;
using Ninject;

namespace AmigoProximo.TesteUnitario.Negocio
{
    [TestClass]
    public class AmigoTeste
    {

        private IAmigoNegocio _amigoNegocio;

        public AmigoTeste()
        {
            IKernel kernel = new StandardKernel(new AmigoProximoExportaModulo());
            _amigoNegocio = kernel.Get<AmigoNegocio>();
        }
        

        [TestMethod]
        public void ObterAmigosProximos_Teste()
        {
            var amigosProximos = _amigoNegocio.ObterAmigosProximos(1);
            Assert.AreEqual(3, amigosProximos.Count);   
        }
    }
}
