namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Protector
{
    public Protector()
    {
        Protectors = new HashSet<ProtectorModel>();
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


    public ICollection<ProtectorModel> Protectors { get; set; }


}