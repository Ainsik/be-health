using BeHealthBackend.DTOs.RecipeDtoFolder;

namespace BeHealthBackend.Services.RecipeServices;

public interface IRecipeService
{
    Task<IEnumerable<RecipeDto>> GetIdAsync(int id);
}