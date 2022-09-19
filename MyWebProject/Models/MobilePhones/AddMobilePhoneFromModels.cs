
using System.ComponentModel.DataAnnotations;

using MyWebProject.Models.MobilePhones;
using static MyWebProject.Infrastructure.GlobalConstants.GlobalConstants;
public class AddMobilePhoneFromModels
{
    [Required]
    [StringLength(MaxPhoneBrandName, MinimumLength = MinPhoneBrandName)]
    public string Brand { get; set; }

    [Required]
    public decimal Price { get; set; }

    [Required]
    public double DisplaySizeInch { get; set; }

    [Required]
    public double DisplaySizeCm { get; set; }
   
    [Required]
    [StringLength(MinDisplayType, MinimumLength = MinDisplayType)]
    public string DisplayType { get; set; }
    [Required]
 
    public int Ram { get; set; }
    [Required]
    public string Resolution { get; set; }
    [Required]
    [StringLength(MaxCPU, MinimumLength = MinCPU)]
    public string CPU { get; set; }

    [Required]
    [StringLength(MaxDescription, MinimumLength = MinDescription)]
    public string Description { get; set; }

    [Display(Name = "Image Url")]
    [Required]
    [Url]
    public string Url { get; set; }

    [Display(Name = "Models")]
    public int ModelId { get; set; }

    public IEnumerable<MobilePhoneViewModel> MobilePhonesModels { get; set; }
}