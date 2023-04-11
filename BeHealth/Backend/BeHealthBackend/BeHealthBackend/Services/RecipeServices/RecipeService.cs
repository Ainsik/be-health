using AutoMapper;
using BeHealthBackend.DataAccess.Repositories.Interfaces;
using BeHealthBackend.DTOs.RecipeDtoFolder;

namespace BeHealthBackend.Services.RecipeServices;

public class RecipeService : IRecipeService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public RecipeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<RecipeDto>> GetIdAsync(int id)
    {
        var recipes = await _unitOfWork.RecipeRepository
            .GetAllAsync(r => r.PatientId == id, includeProperties: "Patient");

        var recipesDto = recipes.Select(r => new RecipeDto
        {
            Id = r.Id,
            PatientId = r.PatientId,
            Patient = $"{r.Patient.FirstName} {r.Patient.LastName}",
            Date = new DateTimeOffset(r.Created).ToUnixTimeSeconds(),
            Medicament = r.Medicament,
            Quantity = r.Quantity,
            Code = r.Code
        });

        return recipesDto;
    }
}