namespace MyWebProject.Controllers;

using Microsoft.AspNetCore.Mvc;

using MyWebProject.Infrastructure.Data;
using MyWebProject.Infrastructure.Data.Models;
using MyWebProject.Models.MobilePhones;

public class MobilePhoneController : Controller
{
    private readonly ApplicationDbContext data;

    public MobilePhoneController(ApplicationDbContext data)
    {
        this.data = data;
    }

    public IActionResult Add() => View(new AddMobilePhoneFromModels
    {
        MobilePhonesModels = this.GetPhoneModels()
    });


    public IActionResult All()
    {
        var phones = this.data
            .Mobilephones
            .OrderByDescending(x => x.Id)
            .Select(
            x => new PhoneListingViewModel
            {
                Id = x.Id,
                Brand = x.Name,
                Price = x.Price,
                Year = x.Year,
                Url = x.Url,
                PhoneModels = x.PhoneModel.Model
            }).ToList();
        return View(phones);
    }


    [HttpPost]
    public IActionResult Add(AddMobilePhoneFromModels phone)
    {
        if (!this.data.PhoneModels.Any(m => m.Id == phone.ModelId))
        {
            this.ModelState.AddModelError(nameof(phone.ModelId), "The model does not exist!");
        }

        if (!ModelState.IsValid)
        {
            phone.MobilePhonesModels = this.GetPhoneModels();

            return View(phone);
        }

        var mobilephone = new Mobilephone
        {
            Name = phone.Brand,
            Price = (decimal)phone.Price,
            DisplaySizeCm = (double)phone.DisplaySizeCm,
            DisplaySizeInch = (double)phone.DisplaySizeInch,
            DisplayType = phone.DisplayType,
            Ram = (int)phone.Ram,
            Resolution = phone.Resolution,
            CPU = phone.CPU,
            Description = phone.Description,
            Url = phone.Url,
            PicxelesOfTheCamera = (int)phone.PicxelesOfTheCamera,
            Year = (int)phone.Year,
            MobilephoneModelId = phone.ModelId
        };
        this.data.Add(mobilephone);
        this.data.SaveChanges();

        return this.RedirectToAction("Index", "Home");
    }

    public IEnumerable<MobilePhoneViewModel> GetPhoneModels() =>
        this.data.PhoneModels.Select(
            m => new MobilePhoneViewModel
            {
                id = m.Id,
                Model = m.Model
            }).ToList();

}