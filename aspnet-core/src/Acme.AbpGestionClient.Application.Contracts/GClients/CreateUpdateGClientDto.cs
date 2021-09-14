using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.AbpGestionClient.GClients
{
    public class CreateUpdateGClientDto
    {
        [Required]
        [StringLength(128)]
        public string NomComplet { get; set; }

        [Required]
        public string Cin { get; set; }

       // [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateNais { get; set; }

        [Required]
        public int Num { get; set; }

        [Required]
        public string Adresse { get; set; }

        [Required]
        public string PathImg { get; set; }
    }
}
