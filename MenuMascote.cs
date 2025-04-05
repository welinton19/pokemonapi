using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPokemon
{
    public class MenuMascote
    {
        public static void adoteMascote()
        {
            Console.WriteLine("Você adotou um Mascote Virtual!");
            Console.WriteLine("Nome: {Nome}");
            Console.WriteLine("Altura: {Altura}");
            Console.WriteLine("Peso: {Peso}");
            Console.WriteLine("Habilidades: {Habilidades}");
        }
        public static void verMascotes()
        {
            Console.WriteLine("Aqui estão os seus mascotes:");
            
        }
        public static void sair()
        {
            Console.WriteLine("Obrigado por usar o sistema de Pokemon!");
            Environment.Exit(0);
        }
        public static void menuPrincipal()
        {
            Console.WriteLine("1 - Adotar um Mascote Virtual");
            Console.WriteLine("2 - Ver Mascotes");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    adoteMascote();
                    break;
                case "2":
                    verMascotes();
                    break;
                case "3":
                    sair();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
