using System;
using System.Collections.Generic;

namespace FordAPI.Models
{
    public partial class Araba
    {
        public Araba()
        {
            Desteks = new HashSet<Destek>();
            Servis = new HashSet<Servi>();
        }

        public int ArabaId { get; set; }
        public string? ArabaModel { get; set; }

        public virtual ICollection<Destek> Desteks { get; set; }
        public virtual ICollection<Servi> Servis { get; set; }
    }
}
