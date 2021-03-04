using Banco.Serie;
using DIO.Series;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series
{
    class Program
    {

        static SerieRepositorio repositorio = new SerieRepositorio();
        public static void main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":

                        ListarSeries();
                        break;

                    case "2":

                        InserirSerie();
                        break;

                    case "3":

                        AtualizarSerie();
                        break;

                    case "4":

                        ExcluirSerie();
                        break;

                    case "5":

                        InserirSerie();
                        break;

                    case "C":

                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
         
        private static void ListarSerie()
        {

            Console.WriteLine("Listar Series");
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie cadastrada.");
                return;
            }

            foreach(var serie in lista)
            {
                Console.WriteLine("#id {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }


        private static string ObterOpcaoUsuario()
        {

            Console.WriteLine(); 
            Console.WriteLine("DIO SERIES a seu dispor!!");
            Console.WriteLine("Informe a opcao");
            Console.WriteLine("1 - Listar series");
            Console.WriteLine("2 - Inserir nova serie");
            Console.WriteLine("3 - Atualizar Serie");
            Console.WriteLine("4 - Excluir serie");
            Console.WriteLine("5 Vizualizar serie");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}