using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];

                int pokemonHealth = int.Parse(input[3]);

                if (!trainers.ContainsKey(trainerName))
                    trainers.Add(trainerName, new Trainer(trainerName));

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers[trainerName].Pokemon.Contains(pokemon))
                    trainers[trainerName].Pokemon.Add(pokemon);

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string element = Console.ReadLine();

            Predicate<Trainer> predicate = t => t.Pokemon.Any(p => p.Element == element);

            while (element != "End")
            {
                foreach (var (trainerName, trainer) in trainers)
                {
                    if (predicate(trainer))
                        trainer.BadgeCount++;

                    else
                    {
                        foreach (Pokemon pokemon in trainer.Pokemon)
                            pokemon.Health -= 10;

                        trainer.Pokemon = trainer.Pokemon.Where(p => p.Health > 0).ToList();
                    }
                }

                element = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(t => t.Value.BadgeCount).ToDictionary(t => t.Key, t => t.Value);

            foreach (var (trainerName, trainer) in trainers)
                Console.WriteLine($"{trainerName} {trainer.BadgeCount} {trainer.Pokemon.Count}");
        }
    }
}
