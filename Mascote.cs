
using System.Text.Json;

namespace ApiPokemon
{
    public class Mascote
    {
        public List<AbilitiesClass> abilities { get; set; }
        public int altura { get; set; }
        public int peso { get; set; }
        public string nome { get; set; }

        public static Mascote FromJson(string json)
        {
            return JsonSerializer.Deserialize<Mascote>(json);
        }
    }

}
