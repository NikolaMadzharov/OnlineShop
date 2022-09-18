namespace MyWebProject.Models.MobilePhones;


using System.ComponentModel.DataAnnotations;

public class AddMobilePhoneFromModels
{
    public string Brand { get; set; }

    public decimal Price { get; set; }

    public double DisplaySizeInch { get; set; }

    public double DisplaySizeCm { get; set; }

    public string DisplayType { get; set; }

    public int Ram { get; set; }

    public double Resolution { get; set; }

    public string CPU { get; set; }

    public string Description { get; set; }
    [Display(Name = "Image Url")]
    public string Url { get; set; }

    public int ModelId { get; set; }

    public IEnumerable<MobilePhoneViewModel> MobilePhonesModels { get; set; }
}