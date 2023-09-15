namespace TruongKhanhLinh.Controllers
{
    public class ModelDanhSach
    {
        private string tensanpham;
        private int soluong;
        private int dongia;

        public ModelDanhSach(string tensanpham, int soluong, int dongia, int giamgia)
        {
            this.tensanpham = tensanpham;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}