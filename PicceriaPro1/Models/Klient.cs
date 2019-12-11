using System;
using System.Collections.Generic;

namespace PicceriaPro1.Models
{
    public partial class Klient
    {
        public int IdKlienta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string HasloKlienta { get; set; }
        public string AdresEmail { get; set; }
    }
}
