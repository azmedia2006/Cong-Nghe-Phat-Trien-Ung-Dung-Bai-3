using Microsoft.AspNetCore.Mvc;
using DMQuan.Models;

namespace DMQuan.Controllers
{
    public class ProductController : Controller
    {
        //Gia lap csdl 
        private static List<Models.Product> products = new List<Models.Product>
        {
                new Models.Product { Id = 1, Name = "Product 1", Price = 10.99m, Description = "Description of Product 1" },
                new Models.Product { Id = 2, Name = "Product 2", Price = 20.99m, Description = "Description of Product 2" },
                new Models.Product { Id = 3, Name = "Product 3", Price = 30.99m, Description = "Description of Product 3" }
        };
        public IActionResult Index()
        {
            return View(products);
        }
        // --- GET: Hiển thị chi tiết sản phẩm ---
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }
        // --- GET: Create Form ---
        public IActionResult Create()
        {
        return View();
        }
        // --- POST: Xử lý form gửi về ---
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product newProduct)
        {
            newProduct.Id = products.Max(p => p.Id) + 1; // Sinh ID mới
                products.Add(newProduct); // Thêm vào danh sách
            return RedirectToAction(nameof(Index));
        }
        // --- GET: Hiển thị form sửa sản phẩm ---
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }
        // --- POST: Nhận dữ liệu sau khi sửa ---
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id ==
            updatedProduct.Id);
            if (product == null)
                return NotFound();
            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Description = updatedProduct.Description;
            return RedirectToAction(nameof(Index));
        }
        // --- GET: Hiển thị xác nhận xóa ---
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return View(product);
        }
// --- POST: Xác nhận xóa ---
[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
