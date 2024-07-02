using System;
using System.Collections.Generic;

namespace FordAPI.Models
{
    public partial class Destek
    {
        public int MusteriId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Email { get; set; }
        public string Telefon { get; set; }
        public int? ArabaId { get; set; }

        public virtual Araba? Araba { get; set; }
    }
}
