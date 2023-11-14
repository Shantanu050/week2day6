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

}