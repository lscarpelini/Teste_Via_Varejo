using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmigoProximo.Repositorio;
using AmigoProximo.Dominio.Interface;
using Ninject;

namespace AmigoProximo.TesteUnitario.Repositorio
{
    /// <summary>
    /// Summary description for AmigoTeste
    /// </summary>
    [TestClass]
    public class AmigoTeste
    {

        private IAmigoRepositorio _amigoRepositorio;

        public AmigoTeste()
        {
            IKernel kernel = new StandardKernel(new AmigoProximoExportaModulo());
            _amigoRepositorio = kernel.Get<AmigoRepositorio>();

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
