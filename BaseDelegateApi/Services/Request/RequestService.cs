using BaseDelegateApi.Dto;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BaseDelegateApi.Services.Request
{
    public class RequestService : IRequestService
    {
        private readonly IHttpClientFactory httpClientFactory;

        public RequestService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<Result<TDto>> RequestAsync<TDto>(string url, Func<Result<TDto>, Task<Result<TDto>>> func)
        {
            var client = this.httpClientFactory.CreateClient();

            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "X-Parse-Application-Id", "mxsebv4KoWIGkRntXwyzg6c6DhKWQuit8Ry9sHja" },
                    { "X-Parse-Master-Key", "TpO0j3lG2PmEVMXlKYQACoOXKQrL3lwM0HwR9dbH" },
                },
            };

            using var response = await client.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Result<TDto>>(json);

            return await func(data);
        }
    }
}
