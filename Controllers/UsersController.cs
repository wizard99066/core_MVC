using HW_11.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;
using System.Diagnostics;

namespace HW_11.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string LastName, string FirstName, string MiddleName, Sex Sex, DateTime BirthDate, string Info)
        {
            var data = System.IO.File.ReadAllText("Data.json");
            var users = JsonSerializer.Deserialize<List<UserInfo>>(data) ?? new List<UserInfo>();
            users.Add(new UserInfo { LastName = LastName, FirstName = FirstName,  MiddleName = MiddleName, BirthDate = BirthDate, Sex = Sex, InformationAboutYourself = Info });
            data = JsonSerializer.Serialize(users);
            System.IO.File.WriteAllText("Data.json", data);         
            return View("Index", "Всё ок!");
        }

        public IActionResult TakeUsers()
        {
            var data = System.IO.File.ReadAllText("Data.json");
            var users = JsonSerializer.Deserialize<List<UserInfo>>(data) ?? new List<UserInfo>();
            return View(users);
        }

        

    }
}