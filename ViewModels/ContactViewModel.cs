using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanWebApp.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(3)]
        public string Nume { get; set; }
        [Required]
        [MinLength(3)]
        public string Prenume { get; set; }
        public string Judet { get; set; }
        [Required]
        [MinLength(3)]
        public string Oras { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Mesaj prea lung, maxim 250 de caractere")]
        public string Mesaj { get; set; }
    }
}
