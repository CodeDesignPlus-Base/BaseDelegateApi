using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseDelegateApi.Repositories.City
{
    public interface ICityRepository
    {
        Task CreateCities(List<Entities.City> cities);
    }
}
