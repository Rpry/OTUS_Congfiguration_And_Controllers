using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("WeatherForecast2")]
    //[Route("[controller]")]
    public class WeatherForecast2Controller: ControllerBase
    {
        private readonly ILogger<WeatherForecast2Controller> _logger;

        public WeatherForecast2Controller(ILogger<WeatherForecast2Controller> logger)
        {
            _logger = logger;
        }
        
        [HttpGet("/{id}")]
        //[HttpGet()]
        public async Task<IActionResult> Get(string id)
        {
            //TODO: получение прогноза погоды по идентификатору
            return await Task.FromResult(Ok());
        }
        
        //[HttpPost("Add")]
        [HttpPost]
        public async Task<IActionResult> Add(WeatherForecast weatherForecast)
        {
            //TODO: добавление прогноза погоды
            return await Task.FromResult(Ok());
        }

        //[HttpPut("Edit")]
        [HttpPut]
        public async Task<IActionResult> Edit(WeatherForecast weatherForecast)
        {
            //TODO: редактирование прогноза погоды
            return await Task.FromResult(Ok());
        }

        //[HttpDelete("Delete")]
        [HttpDelete("{id:min(1)}")]
        public async Task<IActionResult> Delete(int id)
        {
            //TODO: удаление прогноза погоды
            return await Task.FromResult(Ok());
        }
        
        [HttpGet("list/{page}/{itemsPerPage}")]
        public async Task<IActionResult> GetList(int page, int itemsPerPage)
        {
            //TODO: получение списка прогнозов погоды
            return await Task.FromResult(Ok());
        }
    }
}