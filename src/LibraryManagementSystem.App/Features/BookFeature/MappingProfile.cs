using AutoMapper;
using BookStoreManagementSystem.App.Domain;
using BookStoreManagementSystem.App.Features.BookFeature.Dtos;

namespace BookStoreManagementSystem.App.Features.BookFeature
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>();
        }
    }
}