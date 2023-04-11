using BeHealthBackend.DTOs.ReferralDtoFolder;

namespace BeHealthBackend.Services.ReferralServices;

public interface IReferralService
{
    Task<IEnumerable<ReferralDto>> GetIdAsync(int id);
}