using System;
using ApiEcommerce.Controllers;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos.User;
using ApiEcommerce.Models.Dtos.UserData;
using AutoMapper;

namespace ApiEcommerce.Mapping;

public class UserProfile: Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, CreateUserDto>().ReverseMap();
        CreateMap<User, UserLoginDto>().ReverseMap();
        CreateMap<User, UserLoginResponseDto>().ReverseMap();
        CreateMap<ApplicationUser, UserDataDto>().ReverseMap();
        CreateMap<ApplicationUser, UserDto>().ReverseMap();
    }
}
