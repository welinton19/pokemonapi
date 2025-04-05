using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPokemon
{
    public class Menu : Pokemon
    {
        public static object Nome { get;  set; }

        public static void ShowHeader()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Bem-vindo ao sistema de Pokemon!");
            Console.WriteLine("===================================");
        }
        public static void menuApresentacao() 
        {
            Console.WriteLine("Qual é o seu     Nome?");
            Console.ReadLine();
        }
        public static void menuPrincipal() 
        {
            Console.WriteLine( "{Nome} você deseja");
            Console.WriteLine("1 - Adotar um Mascote Virtual");
            Console.WriteLine("2 - Ver Mascotes");
            Console.WriteLine("3 - Sair");

        }
        public static void menuOpcao()
        {
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    MenuMascote.adoteMascote();
                    break;
                case "2":
                    MenuMascote.verMascotes();
                    break;
                case "3":
                    MenuMascote.sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        public static void ShowFooter()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Obrigado por usar o sistema de Pokemon!");
            Console.WriteLine("===================================");
        }
    

       //
}
