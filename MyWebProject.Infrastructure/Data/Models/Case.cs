namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Case
{
    public Case()
    {
        Cases = new HashSet<CaseModel>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public string Description { get; set; }
    [Required]
    public string Url { get; set; }


    public ICollection<CaseModel> Cases { get; set; }



}