using AutoMapper;
using BookStoreManagementSystem.App.Configuration.Mediator;
using BookStoreManagementSystem.App.Domain.Seedwork;
using BookStoreManagementSystem.App.Features.StaffFeature.Dtos;
using BookStoreManagementSystem.App.Infrastructure;
using BookStoreManagementSystem.App.Infrastructure.Data;

namespace BookStoreManagementSystem.App.Features.StaffFeature.Queries
{
    public class ListStaffsQueryHandler : IListQueryHandler<ListStaffsQuery, StaffDto>
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public ListStaffsQueryHandler(BookStoreContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IPagedList<StaffDto>> Handle(ListStaffsQuery request, CancellationToken cancellationToken)
        {
            var staff = _context.Staffs
               .AsNoTracking()
               .Where(x => !x.IsDeleted)
               .Join(_context.Users,
                    s => s.UserId,
                    u => u.Id,
                    (s, u) => new StaffDto
                    {
                        Id = u.Id.ToString(),
                        Name = u.Name,
                        Position = s.Position,
                        Email = u.Email,
                        PhoneNumber = u.PhoneNumber,
                        Age = DateTime.Today.Year - u.BirthDate.Year
                    });

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                staff = staff.Where(x => x.Name.Contains(request.Name));
            }
            if (request.Age > 0)
            {
                staff = staff.Where(x => x.Age == request.Age);
            }
            var response = await staff.ToPagedListAsync(request.PageIndex, request.PageSize, cancellationToken: cancellationToken);
            return response;
        }
    }
}