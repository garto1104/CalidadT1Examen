namespace TestCalidadBook.Test;
using CalidadT1;

public class BookStore
{
    [Test]
    public void Test1()
    {
        var libro = new shopingcart();
        libro.Title = "El principito";
        libro.costo = 10;
        var result = libro.GetTitle();
        Assert.AreEqual("El principito", result);
    }
}