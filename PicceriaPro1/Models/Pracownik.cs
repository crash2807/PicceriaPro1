using System;
using System.Collections.Generic;

namespace PicceriaPro1.Models
{
    public partial class Pracownik
    {
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string HasloPracownika { get; set; }
        public int IdAdmina { get; set; }

        public virtual Administrator IdAdminaNavigation { get; set; }
    }
}
