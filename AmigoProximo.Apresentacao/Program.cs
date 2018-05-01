using AmigoProximo.Dominio.Interface;
using AmigoProximo.Negocio;
using Ninject;
using System;

namespace AmigoProximo.Apresentacao
{
    class Program
    {

        static IAmigoNegocio _amigoNegocio;

        static string _sair = "N"; 


        static void Main(string[] args)
        {
            //Injeção de Dependencia
            IKernel kernel = new StandardKernel(new AmigoProximoExportaModulo());
            _amigoNegocio = kernel.Get<AmigoNegocio>();

            //Ajusta cor do console
            Console.ForegroundColor = ConsoleColor.White;

            //Mantem o sistema rodando até que o usuário digite "S" para sair do sistema
            while (_sair.ToUpper() == "N")
            { 
                CarregaAmigosProximos();
            }
        }

        static void CarregaAmigosProximos()
        {
            try
            {
                CarregaCabecalho();

                //Lista Amigos Disponíveis
                Console.WriteLine("\n=========== Lista de Amigos ============\n");
                var listaAmigos = _amigoNegocio.Obter();
                foreach (var amigo in listaAmigos)
                {
                    Console.WriteLine(amigo.Id + " - " + amigo.Nome + " - " + amigo.Cidade);
                }

                //Solicita o código do Amigo que esta visitando
                Console.Write("\nDigite o Código do Amigo que esta visitando + Enter: \n");
                Console.Write("\nDigite 'S' + Enter para sair: \n");

                string idAmigo = "";
                idAmigo = Console.ReadLine();

                //Verifica se usuário deseja sair do sistema
                Sair(idAmigo);

                //Lista Amigos proximos
                var listaAmigosProximos = _amigoNegocio.ObterAmigosProximos(Convert.ToInt16(idAmigo));
                Console.Write("\n=========== Amigos mais proximos listados abaixo ==============\n");
                foreach (var amigoProximo in listaAmigosProximos)
                {
                    Console.WriteLine("\nCódigo:" + amigoProximo.Id);
                    Console.WriteLine("nome:" + amigoProximo.Nome);
                    Console.WriteLine("Cidade:" + amigoProximo.Cidade);
                    Console.WriteLine("Distância:" + amigoProximo.Distancia + "\n");
                }

                //Espera retorno para continuar no sistema ou sair
                Console.Write("\nDigite 'N' + Enter para nova consulta. \nDigite qualquer tecla + Enter para sair do sistema. \n");
                
                //Verifica se usuário deseja sair do sistema
                Sair(Console.ReadLine());

                //Limpa o console
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nFavor digitar um Código correto para busca.\n" );
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");   
            }
        }

        static void CarregaCabecalho()
        {
            //Monta cabeçalho da aplicação
            Console.WriteLine("***********************************************************************\n");
            Console.WriteLine("*                         -=  AMIGO PRÓXIMO  =-                       *\n");
            Console.WriteLine("*              (Digite 'S' + Enter para sair do sistema)              *\n");
            Console.WriteLine("***********************************************************************\n");
        }

        static void Sair(string valorDigitado)
        {
            //Metodo para sair do sistema
            if (valorDigitado.ToUpper() == "S")
            {
                _sair = "S";
            }
            else
            {
                _sair = "N";
            }

        }

    }
}
