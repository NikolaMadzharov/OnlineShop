namespace MyWebProject.Controllers;

using Microsoft.AspNetCore.Mvc;

using MyWebProject.Infrastructure.Data;
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
    

    [HttpPost]
    public IActionResult Add(AddMobilePhoneFromModels phone)
    {
        return View();
    }

    public IEnumerable<MobilePhoneViewModel> GetPhoneModels() =>
        this.data.PhoneModels.Select(
            m => new MobilePhoneViewModel
                     {
                         id = m.Id,
                         Model = m.Model
                     }).ToList();

}