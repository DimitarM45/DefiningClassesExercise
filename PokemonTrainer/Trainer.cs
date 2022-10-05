using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;

        private int badgeCount;

        private List<Pokemon> pokemon;

        public Trainer(string name)
        {
            Pokemon = new List<Pokemon>();

            BadgeCount = 0;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int BadgeCount
        {
            get { return this.badgeCount; }
            set { this.badgeCount = value; }
        }

        public List<Pokemon> Pokemon
        {
            get { return this.pokemon; }
            set { this.pokemon = value; }
        }
    }
}
