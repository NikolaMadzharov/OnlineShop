namespace MyWebProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using MyWebProject.Models.MobilePhones;

public class MobilePhone : Controller
{
    public IActionResult Add() => View();
    

    [HttpPost]
    public IActionResult Add(AddMobilePhoneFromModels phone)
    {
        return View();
    }
}