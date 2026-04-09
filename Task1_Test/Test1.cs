using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class OrderTests
{
    [TestMethod]
    public void PayBill_ShouldReturnCorrectTotal()
    {
        // Arrange
        Order order = new Order("Chocolate Sauce", 2);

        // Act
        double result = order.pay_bill(8);

        // Assert
        Assert.AreEqual(16, result);
    }

    [TestMethod]
    public void PayBill_WithZeroQuantity()
    {
        // Arrange
        Order order = new Order("Plain Sugar", 0);

        // Act
        double result = order.pay_bill(6);

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void OrderID_ShouldBeUnique()
    {
        // Arrange
        Order order1 = new Order("Nutella", 1);
        Order order2 = new Order("Chocolate", 1);

        // Act
        int id1 = order1.order_no;
        int id2 = order2.order_no;

        // Assert
        Assert.IsTrue(id2 > id1);
    }
}