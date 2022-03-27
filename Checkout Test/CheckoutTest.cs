using First_Central_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Checkout_Test
{
    [TestClass]
    public class CheckoutTest
    {
        [TestMethod]
        public void ScanningOneItemAddsToTotalTest()
        {
            //Arrange
            Checkout checkout = new Checkout();
            Item item1 = new Item("A99", 0.50m, 3, 1.30m);

            //Act
            checkout.Scan(item1);

            //Assert
            Assert.AreEqual(0.50m, checkout.Total);
        }

        [TestMethod]
        public void ScanningTwoItemsAddsToTotalTest()
        {
            //Arrange
            Checkout checkout = new Checkout();
            Item item1 = new Item("A99", 0.50m, 3, 1.30m);
            Item item2 = new Item("B15", 0.30m, 2, 0.45m);

            //Act
            checkout.Scan(item1);
            checkout.Scan(item2);

            //Assert
            Assert.AreEqual(0.80m, checkout.Total);
        }

        [TestMethod]
        public void OfferOfThreeForOneThirtyAdjustsTotalTest()
        {
            //Arrange
            Checkout checkout = new Checkout();
            Item item1 = new Item("A99", 0.50m, 3, 1.30m);

            //Act
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);

            //Assert
            Assert.AreEqual(1.30m, checkout.Total);
        }

        [TestMethod]
        public void OfferOfThreeForOneThirtyAdjustsTotalWithOtherItemsTest()
        {
            //Arrange
            Checkout checkout = new Checkout();
            Item item1 = new Item("A99", 0.50m, 3, 1.30m);
            Item item2 = new Item("B15", 0.30m, 2, 0.45m);

            //Act
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item2);

            //Assert
            Assert.AreEqual(1.60m, checkout.Total);
        }

        [TestMethod]
        public void MultipleOffersTest()
        {
            //Arrange
            Checkout checkout = new Checkout();
            Item item1 = new Item("A99", 0.50m, 3, 1.30m);
            Item item2 = new Item("B15", 0.30m, 2, 0.45m);

            //Act
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item2);
            checkout.Scan(item2);

            //Assert
            Assert.AreEqual(1.75m, checkout.Total);
        }

        [TestMethod]
        public void MultipleOffersAndNilOfferTest()
        {
            //Arrange
            Checkout checkout = new Checkout();
            Item item1 = new Item("A99", 0.50m, 3, 1.30m);
            Item item2 = new Item("B15", 0.30m, 2, 0.45m);
            Item item3 = new Item("C40", 0.60m, 0, 0.00m);

            //Act
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item1);
            checkout.Scan(item2);
            checkout.Scan(item2);
            checkout.Scan(item3);

            //Assert
            Assert.AreEqual(2.35m, checkout.Total);
        }
    }
}