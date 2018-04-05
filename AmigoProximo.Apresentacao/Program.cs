using System;

namespace AmigoProximo.Apresentacao
{
    class Program
    {

        static AmigoProximo.Negocio.AmigoNegocio _amigoNegocio;
        static string _sair = "N"; 

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            while (_sair.ToUpper() == "N")
            { 
                CarregaAmigosProximos();
            }
        }

        static void CarregaAmigosProximos()
        {
            try
            {
                Console.WriteLine("\n=========== Lista de Amigos ============\n");

                _amigoNegocio = new Negocio.AmigoNegocio();
                var listaAmigos = _amigoNegocio.Obter();
                foreach (var amigo in listaAmigos)
                {
                    Console.WriteLine(amigo.Id + " - " + amigo.Nome + " - " + amigo.Cidade);
                }

                Console.Write("\n=========== Digite o Código do Amigo que esta visitando + Enter: =============\n");

                string idAmigo = "";
                idAmigo = Console.ReadLine();

                var listaAmigosProximos = _amigoNegocio.ObterAmigosProximos(Convert.ToInt16(idAmigo));

                Console.Write("\n=========== Amigos mais proximos listados abaixo ==============\n");

                foreach (var amigoProximo in listaAmigosProximos)
                {
                    Console.WriteLine("\nCódigo:" + amigoProximo.Id);
                    Console.WriteLine("nome:" + amigoProximo.Nome);
                    Console.WriteLine("Cidade:" + amigoProximo.Cidade);
                    Console.WriteLine("Distância:" + amigoProximo.Distancia + "\n");
                }

                Console.Write("\nDigite 'N' + Enter para nova consulta. \nDigite qualquer tecla + Enter para sair do sistema. \n");

                _sair = Console.ReadLine();

                Console.Clear();
            }
            catch (Exception)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n Favor digitar um Código correto para busca. \n" );
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                
            }
        }
    }
}
