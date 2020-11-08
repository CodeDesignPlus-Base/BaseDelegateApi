using BaseDelegateApi.Dto;
using BaseDelegateApi.Repositories.Country;
using BaseDelegateApi.Services.Request;
using System.Linq;
using System.Threading.Tasks;

namespace BaseDelegateApi.Services.Country
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository repository;
        private readonly IRequestService request;

        public CountryService(IRequestService request, ICountryRepository repository)
        {
            this.request = request;
            this.repository = repository;
        }

        public async Task<Result<CountryDto>> GetCountriesAsync()
        {
            var url = "https://parseapi.back4app.com/classes/Country?limit=10";

            var data = await this.request.RequestAsync<CountryDto>(url, this.CreateCountries);

            return data;
        }

        public async Task<Result<CountryDto>> CreateCountries(Result<CountryDto> data)
        {
            var entities = data.Results.Select(x => new Entities.Country()
            {
                Capital = x.Capital,
                ClassName = x.ClassName,
                Code = x.Code,
                Currency = x.Currency,
                Name = x.Name,
                Native = x.Native,
                ObjectId = x.ObjectId,
                Phone = x.Phone
            }).ToList();

            await this.repository.CreateCountries(entities);

            return data;
        }
    }
}
