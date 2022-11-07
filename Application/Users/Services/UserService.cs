using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Users.DTOs;
using Domain.UserAgg;
using Domain.UserAgg.Repository;
using Domain.UserAgg.Services;

namespace Application.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IUserDomainService _userDomainService;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserDto> GetById(Guid id)
        {
            var user = await _repository.GetAsync(id);
            return new UserDto()
            {
                AvatarName = user.AvatarName,
                Email = user.Email,
                Family = user.Family,
                Gender = user.Gender,
                IsActive = user.IsActive,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                Roles = user.Roles.Select(s => new UserRoleDto()
                {
                    RoleId = s.RoleId,
                    RoleTitle = ""
                }).ToList()
            };
        }

        public async Task<Guid> RegisterUser(RegisterUserDto command)
        {
            var user = User.RegisterUser(command.PhoneNumber , command.Password , _userDomainService);
            _repository.Add(user);
            await _repository.Save();
            return user.Id;
        }
    }
}