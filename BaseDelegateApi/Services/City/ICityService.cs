using BaseDelegateApi.Dto;
using System.Threading.Tasks;

namespace BaseDelegateApi.Services.City
{
    public interface ICityService
    {
        Task<Result<CityDto>> GetCitiesAsync();
    }
}