using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        [Range(100000,999999)]
        public int NrIndeksu { get; set; }
        [Required]
        public DateTime DataUrodzenia { get; set; }
    }
}
