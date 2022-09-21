namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

public class Mobilephone
{
    

    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public int Year { get; set; }

    [Required]
    public int PicxelesOfTheCamera { get; set; }

    [Required]
    public double DisplaySizeInch { get; set; }

    [Required]
    public double DisplaySizeCm { get; set; }

    [Required]
    public string DisplayType { get; set; }

    [Required]
    public int Ram { get; set; }

    [Required]
    public string Resolution { get; set; }

    [Required]
    public string CPU { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Url { get; set; }

    public int MobilephoneModelId { get; set; }
   
    public virtual PhoneModel PhoneModel { get; set; }
}