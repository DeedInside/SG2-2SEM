using Microsoft.AspNetCore.Mvc;
using SG2.Models;
using SG2.ViewModels;

namespace SG2.Controllers
{
    public class HomeController : Controller
    {
        User _user = new User("Ivan","123@mail.ru","123","1234567");
        Car _car = new Car("Honda", 2012);

        public IActionResult Index()
        {
            IndexViewModel _indexViewModel = new IndexViewModel(_user, _car);
            return View(_indexViewModel);
        }
        public IActionResult Short()
        {
            return View();
        }
    }
}
