using Common.Domain.ValueObjects;
using Domain.UserAgg.Enums;
using System;
using System.Collections.Generic;

namespace Application.Users.DTOs;

public class RegisterUserDto
{
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
}

public class UserDto
{
    public string Name { get; set; }
    public string Family { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string AvatarName { get; set; }
    public bool IsActive { get; set; }
    public Gender Gender { get; set; }
    public List<UserRoleDto> Roles { get; set; }
}

public class UserRoleDto
{
    public Guid RoleId { get; set; }
    public string RoleTitle { get; set; }
}