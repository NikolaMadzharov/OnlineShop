namespace MyWebProject.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PhoneModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Model { get; set; }

    [ForeignKey(nameof(Mobilephone))]
    public int MobilephoneId { get; set; }
    public virtual Mobilephone Mobilephone { get; set; }

} 