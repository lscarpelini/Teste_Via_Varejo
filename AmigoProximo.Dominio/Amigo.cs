using System;

namespace AmigoProximo.Dominio
{
    public class Amigo
    {
        public Amigo(int id, string nome, string cidade,  Coordenada coordenada)
        {
            Valido(nome, coordenada);
            Id = id;
            Nome = nome;
            Cidade = cidade;
            Coordenada = coordenada;                                           
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cidade { get; private set; }
        public Double Distancia { get; private set; }
        public Coordenada Coordenada { get; private set; }

        private void Valido(string nome, Coordenada coordenada)
        {
            try
            {
                if (string.IsNullOrEmpty(nome))
                    throw new Exception("Nome é de preenchimento obrigatório");
                if (coordenada == null)
                    throw new Exception("Coordenada é de preenchimento obrigatório");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SetDistancia(double distancia)
        {
            Distancia = distancia;
        }

        public string GetDistancia()
        {
            return string.Concat(Distancia, " KM");
        }

        public override string ToString()
        {
            return Nome;
        }

    }


}
