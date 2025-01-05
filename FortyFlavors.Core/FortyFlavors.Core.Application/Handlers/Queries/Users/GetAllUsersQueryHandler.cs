using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FortyFlavors.Core.Application.DTOs;

using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Common;

namespace FortyFlavors.Core.Application.Handlers.Queries
{
    public class GetAllUsersQuery : IRequest<List<UserDto>>
    {
    }

    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
    {
        private readonly IAppDbContext _context;

        public GetAllUsersQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Name = u.Name,
                    Email = u.Email,
                    Role = u.Role
                })
                .ToListAsync(cancellationToken);

            return users;
        }
    }
}