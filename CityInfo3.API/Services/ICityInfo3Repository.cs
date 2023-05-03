using CityInfo3.API.Entities;

namespace CityInfo3.API.Services
{
    public interface ICityInfo3Repository
    {
        IEnumerable<City> GetCities();
    }
}
