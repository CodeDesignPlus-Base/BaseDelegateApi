using BaseDelegateApi.Dto;
using System;
using System.Threading.Tasks;

namespace BaseDelegateApi.Services.Request
{
    public interface IRequestService
    {
        Task<Result<TDto>> RequestAsync<TDto>(string url, Func<Result<TDto>, Task<Result<TDto>>> func);
    }
}