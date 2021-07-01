using SnipeIt.Models;
using SnipeIt.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace SnipeIt.Services
{
    public interface IHardwareService 
    {
        public Task<HardwareAsset> GetHardware(int id);
    }
    public class HardwareService: IHardwareService
    {
        private HttpClient _client;
        private readonly SnipeItConfiguration _config;
        private readonly string _accessToken;
        private readonly string _baseUri;

        public HardwareService(
            HttpClient client,
            IOptions<SnipeItConfiguration> config
            )
        {
            _client = client;
            _config = config.Value;
            _baseUri = _config.ApiBaseUrl;
            _accessToken = _config.AccessToken;
        }

        public async Task<HardwareAsset> GetHardware(int id) 
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
            var response = await _client.GetAsync($"{_baseUri}hardware/{id}");

            return JsonSerializer.Deserialize<HardwareAsset>(await response.Content.ReadAsStringAsync());

        }
    }
}
