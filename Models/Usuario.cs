using System.ComponentModel.DataAnnotations;

namespace MakrotecnoBackend.Models;

public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Correo { get; set; } = string.Empty;
}