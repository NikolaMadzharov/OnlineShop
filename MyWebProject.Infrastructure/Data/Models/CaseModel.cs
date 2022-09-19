namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CaseModel
{
    [Key]
    public int Id { get; set; }

    [Required]

    public string Model { get; set; }

    public IEnumerable<Case> Cases { get; set; } = new List<Case>();
}