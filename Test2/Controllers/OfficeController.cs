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


        //Get: api/Office/GetOffice
        [HttpGet("GetOffice")]
        public async Task<IActionResult> GetOffice(string ID)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(new {ACPD_SID=ID });
            var result = await _officeService.GetOffice(json);
            return Content(result, "application/json");
        }

        //Get: api/Office/GetAllOffice
        [HttpGet("GetAllOffice")]
        public async Task<IActionResult> GetAllOffice()
        {
    
            var result = await _officeService.GetAllOffice();
            return Content(result, "application/json");
        }


        //Post: api/Office/CreateOffice
        [HttpPost("CreateOffice")]
        public async Task<IActionResult> CreateOffice([FromBody] OfficeDTO dto)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(dto);
            var result= await _officeService.CreateOffice(json);
            return Ok(result);
        }

        //Put: api/Office/UpdateOffice
        [HttpPut("UpdateOffice")]
        public async Task<IActionResult> UpdateOffice([FromBody] OfficeUpdateDTO dto)
        {
            if (string.IsNullOrEmpty(dto.ACPD_SID))
            {
                return BadRequest("必須提供 ACPD_SID 才能進行更新");
            }

            string json = System.Text.Json.JsonSerializer.Serialize(dto);
            var result = await _officeService.UpdateOffice(json);
            return Ok(result);
        }

        //Delete: api/Office/DeleteOffice
        [HttpDelete("DeleteOffice")]
        public async Task<IActionResult> DeleteOffice([FromBody] OfficeDeleteDTO dto)
        {
            if (string.IsNullOrEmpty(dto.ACPD_SID))
            {
                return BadRequest("必須提供 ACPD_SID 才能進行更新");
            }

            string json = System.Text.Json.JsonSerializer.Serialize(dto);
            var result = await _officeService.DeleteOffice(json);
            return Ok(result);
        }
    }
}
