using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyEshop.Data;
using MyEshop.Models;
using System.IO;

namespace MyEshop.Pages.Admin
{
    public class AddModel : PageModel
    {
        private readonly MyEshopContext _context;
        public AddModel(MyEshopContext context)
        {
            _context = context;
        }
        [BindProperty]
        public AddEditProductviewModel Product { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var item = new Item
            {
                Price = Product.Price,
                QuantityInStock = Product.QuantityInStock,
            };

            var pro = new Product
            {
                Name = Product.Name,
                Item = item,
                Description = Product.Description,
            };

            pro.Item = item;

            _context.Add(pro);

            if (Product.Picture?.Length>0)
            {
                string filepath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","images",pro.Id+Path.GetExtension(Product.Picture.FileName));
                using(var stream = new FileStream(filepath,FileMode.Create))
                {
                    Product.Picture.CopyTo(stream);
                }
            }

            _context.SaveChanges();
            return RedirectToAction("Index");   

        }
    }
}
