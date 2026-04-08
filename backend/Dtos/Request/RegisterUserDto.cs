using System.ComponentModel.DataAnnotations;

namespace backend.Dtos.Request;

public class RegisterUserDto
{
    [Required, StringLength(50)]
    public string Name { get; set; }
}