using DoctorWho.API.Models;
using FluentValidation;

namespace DoctorWho.API.Validators
{
    public class AddDoctorValidator : AbstractValidator<DoctorForCreationDto>
    {
        public AddDoctorValidator()
        {
            RuleFor(d => d.Name).NotEmpty().WithMessage("The Name is Required");
            RuleFor(d => d.Number).NotEmpty().WithMessage("The Number is Required");
            RuleFor(d => d.LastEpisodeDate).Empty().When(d => !d.FirstEpisodeDate.HasValue).WithMessage("LastEpisodeDate should has no value when FirstEpisodeDate has no value");
            RuleFor(d => d.LastEpisodeDate).GreaterThanOrEqualTo(d => d.FirstEpisodeDate).WithMessage("LastEpisodeDate should be greater than or equal FirstEpisodeDate");
        }
    }
}
