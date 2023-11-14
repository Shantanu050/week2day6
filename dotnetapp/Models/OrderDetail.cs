using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dotnetapp.Models;
public class OrderDetail
{
    [Key]
    public int OrderId{get;set;}
    public int ProductId{get;set;}
    public float UnitPrice{get;set;}
    public float Discount{get;set;}
}