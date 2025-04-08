using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPokemon.Model
{
    public internal class Interagir
    {
        public int BrincarPokemon { get; private set; }
        public int AlimentarPokemon { get; private set; }

        public  void Interagir()
        {
            AlimentarPokemon--;
            Console.WriteLine("Você alimentou o Pokemon!");
            Console.WriteLine($"O Pokemon agora tem {AlimentarPokemon} de energia.");
            Console.WriteLine("Você quer brincar com o Pokemon? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() == "s")
            {
                BrincarPokemon++;
                Console.WriteLine("Você brincou com o Pokemon!");
                Console.WriteLine($"O Pokemon agora tem {BrincarPokemon} de energia.");
            }
            else
            {
                Console.WriteLine("Você não brincou com o Pokemon.");
            }
        }
    }
}
