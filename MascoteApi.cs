using ApiPokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPokemon
{
    public class MascoteApi
    {
        private List<AbilitiesClass>? abilities;
        private int altura;
        private int peso;
        private string nome;

        public override bool Equals(object? obj) => obj is Mascote mascote &&
                   EqualityComparer<List<AbilitiesClass>>.Default.Equals(abilities, mascote.abilities) &&
                   altura == mascote.altura &&
                   peso == mascote.peso &&
                   nome == mascote.nome;
    }
}
