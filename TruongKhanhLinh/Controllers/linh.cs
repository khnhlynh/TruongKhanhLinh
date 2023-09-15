using Microsoft.AspNetCore.Mvc;

namespace TruongKhanhLinh.Controllers
{
    public class linh : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private static List<ModelDanhSach> products = new();

        public static List<ModelDanhSach> Products { get => products; set => products = value; }

        public IActionResult Index(bool? check = false)
        {
            if ((bool)check)
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(string tensanpham, int soluong, int dongia, int giamgia)
        {
            var homeProduct = new ModelDanhSach(tensanpham,soluong,dongia, giamgia);
            products.Add(homeProduct);
            return View(products);
        }

        public IActionResult RemoveProduct(int position)
        {
            products.RemoveAt(position - 1);
            return RedirectToAction("Index", "Home");
        }
    }
}
