using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Assignment.Data;
using Assignment.Models;

namespace Assignment.Pages.Orders
{
public class CreateModel : PageModel
{
private readonly AppDbContext _context;

public CreateModel(AppDbContext context)
{
_context = context;
}

[BindProperty]
public Order Order { get; set; }

public IActionResult OnPost()
{
_context.Orders.Add(Order);
_context.SaveChanges();

return RedirectToPage("Index");
}
}
}