using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FortyFlavors.Core.Application.DTOs;

using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Common;

namespace FortyFlavors.Core.Application.Handlers.Queries.Users
{
    public class GetUserDetailQuery : IRequest<UserDto>
    {
        public int UserId { get; set; }

        public GetUserDetailQuery(int userId)
        {
            UserId = userId;
        }
    }

    public class GetUserDetailQueryHandler : IRequestHandler<GetUserDetailQuery, UserDto>
    {
        private readonly IAppDbContext _context;

        public GetUserDetailQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<UserDto> Handle(GetUserDetailQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Where(u => u.Id == request.UserId)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    Role = u.Role
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (user == null)
                throw new KeyNotFoundException("User not found");

            return user;
        }
    }
}