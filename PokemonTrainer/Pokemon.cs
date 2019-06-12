using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int  Helath { get; set; }

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Helath = health;
        }
    }
}
