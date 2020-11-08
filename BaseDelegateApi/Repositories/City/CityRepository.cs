using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseDelegateApi.Repositories.City
{
    public class CityRepository : ICityRepository
    {
        public Task CreateCities(List<Entities.City> cities)
        {
            // Write Database

            return Task.CompletedTask;
        }
    }
}
