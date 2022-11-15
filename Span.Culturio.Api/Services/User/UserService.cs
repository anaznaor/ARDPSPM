using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Span.Culturio.Api.Data;
using Span.Culturio.Api.Models;
using Span.Culturio.Api.Services;
using Span.Culturio.Helpers;
using Span.FairBank.Api.Generics;

namespace Span.Culturio.Api.Services.User
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PaginatedListDto<UserDto>> GetUsers(int pageIndex, int pageSize)
        {
            var totalCount = await _context.Users.CountAsync();
            var users = await PaginatedList<Data.Entities.User>.CreateAsync(_context.Users, pageIndex, pageSize);
            var usersDto = _mapper.Map<List<UserDto>>(users);

            return new Models.PaginatedListDto<UserDto>
            {
                Data = usersDto,
                TotalCount = totalCount
            };
        }

        public async Task<UserDto> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

    }
}