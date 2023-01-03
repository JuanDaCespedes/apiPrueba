using System.ComponentModel.DataAnnotations;

namespace PruebaAPI.Dtos;

public class RegisterDto
{
    [Required]
    public string Usuario { get; set; }
    [Required]
    public string Pass { get; set; }
    
    public DateTime FechaCreacion = DateTime.Now;
    
}
