using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    //[Route("WeatherForecast2")]
    [Route("[controller]")]
    public class WeatherForecast2Controller: ControllerBase
    {
        private readonly ILogger<WeatherForecast2Controller> _logger;

        public WeatherForecast2Controller(ILogger<WeatherForecast2Controller> logger)
        {
            _logger = logger;
        }
        
        //[HttpGet("GetWeatherForecast/{id}")]
        //[HttpGet("Get/{id}")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            //TODO: получение прогноза погоды по идентификатору
            return await Task.FromResult(Ok());
        }
        
        [HttpPost]
        public async Task<IActionResult> AddAsync(WeatherForecast weatherForecast)
        {
            int id = 1;
            return await Task.FromResult(Ok(id));
        }

        //[HttpPut("Edit")]
        [HttpPut("{id}")]
        public async Task<IActionResult> EditAsync(WeatherForecast weatherForecast)
        {
            //throw new Exception("text");
            //TODO: редактирование прогноза погоды
            return await Task.FromResult(Ok());
        }

        //[HttpPost("Delete")]
        [HttpDelete("{id:min(1)}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            //TODO: удаление прогноза погоды
            return await Task.FromResult(Ok());
        }
        
        [HttpGet("list/{page}/{itemsPerPage}")]
        public async Task<IActionResult> GetListAsync(int page, int itemsPerPage)
        {
            //TODO: получение списка прогнозов погоды
            return await Task.FromResult(Ok());
        }
    }
}