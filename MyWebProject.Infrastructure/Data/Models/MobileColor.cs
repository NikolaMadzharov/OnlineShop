namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;


public class MobileColor
{
    [Key]
    public int MobilephoneId { get; set; }
    public virtual Mobilephone Mobilephone { get; set; }
    [Key]
    public int ColorId { get; set; }
    public virtual Color Color { get; set; }
} 