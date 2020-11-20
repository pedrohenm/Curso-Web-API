using System.Collections.Generic;
using System.Threading.Tasks;
using TESTE_WEBAPI_VSCODE.Models;

namespace TESTE_WEBAPI_VSCODE.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById (int id);
        Task<List<Character>> AddCharacter (Character newCharacter);
    }
}