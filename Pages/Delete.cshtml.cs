using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

        public void OnGet(int id)
        {
            Order = _context.Orders.Find(id);
        }

        public IActionResult OnPost()
        {
            _context.Orders.Remove(Order);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}