namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Case:Product
{
    public Case()
    {
        Cases = new HashSet<CaseModel>();
    }

    [Key]
    public int Id { get; set; }

    public ICollection<CaseModel> Cases { get; set; }



}