using AutoMapper;
using DoctorWho.API.Models;
using DoctorWho.Db.Models;

namespace DoctorWho.API.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorWithoutEpisodesDto>();
            CreateMap<Doctor, DoctorWithEpisodesDto>();
            CreateMap<DoctorForCreationDto, Doctor>();
        }

    }
}
