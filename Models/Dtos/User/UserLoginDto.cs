using System;
using System.ComponentModel.DataAnnotations;

namespace ApiEcommerce.Models.Dtos.User;

public class UserLoginDto
{
    [Required(ErrorMessage = "El campo userName es requerido")]
    public string? UserName { get; set; }
    [Required(ErrorMessage = "El campo name es requerido")]
    public string? Password { get; set; }
}
