namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Protector:Product
{
    public Protector()
    {
        Protectors = new HashSet<ProtectorModel>();
    }

    [Key]
    public int Id { get; set; }

    public ICollection<ProtectorModel> Protectors { get; set; }


}