using  Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;
namespace dotnetapp.Controllers;
public class OrderController:Controller
{
  private readonly AppDbContext context;
  public OrderController(AppDbContext _context)
  {
    context=_context;
  }
  public IActionResult DisplayCustomers()
  {
    var data=context.Customers.ToList();
    return View(data);
  }

  public IActionResult DisplayProductWithCat()
  {
    var data=from p in context.Products select new{p.ProductName,p.Category.CategoryName};
    return View(data);
  }

}