namespace MyWebProject.Models.MobilePhones;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class AddMobilePhoneFromModels
{
    public string Name { get; init; }

    public decimal Price { get; init; }

    public double DisplaySizeInch { get; init; }

    public double DisplaySizeCm { get; init; }

    public string DisplayType { get; init; }

    public int Ram { get; init; }

    public double Resolution { get; init; }

    public string CPU { get; init; }

    public string Description { get; init; }
    [Display(Name = "Image Url")]
    public string Url { get; init; }
}