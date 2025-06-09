using Microsoft.AspNetCore.Mvc;

namespace Mbalesson04.Controllers
{
    public class MbaBook : Controller
    {
        private readonly List<MbaBook> MbaBooks =
        [
            new() {
                MbaId = "MBA001",
                MbaTitle = "Quản trị chiến lược",
                MbaDescription = "Cuốn sách cung cấp kiến thức sâu rộng về xây dựng và triển khai chiến lược trong kinh doanh.",
                MbaImage = "Image/book-1.jpg",
                MbaPrice = 129000f,
                MbaPage = 320
            },
            new() {
                MbaId = "MBA002",
                MbaTitle = "Nguyên lý marketing",
                MbaDescription = "Giới thiệu các nguyên tắc cơ bản của marketing hiện đại và cách áp dụng thực tiễn.",
                MbaImage = "Image/book-2.jpg",
                MbaPrice = 99000f,
                MbaPage = 280
            },
            new() {
                MbaId = "MBA003",
                MbaTitle = "Kế toán tài chính",
                MbaDescription = "Hướng dẫn cách đọc, hiểu và phân tích báo cáo tài chính doanh nghiệp.",
                MbaImage = "Image/book-3.jpg",
                MbaPrice = 149000f,
                MbaPage = 400
            },
            new() {
                MbaId = "MBA004",
                MbaTitle = "Hành vi tổ chức",
                MbaDescription = "Phân tích cách cá nhân và nhóm hành xử trong môi trường doanh nghiệp.",
                MbaImage = "Image/book-4.jpg",
                MbaPrice = 115000f,
                MbaPage = 350
            },
            new() {
                MbaId = "MBA005",
                MbaTitle = "Quản lý vận hành",
                MbaDescription = "Tối ưu hóa quy trình sản xuất và dịch vụ để nâng cao hiệu suất hoạt động.",
                MbaImage = "Image/book-5.jpg",
                MbaPrice = 107000f,
                MbaPage = 310
            }
        ];

        public string? MbaId { get; private set; }
        public string? MbaTitle { get; private set; }
        public string? MbaDescription { get; private set; }
        public string? MbaImage { get; private set; }
        public float MbaPrice { get; private set; }
        public int MbaPage { get; private set; }


        //GET: / MbaBook/MbaIndex  => Take all book
        public IActionResult MbaIndex()
        {
            return View(MbaBooks);
        }
    }
}
