using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Test2.DTO;
using Test2.Interface;

namespace Test2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficeController : Controller
    {
        private readonly IOfficeService _officeService;

        public OfficeController(IOfficeService officeService)
        {
            _officeService = officeService;
        }


        //Post: api/Office/CreateOffice
        [HttpPost("CreateOffice")]
        public async Task<IActionResult> CreateOffice([FromBody] OfficeDTO dto)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(dto);
            var result= await _officeService.CreateOffice(json);
            return Ok(result);
        }
    }
}
