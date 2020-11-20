using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTE_WEBAPI_VSCODE.Models;

namespace TESTE_WEBAPI_VSCODE.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
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
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}