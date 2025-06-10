using MeetingAppNew.Models;
using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost
        //localhost/home
        //localhost/home/index

        public IActionResult Index()
        {


            //ViewData ile yapýlýþý
            int saat = DateTime.Now.Hour;
            ViewData["Selamlama"] = saat > 12 ? "Ýyi Günler" : "Günaydýn";
            int UserCount=Repository.Users.Where(info=>info.WillAttend == true).Count();
            //ViewData["UserName"] = "Neslihan";



            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Ýstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount

            }; 

            //model olarak gönderirken böyle yapýlýr ve  bu fonksiyonun view klasörünün baþýna @model string  yazýlýr
            //ve kullanýlacak yere de @Model yazýlýr ve orada istenen string gözükür.
            /*
            ------------------------------------------------
            Viewda böyle yazýlýr.
            @model string 
            <h1 class="h4">@Model</h1>
            -------------------------------------
            int saat = DateTime.Now.Hour;
            var selamlama = saat > 12 ? "Ýyi Günler" : "Günaydýn";
            return View(model:selamlama);
            */

            //viewbag kullanýrken de böyle yazýlýr. View dosysadýnda selamlamanýn kullanýlcak olduðu yere @ViewBag.selamlama yazýlarak kullaným saðlanýr.
            //-------------------------Viewda yazýlýþ þekli--------------------------------------
            //<h1 class="h4">@ViewBag.selamlama @ViewBag.UserName</h1>
            /*
            int saat = DateTime.Now.Hour;
            ViewBag.selamlama = saat > 12 ? "Ýyi Günler" : "Günaydýn";
            ViewBag.UserName="Neslihan";
            return View();
            */

            return View(meetingInfo);




        }
    }
}