using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterServices : ICharacterService
    {

        private static List<Character> characters = new List<Character>
        {
         new Character(),
         new Character{ Id = 1, Name = "Sam"}
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(x => x.Id == id);
            if(character is not null)
                return character;

            throw new Exception("Character not found.");
        }
    }
}