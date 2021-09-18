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
       private readonly IBlobContainer<GClientContainer> _blobContainer;
        private readonly IRepository<GClient, Guid> _repository;
        private readonly IHostingEnvironment _hostingEnv;

        public GClientAppService(IRepository<GClient, Guid> repository,IBlobContainer<GClientContainer> blobContainer, IHostingEnvironment hostingEnv) : base(repository)
        {
            _repository = repository;
            _blobContainer = blobContainer;
            _hostingEnv = hostingEnv;
        }
           

        public async Task<string> Upload([FromForm] GClientDto UserInfo  ){
            
            
                string imageName = new string(System.IO.Path.GetFileNameWithoutExtension(UserInfo.File.FileName).Take(10).ToArray()).Replace(' ', '-');
                imageName = imageName + DateTime.Now.ToString("yymmssfff") + System.IO.Path.GetExtension(UserInfo.File.FileName);

                var imagePath = System.IO.Path.Combine(_hostingEnv.ContentRootPath, "wwwroot/Resources/Images", imageName);
                using (var fileStream = new FileStream(imagePath, FileMode.Create))
                {
                    await UserInfo.File.CopyToAsync(fileStream);
                    await _blobContainer.SaveAsync(imagePath, fileStream).ConfigureAwait(false);
                }

          
                return imageName;
            

        }
    }
}
