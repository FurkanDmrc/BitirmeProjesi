using FordAPI.Models;

namespace FordAPI.Dto
{
    public class ArabaDto
    {
        public int ArabaId { get; set; }
        public string? ArabaModel { get; set; }

        public virtual ICollection<Destek> Desteks { get; set; }
        public virtual ICollection<Servi> Servis { get; set; }
    }
}
