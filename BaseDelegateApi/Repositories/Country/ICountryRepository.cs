using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseDelegateApi.Repositories.Country
{
    public interface ICountryRepository
    {
        Task CreateCountries(List<Entities.Country> countries);
    }
}