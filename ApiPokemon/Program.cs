using System.Text;
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
        private static void ChamarPokemonGet()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://pokeapi.co/api/v2/pokemon/1").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
        }
        private static void ChamarPokemonPost()
        {
            var client = new HttpClient();
            var pokemon = new { name = "pikachu", height = 4, weight = 60 };
            var json = JsonSerializer.Serialize(pokemon);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://pokeapi.co/api/v2/pokemon", content).Result;
            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseContent);
        }
    }

    // Este é um exemplo de como fazer uma chamada GET e POST para a API do Pokemon.
}
