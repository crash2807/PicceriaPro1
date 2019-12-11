﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmpTest.Models
{
    public partial class Emp
    {
        public int Empno { get; set; }
        [Required(ErrorMessage ="Nazwisko jest wymagane")]
        [MaxLength(20,ErrorMessage ="Nazwisko jest zbyt dlugie")]
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? Mgr { get; set; }
        public DateTime? Hiredate { get; set; }
        public int? Sal { get; set; }
        public int? Comm { get; set; }
        public int? Deptno { get; set; }
    }
}
