using Acme.AbpGestionClient.GClients;
using AutoMapper;

namespace Acme.AbpGestionClient
{
    public class AbpGestionClientApplicationAutoMapperProfile : Profile
    {
        public AbpGestionClientApplicationAutoMapperProfile()
        {
            CreateMap<GClient, GClientDto>();
            CreateMap<CreateUpdateGClientDto, GClient>();
        }
    }
}
