using Mbalss04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mbalss04.Controllers
{
    public class BookController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private  List<MbaBook> MbaBooks = new List<MbaBook>
{
    new MbaBook
    {
        MbaId = "B001",
        MbaTitle = "Quản Trị Chiến Lược",
        MbaDescription = "Phân tích và ứng dụng chiến lược trong kinh doanh hiện đại.",
        MbaImage = "Image/Book-1.jpg",
        MbaPrice = 150000f,
        MbaPage = 320
    },
    new MbaBook
    {
        MbaId = "B002",
        MbaTitle = "Lãnh Đạo Trong Thời Đại Số",
        MbaDescription = "Kỹ năng lãnh đạo trong môi trường chuyển đổi số.",
        MbaImage = "Image/Book-2.jpg",
        MbaPrice = 170000f,
        MbaPage = 280
    },
    new MbaBook
    {
        MbaId = "B003",
        MbaTitle = "Marketing Hiện Đại",
        MbaDescription = "Chiến lược marketing và hành vi người tiêu dùng.",
        MbaImage = "Image/Book-3.jpg",
        MbaPrice = 160000f,
        MbaPage = 300
    },
    new MbaBook
    {
        MbaId = "B004",
        MbaTitle = "Tài Chính Doanh Nghiệp",
        MbaDescription = "Quản lý tài chính và đầu tư trong doanh nghiệp.",
        MbaImage = "Image/Book-4.jpg",
        MbaPrice = 180000f,
        MbaPage = 350
    },
    new MbaBook
    {
        MbaId = "B005",
        MbaTitle = "Quản Lý Nhân Sự Chiến Lược",
        MbaDescription = "Phát triển nguồn nhân lực và chiến lược tổ chức.",
        MbaImage = "Image/Book-5.jpg",
        MbaPrice = 165000f,
        MbaPage = 310
    }
};




        // GET: /MbaBook/MbaIndex => lấy tất cả 5 cuốn
        public IActionResult MbaIndex()
        {
            //đưa dữ liệu lên view
            return View(MbaBooks);
        }
    }
}
