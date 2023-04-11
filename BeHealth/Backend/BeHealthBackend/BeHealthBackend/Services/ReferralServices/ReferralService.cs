using AutoMapper;
using BeHealthBackend.DataAccess.Repositories.Interfaces;
using BeHealthBackend.DTOs.ReferralDtoFolder;

namespace BeHealthBackend.Services.ReferralServices;

public class ReferralService : IReferralService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ReferralService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ReferralDto>> GetIdAsync(int id)
    {
        var referrals = await _unitOfWork.ReferralRepository
            .GetAllAsync(r => r.PatientId == id, includeProperties: "Patient");

        var referralsDto = referrals.Select(r => new ReferralDto
        {
            Id = r.Id,
            PatientId = r.PatientId,
            Patient = $"{r.Patient.FirstName} {r.Patient.LastName}",
            Date = new DateTimeOffset(r.Created).ToUnixTimeSeconds(),
            Specialist = r.Specialist,
            Description = r.Description,
            Code = r.Code
        });

        return referralsDto;
    }
}