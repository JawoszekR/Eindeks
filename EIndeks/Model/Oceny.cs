using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIndeks.Model
{
    public class Ocena
    {
        public int Id { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        public Kurs Kurs { get; set; }
        [Required]
        [Range(1, 6)]
        public int Value { get; set; }
    }
}
