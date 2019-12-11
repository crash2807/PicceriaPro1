using System;
using System.Collections.Generic;

namespace PicceriaPro1.Models
{
    public partial class Zamowienie
    {
        public int IdZamowienia { get; set; }
        public DateTime DataZamowienia { get; set; }
        public DateTime DataRealizacji { get; set; }
        public string Adres { get; set; }
        public int IdStanu { get; set; }
        public int IdPiccy { get; set; }
    }
}
