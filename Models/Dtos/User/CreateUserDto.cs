using System;
using System.ComponentModel.DataAnnotations;

namespace ApiEcommerce.Models.Dtos.User;

public class CreateUserDto
{
    [Required(ErrorMessage = "El campo userName es requerido")]
    public string? UserName { get; set; }
    [Required(ErrorMessage = "El campo name es requerido")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "El campo password es requerido")]
    public string? Password { get; set; }
    [Required(ErrorMessage = "El campo role es requrido")]
    public string? Role { get; set; }
}
