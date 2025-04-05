
namespace ApiPokemon
{
    public class Pokemon : AbilitiesClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public IEnumerable<AbilitiesClass> Abilities { get; set; }
        public IEnumerable<object> Types { get; set; }
    }
   

}