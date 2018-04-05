using AmigoProximo.Dominio;
using AmigoProximo.Dominio.Interface;
using System.Collections.Generic;
using System.Linq;

namespace AmigoProximo.Repositorio
{
    public class AmigoRepositorio : IAmigoRepositorio
    {
        ICollection<Amigo> Amigos;

        public AmigoRepositorio()
        {
            Amigos = new List<Amigo>() {
                     new Amigo(1, "José Rafael",  "São Bernardo do Campo",    new Coordenada(23.6894613, 46.5528114)),
                     new Amigo(2, "José Anibal",  "São Paulo",                new Coordenada(23.535485,  46.6758257)),
                     new Amigo(3, "José Humberto","Buenos Aires",             new Coordenada(34.6141779, 58.3994436)),
                     new Amigo(4, "José Pedro",   "Montevideo",               new Coordenada(34.9114619, 56.1549949)),
                     new Amigo(5, "José Estácio", "Santiago",                 new Coordenada(33.4558789, 70.6868588)),
                     new Amigo(6, "José Afonso",  "Orlando",                  new Coordenada(28.3200879, 81.4631435)),
                     new Amigo(7, "José Moacir",  "Miami",                    new Coordenada(25.7492154, 80.2695805)),
                     new Amigo(8, "José Inácio", "Chicago",                   new Coordenada(41.7543194, 87.6420375))
            };
        }

        public ICollection<Amigo> Obter()
        {
            return Amigos;
        }

        public Amigo Obter(int id)
        {
            return Amigos.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
