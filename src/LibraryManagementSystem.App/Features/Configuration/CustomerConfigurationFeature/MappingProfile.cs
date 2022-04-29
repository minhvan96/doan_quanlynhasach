using AutoMapper;
using BookStoreManagementSystem.App.Domain.Configuration;
using BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.Configuration.CustomerConfigurationFeature
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerConfiguration, CustomerConfigurationDto>();
        }
    }
}