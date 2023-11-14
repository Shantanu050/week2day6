using  Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using dotnetapp.Models;
namespace dotnetapp.Models;
public class AppDbContext:DbContext
{
    public virtual DbSet<Product>Products{get;set;}
    public virtual DbSet<OrderDetail>OrderDetails{get;set;}
    public virtual DbSet<Order>Orders{get;set;}
    public virtual DbSet<Customer>Customers{get;set;}
    public virtual DbSet<Category>Categories{get;set;}
    public AppDbContext(){}
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder obj)=>
    obj.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=OrdersDB;trusted_connection=false;Persist Security Info=False;Encrypt=False");

}