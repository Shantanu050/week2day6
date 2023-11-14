namespace dotnetapp.Models;
public class Product
{
    public int ProductId{get;set;}
    public string ProductName{get;set;}
    public int SupplierId{get;set;}
    public int CategoryId{get;set;}
    public string QuantityPerUnit{get;set;}
    public float UnitPrice{get;set;}
    public int UnitsinStock{get;set;}
    public int UnitsOnOrder{get;set;}
    public int RecorderLevel{get;set;}
    public int Discontinued{get;set;}


}