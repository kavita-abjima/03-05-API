using AutoMapper;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers

{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;

        public CitiesController(ICityInfo3Repository cityInfo3Repository,IMapper
            mapper)
        {
            _cityInfo3Repository = cityInfo3Repository ??
                throw new ArgumentNullException(nameof(cityInfo3Repository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

        }


        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            //return Ok(_citiesDataStore.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            //find city
            var cityToReturn = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
    }
}