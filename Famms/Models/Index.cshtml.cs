using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Famms.Entities;
using Famms.Data;

namespace Famms.Models
{
    public class IndexModel : PageModel
    {
        public List<Product>? Products { get; set; }

        public void OnGet()
        {
            Products = ProductList.Products();
        }
    }
}