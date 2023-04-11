using System.Security.Claims;
using BeHealthBackend.DTOs.AccountDtoFolder;
using BeHealthBackend.DTOs.PatientDtoFolder;

namespace BeHealthBackend.Services.PatientServices;

public interface IPatientService
{
    Task<IEnumerable<PatientDto>> GetPatientsAsync();
    Task<PatientDto> GetIdAsync(int id);
    Task<(int, CreatePatientDto)> CreateAsync(CreatePatientDto dto);
    Task UpdateAsync(int id, UpdatePatientDto dto, ClaimsPrincipal user);
    Task DeleteAsync(int id, ClaimsPrincipal user);
    string GenerateJwt(LoginDto dto);
}