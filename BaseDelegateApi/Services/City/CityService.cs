using BaseDelegateApi.Dto;
using BaseDelegateApi.Repositories.City;
using BaseDelegateApi.Services.Request;
using System.Linq;
using System.Threading.Tasks;

namespace BaseDelegateApi.Services.City
{
    public class CityService : ICityService
    {
        private readonly ICityRepository repository;
        private readonly IRequestService request;

        public CityService(ICityRepository repository, IRequestService request)
        {
            this.request = request;
            this.repository = repository;
        }

        public async Task<Result<CityDto>> GetCitiesAsync()
        {
            var url = "https://parseapi.back4app.com/classes/City?limit=10";

            var result = await this.request.RequestAsync<CityDto>(url, async data =>
            {
                var entities = data.Results.Select(x => new Entities.City()
                {
                    AdminCode = x.AdminCode,
                    AltName = x.AltName,
                    CityId = x.CityId,
                    Country = new Entities.Country()
                    {
                        ClassName = x.Country.ClassName,
                        ObjectId = x.Country.ObjectId,
                    },
                    Name = x.Name,
                    ObjectId = x.ObjectId,
                    Population = x.Population
                }).ToList();

                await this.repository.CreateCities(entities);

                return data;

            });

            return result;
        }
    }
}
