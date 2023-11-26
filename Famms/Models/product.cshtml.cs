using Famms.Data;
using Famms.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Famms.Models
{
    public class productModel : PageModel
    {
        public List<Product>? Products { get; set; }

        public void OnGet()
        {
            Products = ProductList.Products();
        }
    }
}
