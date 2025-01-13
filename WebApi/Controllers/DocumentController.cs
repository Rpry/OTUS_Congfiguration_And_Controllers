using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("document")]
    //[Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly ILogger<DocumentController> _logger;

        public DocumentController(ILogger<DocumentController> logger)
        {
            _logger = logger;
        }

        [ProducesResponseType(typeof(Document), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(EmptyResult), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(EmptyResult),StatusCodes.Status400BadRequest)]
        
        [HttpGet("GetDocument/{id}")]
        //[HttpGet("Get/{id}")]
        //[HttpGet()]
        public async Task<IActionResult> GetAsync(string id)
        {
            //TODO: получение документа по идентификатору
            return await Task.FromResult(Ok());
        }
        
        /// <summary>
        /// Add document
        /// </summary>
        /// <param name="document"> object of document type </param>
        /// <returns> Document identifier (int) </returns>
        /// <remarks>
        ///    <i>Example POST:</i><br /> /document
        /// </remarks>
        /// <response code="200"> Document forecast identifier (int) </response>
        /// <response code="404"></response>
        /// <response code="400"></response>
        [HttpPost]
        public async Task<IActionResult> AddAsync(Document document)
        {
            int id = 1;
            return Ok(id);
        }

        //[HttpPut("Edit")]
        [HttpPut("{id}")]
        public async Task<IActionResult> EditAsync(Document document)
        {
            //throw new Exception("text");
            //TODO: редактирование документров
            //return BadRequest(new object()); Task.FromResult(Ok());; 
            return Ok();
        }

        //[HttpPost("Delete")]
        [HttpDelete("{id:min(1)}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            //TODO: удаление документров
            return Ok();
        }
        
        [HttpGet("list/{page}/{itemsPerPage}")]
        public async Task<IActionResult> GetListAsync(int page, int itemsPerPage)
        {
            //TODO: получение списка документров
            return Ok();
        }
    }
}