using AutoMapper;
using DoctorWho.API.Models;
using DoctorWho.Db.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.API.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepository doctorRepository;
        private readonly IMapper mapper;

        public DoctorsController(IDoctorRepository doctorRepository, IMapper mapper)
        {
            this.doctorRepository = doctorRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctors(bool withEpisodes = false)
        {
            if (withEpisodes)
            {
                var doctors = await doctorRepository.GetAllDoctorsWithEpisodesAsync();
                return Ok(mapper.Map<IEnumerable<DoctorWithEpisodesDto>>(doctors));
            }

            else
            {
                var doctors = await doctorRepository.GetAllDoctorsWithoutEpisodesAsync();
                return Ok(mapper.Map<IEnumerable<DoctorWithoutEpisodesDto>>(doctors));
            }

        }
    }
}
