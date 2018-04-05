using AmigoProximo.Dominio.Interface;
using AmigoProximo.Negocio;
using AmigoProximo.Repositorio;
using Ninject.Modules;

namespace AmigoProximo.TesteUnitario
{
    class AmigoProximoExportaModulo : NinjectModule
    {
        public override void Load()
        {
            //Bind(Type.GetType("DI.Data.DIConsoleEntities, DI.Data")).ToSelf().InSingletonScope();
            Bind(typeof(IAmigoRepositorio)).To(typeof(AmigoRepositorio)).InSingletonScope();
            Bind(typeof(IAmigoNegocio)).To(typeof(AmigoNegocio)).InSingletonScope();
        }
    }
}
