namespace ClassToTest.Models;

public class Product
{
    public Product(string item, int price)
    {
        Item = item;
        Price = price;
    }

    public string Item { get; set; }
    public int Price { get; set; }
}