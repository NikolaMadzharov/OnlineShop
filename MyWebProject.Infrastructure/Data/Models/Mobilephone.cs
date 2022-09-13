namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.Drawing;

public class Mobilephone:Product
{
   

    [Key]
    public int Id { get; set; }

    [Required]
    public double Size { get; set; }

    [Required]
    public double Model { get; set; }

    [Required]
    public double DisplaySizeInch { get; set; }

    [Required]
    public double DisplaySizeCm { get; set; }

    [Required]
    public string DisplayType { get; set; }

    [Required]
    public int Ram { get; set; }

    [Required]
    public double Resolution { get; set; }

    
}