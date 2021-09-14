using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.AbpGestionClient.GClients
{
    public class GClient : AuditedAggregateRoot<Guid>
    {

        public string NomComplet { get; set; }
        public string Cin { get; set; }
        public string Email { get; set; }
        public DateTime DateNais { get; set; }
        public int Num { get; set; }
        public string Adresse { get; set; }
        //public byte[] Image { get; set; }
        public string PathImg { get; set;}
       
    }
}
