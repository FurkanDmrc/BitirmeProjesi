using FordAPI.Dto;
using FordAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FordAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServisController : ControllerBase
    {

        [HttpPost]
        public IActionResult AddBilgi([FromBody] ServisDto servisDto)
        {
            FordContext context = new FordContext();

            Servi servi = new Servi();
            servi.Ad = servisDto.Ad;
            servi.Email = servisDto.Email;
            servi.Telefon = servisDto.Telefon;
            servi.Soyad = servisDto.Soyad;
            servi.ArabaId = int.Parse(servisDto.ArabaId);

            var result = context.Servis.Add(servi);
            context.SaveChanges();

            return Ok();
        }
    }
}
