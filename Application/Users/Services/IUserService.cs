using System;
using System.Threading.Tasks;
using Application.Users.DTOs;

namespace Application.Users.Services;

public interface IUserService
{
    Task<UserDto> GetById(Guid id);
    Task<Guid> RegisterUser(RegisterUserDto command);
}