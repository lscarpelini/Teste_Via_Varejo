using AmigoProximo.Dominio;
using AmigoProximo.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmigoProximo.Negocio
{
    public class AmigoNegocio
    {

        AmigoRepositorio _repositorio;

        Amigo _visitante;

        public AmigoNegocio()
        {
            _repositorio = new AmigoRepositorio();
        }

        public ICollection<Amigo> Obter()
        {
            return _repositorio.Obter();
        }


        public ICollection<Amigo> ObterAmigosProximos(int idVisitante)
        {

            _visitante = _repositorio.Obter(idVisitante);

            ICollection<Amigo> amigoList = new List<Amigo>();

            var amigos = _repositorio.Obter().Where(x => x.Id != idVisitante).ToList();

            foreach (var amigo in amigos)
            {
                amigo.SetDistancia(CalculaDistancia(_visitante.Coordenada, amigo.Coordenada));

                amigoList.Add(amigo);
            }

            return amigoList.OrderBy(x => x.Distancia).Take(3).ToList();
        }

        private double CalculaDistancia(Coordenada coordenadaVisitante, Coordenada coordenadaAmigo)
        {
            double rlat1 = Math.PI * coordenadaVisitante.Latitude / 180;
            double rlat2 = Math.PI * coordenadaAmigo.Latitude / 180;

            double theta = coordenadaVisitante.Longitude - coordenadaAmigo.Longitude;

            double rtheta = Math.PI * theta / 180;

            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);

            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return Math.Round(dist * 1.609344, 2);
        }
    }
}
