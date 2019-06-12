using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var trainersList = new List<Trainer>();


            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                var pokemonInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = pokemonInfo[0];
                string pokemonName = pokemonInfo[1];
                string pokemonElement = pokemonInfo[2];
                int pokemonHealth = int.Parse(pokemonInfo[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);


                Trainer currentTrainer = trainersList.FirstOrDefault(x => x.Name == trainerName);

                if (currentTrainer == null)
                {
                    currentTrainer = new Trainer(trainerName);
                    trainersList.Add(currentTrainer);

                }

                currentTrainer.PokemonCollection.Add(currentPokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var trainer in trainersList)
                {
                    if (trainer.PokemonCollection.Any(x => x.Element == input))
                    {
                        trainer.NumberOfBadges += 1;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.PokemonCollection)
                        {
                            pokemon.Helath -= 10;
                        }
                    }
                }

                foreach (var trainer in trainersList)
                {
                    trainer.PokemonCollection.RemoveAll(x => x.Helath <= 0);
                }

                input = Console.ReadLine();
            }

            foreach (var trainer in trainersList.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
            }
        }
    }
}
