public class ProductController : Controller
{
    // Giả lập danh sách Category
    private static List<string> categories = new List<string> { "Danh mục 1", "Danh mục 2", "Danh mục 3" };

    // Hiển thị form thêm mới
    [HttpGet]
    public ActionResult Create()
    {
        ViewBag.Categories = new SelectList(categories);
        return View();
    }

    // Xử lý dữ liệu gửi lên
    [HttpPost]
    public ActionResult Create(Product model)
    {
        if (ModelState.IsValid)
        {
            // Thực hiện lưu dữ liệu, ví dụ lưu vào database (ở đây chỉ hiển thị)
            // Gọi database hoặc xử lý phù hợp
            return RedirectToAction("Index", "Home"); // Chuyển hướng sau khi thêm thành công
        }

        // Nếu có lỗi, giữ lại danh mục
        ViewBag.Categories = new SelectList(categories);
        return View(model);
    }
}
