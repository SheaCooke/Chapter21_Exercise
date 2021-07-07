using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTest
    {
        Computer c;
        [TestInitialize]
        public void Initialize()
        {
            c = new Computer("2020", "Mac", "Apple");

        }

        [TestCleanup]
        public void CleanUp()
        {
            c = null;
        }


        [TestMethod]
        public void SearchInternetPrintsCorrectValue()
        {
            Assert.AreEqual("Searching the internet for Google", c.SearchInternet("Google"));
        }

        [TestMethod]
        public void UsingEmailReturnsCorrectString()
        {
            Assert.AreEqual("Using email", c.UseEmail());
        }

        [TestMethod]
        public void ManufacturerAddedCorrectly()
        {
            Assert.AreEqual("Apple", c.Manufacturer);
        }

    }
    [TestClass]
    public class LaptopTest
    {
        Laptop l;
        [TestInitialize]
        public void initialize()
        {
            l = new Laptop("user", "2020", "Macbook", "Apple");
        }

        [TestCleanup]
        public void cleanup()
        {
            l = null;
        }

        [TestMethod]
        public void ChangeLocationPrintsCorrectString()
        {
            Assert.AreEqual("Moving to new location", l.ChangeLocation("new location"));
        }

        [TestMethod]
        public void ConstructorAddsModelCorrectly()
        {
            Assert.AreEqual("Macbook", l.Model);
        }

        [TestMethod]
        public void ConstructorAddsYearCorrectly()
        {
            Assert.AreEqual("2020", l.YearBuilt);
        }
    }

    [TestClass]
    public class SmartPhoneTest
    {
        Smartphone s;

        [TestInitialize]
        public void Initialize()
        {
            s = new Smartphone("user", "2020", "Iphone", "Apple");
        }

        [TestCleanup]
        public void Cleanup()
        {
            s = null;
        }

        [TestMethod]
        public void CallPrintsCorrectString()
        {
            Assert.AreEqual("Calling home", s.Call("home"));
        }

        [TestMethod]
        public void ConstructorSetsUserProperly()
        {
            Assert.AreEqual("user", s.User);
        }

        [TestMethod]
        public void ConstructorAddsYearCorrectly()
        {
            Assert.AreEqual("2020", s.YearBuilt);
        }
    }
}
