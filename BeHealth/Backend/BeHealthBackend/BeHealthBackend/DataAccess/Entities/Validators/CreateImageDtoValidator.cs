using System.Text.RegularExpressions;
using BeHealthBackend.DTOs.ImageDto;
using FluentValidation;

namespace BeHealthBackend.DataAccess.Entities.Validators;

public class CreateImageDtoValidator : AbstractValidator<CreateImageDto>
{
    public CreateImageDtoValidator()
    {
        RuleFor(imageDto => imageDto.Image)
            .NotNull();
        RuleFor(imageDto => imageDto.Image.ContentType)
            .Matches(new Regex("image/*"))
            .When(imageDto => imageDto.Image != null);
    }
}