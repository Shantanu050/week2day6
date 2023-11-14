namespace dotnetapp.Models;
public class OrderDetail
{
    public int OrderId{get;set;}
    public int ProductId{get;set;}
    public float UnitPrice{get;set;}
    public float Discount{get;set;}
}