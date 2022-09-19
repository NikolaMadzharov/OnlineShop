namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProtectorModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Model { get; set; }

    public IEnumerable<Protector> Protectors { get; set; } = new List<Protector>();
}