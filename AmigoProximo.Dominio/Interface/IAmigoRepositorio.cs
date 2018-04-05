using System.Collections.Generic;

namespace AmigoProximo.Dominio.Interface
{
    public interface IAmigoRepositorio
    {
        ICollection<Amigo> Obter();
        Amigo Obter(int id);
    }
}
