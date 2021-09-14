using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.AbpGestionClient.GClients
{
    public interface IGClientAppService :
        ICrudAppService< //Defines CRUD methods
            GClientDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateGClientDto> //Used to create/update a book
    {
    }
}
