using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseDelegateApi.Repositories.Country
{
    public class CountryRepository : ICountryRepository
    {

        public Task CreateCountries(List<Entities.Country> countries)
        {
            // Write Database

            return Task.CompletedTask;
        }
    }
}
