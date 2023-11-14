using  Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace dotnetapp.Models;
public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {

    }

}