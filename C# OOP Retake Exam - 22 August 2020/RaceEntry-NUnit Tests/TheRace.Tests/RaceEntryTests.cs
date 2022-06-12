using NUnit.Framework;
using System;
namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private UnitCar car;
        private UnitDriver driver;
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            this.car = new UnitCar("BMW", 150, 2000);
            this.driver = new UnitDriver("Ivan", car);
            this.raceEntry = new RaceEntry();

        }

        [Test]
        public void AddDriverReturnsCorrectString()
        {
            var result = raceEntry.AddDriver(driver);
            var expected = ($"Driver {driver.Name} added in race.");
            Assert.AreEqual(expected, result);
            Assert.That(raceEntry.Counter.Equals(1));
            
        }

        [Test]
        public void AddDriverThrowsExceptionWhenUnitDriverIsNull()
        {
            
            var excetion = Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(null));
            var expectedExceptionMessage = ($"Driver cannot be null.");

            Assert.AreEqual(expectedExceptionMessage, excetion.Message);

        }


        [Test]
        public void AddDriverThrowsExceptionWhenDriverWithSameNameIsAdded()
        {
            this.raceEntry.AddDriver(driver);
            var newCar = new UnitCar("Audi", 150, 2000);
            var newDriver = new UnitDriver("Ivan",newCar);

            var excetion = Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(newDriver));
            var expectedExceptionMessage = "Driver Ivan is already added."; 

            Assert.AreEqual(expectedExceptionMessage, excetion.Message);
        }
        [Test]
        public void CalculateAverageHorsePowerReturnsCorrectValue()
        {
            this.raceEntry.AddDriver(driver);

            var driver1Car = new UnitCar("Mazda", 100, 1900);
            var driver1 = new UnitDriver("Simon",driver1Car);

            var driver2Car = new UnitCar("Opel", 90, 1700);
            var driver2 = new UnitDriver("Pesho", driver2Car);

            raceEntry.AddDriver(driver1);
            raceEntry.AddDriver(driver2);

            double expectedResult = ((driver.Car.HorsePower + driver1.Car.HorsePower+driver2.Car.HorsePower)*1.0)/3;
            double result = raceEntry.CalculateAverageHorsePower();
            
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void CalculateAverageHorsePowerThrowsExceptionWhenCounterLessThen2()
        {
            this.raceEntry.AddDriver((driver));

            var exception = Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
            var expectedExceptionMessage = "The race cannot start with less than 2 participants.";

            Assert.That(expectedExceptionMessage, Is.EqualTo(exception.Message));

        }
    }
}