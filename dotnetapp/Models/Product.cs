using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dotnetapp.Models;
public class Product
{
    [Key]
    public int ProductId{get;set;}
    public string ProductName{get;set;}
    public int SupplierId{get;set;}
    [ForeignKey("Category")]
    public int CategoryId{get;set;}
    public string QuantityPerUnit{get;set;}
    public float UnitPrice{get;set;}
    public int UnitsinStock{get;set;}
    public int UnitsOnOrder{get;set;}
    public int RecorderLevel{get;set;}
    public int Discontinued{get;set;}
    public Category Category{get;set;}

}