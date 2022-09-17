namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CaseModel
{
    [Key]
    public int Id { get; set; }

    [Required]

    public string Model { get; set; }

    [ForeignKey(nameof(Case))]
    public int CaseId { get; set; }
    public Case Case { get; set; }
}