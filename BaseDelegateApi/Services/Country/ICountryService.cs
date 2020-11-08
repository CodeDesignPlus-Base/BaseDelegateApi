using BaseDelegateApi.Dto;
using System.Threading.Tasks;

namespace BaseDelegateApi.Services.Country
{
    public interface ICountryService
    {
        Task<Result<CountryDto>> GetCountriesAsync();
    }
}