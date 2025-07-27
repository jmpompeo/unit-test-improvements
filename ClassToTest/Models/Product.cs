namespace ClassToTest.Models;

public class Product(string item, int price)
{
    public string Item { get; set; } = item;
    public int Price { get; set; } = price;
}