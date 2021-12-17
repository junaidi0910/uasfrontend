using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UASFrontEnd.Models
{
    public class Student
    {
        public int Nim { get; set; }

        [Required]
        public string NamaDepan { get; set; }

        [Required]
        public string NamaBelakang { get; set; }

        public TimestampAttribute TanggalMasuk { get; set; }
       
    }

}