using AutoMapper;
using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Features.CustomerFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.CustomerFeature
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(d => d.Debts, o => o.MapFrom(s => s.Debt));
            CreateMap<CustomerDebt, CustomerDebtDto>();
        }
    }
}