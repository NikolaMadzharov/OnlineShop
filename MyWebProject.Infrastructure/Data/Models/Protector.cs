namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Protector
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Model { get; set; }

   
}