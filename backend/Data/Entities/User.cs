using System.ComponentModel.DataAnnotations;

namespace backend.Data.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;
}