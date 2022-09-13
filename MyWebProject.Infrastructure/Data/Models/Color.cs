namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Color
{
    public Color()
    {
        MobileColors = new HashSet<MobileColor>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public virtual ICollection<MobileColor> MobileColors { get; set; }
}