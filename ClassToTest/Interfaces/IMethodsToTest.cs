using ClassToTest.Models;

namespace ClassToTest.Interfaces;

public interface IMethodsToTest
{
    int Add(List<Product> products);
    int Subtract(List<Product> products);
    int Multiply(List<Product> products);
    double Divide(List<Product> products);
}