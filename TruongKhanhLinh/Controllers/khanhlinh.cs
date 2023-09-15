using Microsoft.AspNetCore.Mvc;

namespace TruongKhanhLinh.Controllers
{
    public class khanhlinh : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = " ";
            return View();
        }
        public IActionResult Index(int hoten, int ngaysinh, int email, int sodienthoai)
        {
            ViewData["hoten"] = hoten;
            ViewData["ngaysinh"] = ngaysinh;
            ViewData["email"] = email;
            ViewData["sodienthoai"] = sodienthoai;
            return View();
        }
    }
}
