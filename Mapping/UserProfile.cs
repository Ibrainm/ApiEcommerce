using System;
using ApiEcommerce.Controllers;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos.User;
using ApiEcommerce.Models.Dtos.UserData;
using Mapster;

namespace ApiEcommerce.Mapping;

public class UserProfile: IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<User, UserDto>();
        config.NewConfig<UserDto, User>();
        config.NewConfig<CreateUserDto, User>();
        config.NewConfig<User, CreateUserDto>();
        config.NewConfig<UserLoginDto, User>();
        config.NewConfig<User, UserLoginDto>();
        config.NewConfig<UserLoginResponseDto, User>();
        config.NewConfig<User, UserLoginResponseDto>();
        config.NewConfig<ApplicationUser, UserDataDto>();
        config.NewConfig<UserDataDto, ApplicationUser>();
        config.NewConfig<ApplicationUser, UserDto>();
        config.NewConfig<UserDto, ApplicationUser>();
    }
}
