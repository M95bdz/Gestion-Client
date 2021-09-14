using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.AbpGestionClient.GClients
{
  public  class GClientAppService :
        CrudAppService<
            GClient, //The Book entity
            GClientDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateGClientDto>, //Used to create/update a book
        IGClientAppService //implement the IBookAppService
    {
        public GClientAppService(IRepository<GClient, Guid> repository)
            : base(repository)
        {

        }
    }
}
