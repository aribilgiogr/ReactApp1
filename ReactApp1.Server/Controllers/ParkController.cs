using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Models;
using System.Text.Json;

namespace ReactApp1.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ParkController : ControllerBase
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        public ParkController(IHttpClientFactory factory)
        {
            client = factory.CreateClient("parks");
            options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await client.GetAsync("Park");
            response.EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();
            var data = await JsonSerializer.DeserializeAsync<IEnumerable<ParkListModel>>(stream, options);
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await client.GetAsync("ParkDetay?id=" + id);
            response.EnsureSuccessStatusCode();
            var stream = await response.Content.ReadAsStreamAsync();
            var data = await JsonSerializer.DeserializeAsync<IEnumerable<ParkDetailModel>>(stream, options);
            return Ok(data?.ElementAt(0));
        }
    }
}
