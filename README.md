DESAFIO 7 DAYS OF CODE C#

Esse desafio testa os conhecimentos e faz o desenvovedor a criar um aplicativo com API e um menu interativo 
sing System.Text;
using System.Text.Json;

namespace ApiPokemon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChamarPokemonGet();
            ChamarPokemonPost();
        }
        // Este é um exemplo de como fazer uma chamada GET e POST para a API do Pokemon.
        public static void menuPrincipal()
        {
            Menu.ShowHeader();
            Menu.menuApresentacao();
            Menu.menuPrincipal();
            Menu.menuOpcao();
            Menu.ShowFooter();
        }

        
