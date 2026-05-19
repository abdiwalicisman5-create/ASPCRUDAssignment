using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public List<Order> Orders { get; set; }

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Orders = _context.Orders.ToList();
        }
    }
}