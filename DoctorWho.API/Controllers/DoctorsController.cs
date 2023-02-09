using AutoMapper;
using DoctorWho.API.Models;
using DoctorWho.Db.Models;
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

        [HttpPost]
        public async Task<IActionResult> AddDoctor(DoctorForCreationDto doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var doctorToAdd = mapper.Map<Doctor>(doctor);
            await doctorRepository.AddAsync(doctorToAdd);
            if ((await doctorRepository.SaveChangesAsync()) > 0)
            {
                var doctorToReturn = mapper.Map<DoctorWithoutEpisodesDto>(doctorToAdd);
                return Ok(doctorToReturn);
            }
            return BadRequest();

        }
    }
}
