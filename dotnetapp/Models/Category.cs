using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
namespace dotnetapp.Models;
public class Category
{
    [Key]
    public int CategoryID{get;set;}
    public string CategoryName{get;set;}
    public string Description{get;set;}
    public byte[] Picture{get;set;}
    public ICollection<Product>Products{get;set;}
}