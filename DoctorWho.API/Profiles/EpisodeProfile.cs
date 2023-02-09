using AutoMapper;
using DoctorWho.API.Models;
using DoctorWho.Db.Models;

namespace DoctorWho.API.Profiles
{
    public class EpisodeProfile : Profile
    {
        public EpisodeProfile()
        {
            CreateMap<Episode, EpisodeDto>();
        }
    }
}
