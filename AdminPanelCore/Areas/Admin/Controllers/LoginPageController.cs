using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPanelCore.Valitade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
namespace AdminPanelCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginPageController : Controller
    {
        
        public class userLogin {
            public string email { get; set; }
            public string pass { get; set; }
        }

        public class userSignUp {
            public string name { get; set; }
            public string email { get; set; }
            public string pass { get; set; }
            public string pass1 { get; set; }
        }
        ILogger<LoginPageController> _logger;
        public LoginPageController(ILogger<LoginPageController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //_logger.LogInformation("hello");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Login(userLogin u)
        {
            
            if (Validate.CheckEmptyData(u))  return "Alanların Doldurulması Gerekmektedir.";
            if (Validate.IsValidEmail(u.email)) return "Geçerli Mail Adresi Giriniz!";
            //veritabanından çek
            HttpContext.Session.SetString("email", "veri");
            HttpContext.Session.SetString("name", "veri");
            HttpContext.Session.SetString("id", "veri");
            
            return "Giriş Yapılıyor!" ;
        }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string SignUp(userSignUp u)
        {
            if (!Validate.CheckEmptyData(u)) return "Alanların Doldurulması Gerekmektedir.";
            if (!Validate.IsValidEmail(u.email)) return "Geçerli Mail Adresi Giriniz!";
            if (!Validate.checkUniqEmail(u.email)) return "Bu Mail Adresi Zaten Kullanılıyor!";
            if (!Validate.equalPassCheck(u.pass,u.pass1)) return "Şifreler Eşleşmiyor!";
           
            return "Kayıt Oluşturuldu!" ;
        }
    }
}