using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoProximo.Dominio.Interface
{
    public interface IAmigoNegocio
    {
        ICollection<Amigo> Obter();
        ICollection<Amigo> ObterAmigosProximos(int idVisitante);
    }
}
