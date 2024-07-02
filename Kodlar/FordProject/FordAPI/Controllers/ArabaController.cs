using FordAPI.Dto;
using FordAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FordAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArabaControllers : ControllerBase
    {

        [HttpGet]
        public IActionResult GetCars()
        {

            FordContext context = new FordContext();

            var result = context.Arabas.Select(x => new ArabaDto() { ArabaId = x.ArabaId, ArabaModel = x.ArabaModel }).ToList();
            return Ok(result);



        }


    }
}
