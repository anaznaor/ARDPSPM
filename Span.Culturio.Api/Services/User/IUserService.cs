using Span.Culturio.Api.Models;

namespace Span.Culturio.Api.Services.User
{
    public interface IUserService
    {
        Task<PaginatedListDto<UserDto>> GetUsers(int pageIndex, int pageSize);

        Task<UserDto> GetUser(int id);
    }
}