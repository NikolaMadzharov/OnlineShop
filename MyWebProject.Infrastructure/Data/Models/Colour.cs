namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Colour
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string ColourName { get; set; }
}