using FordAPI.Dto;
using FordAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FordAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DestekController : ControllerBase
    {

        [HttpPost]
        public IActionResult AddBilgi([FromBody] DestekDto destekDto)
        {
            FordContext context = new FordContext();

            Destek destek = new Destek();
            destek.Ad = destekDto.Ad;
            destek.Email = destekDto.Email;
            destek.Telefon = destekDto.Telefon;
            destek.Soyad = destekDto.Soyad;
            destek.ArabaId = int.Parse(destekDto.ArabaId);

            var result = context.Desteks.Add(destek);
            context.SaveChanges();

            return Ok();
        }
    }
}
