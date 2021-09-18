using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.AbpGestionClient.GClients
{
    
    public class GClientDto : AuditedEntityDto<Guid>
    {
        public string NomComplet { get; set; }
        public string Cin { get; set; }
        public string Email { get; set; }
        public DateTime DateNais { get; set; }
        public int Num { get; set; }
        public string Adresse { get; set; }
        public string PathImg { get; set; }
        public IFormFile File { get; set; }
        public string ImageName { get; set; }
    }
}
