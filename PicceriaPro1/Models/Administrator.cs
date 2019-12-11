using System;
using System.Collections.Generic;

namespace PicceriaPro1.Models
{
    public partial class Administrator
    {
        public Administrator()
        {
            Pracownik = new HashSet<Pracownik>();
        }

        public int IdAdmina { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string HasloAdmina { get; set; }

        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}
