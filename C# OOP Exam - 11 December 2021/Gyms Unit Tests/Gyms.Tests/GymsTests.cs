using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    public class GymsTests
    {
        

        [SetUp]
        public void SetUp()
        {

        }

        [Test]
       
        public void CreatingGymWithNullOrEmptyNameThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(null, 5));
        }

        [Test]
        public void NamePropertyReturnsCorrectValue()
        {
            var gym = new Gym("Gym", 5);
            var actualName = gym.Name;
            var expectedResult = "Gym";
            Assert.That(actualName.Equals(expectedResult));
        }

        [Test]

        public void CapacityPropertyThrowsExceptionWhenValueLessThenZero()
        {
            Assert.Throws<ArgumentException>(() => new Gym("Gym", -5));
        }

        [Test]
        public void CapacityPropertyReturnsCorrectValue()
        {
            var gym = new Gym("Gym", 5);
            var actualValue = gym.Capacity;
            var expectedResult = 5;
            Assert.That(actualValue.Equals(expectedResult));
        }

        //[Test]
        ////public void CountReturnCorrectValue()
        ////{
        ////    var gym = new Gym("Gym", 5);
        ////    var actualValue = gym.Count;
        ////    var expectedResult = 0;

        ////    Assert.That(actualValue.Equals(expectedResult));

        ////}

        [Test]
        public void AddAthleteThrowsExceptionWhenGymFull()

        {
            var gym = new Gym("Gym", 1);
            var athlete = new Athlete("Name");
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(new Athlete("Random Name")));




        }
        [Test]
        public void AddAthleateInceasesGymAthleatesCount()
        {
            var gym = new Gym("Gym", 2);
            var athlete = new Athlete("Name");
            gym.AddAthlete(athlete);
            var gymCount = gym.Count;
            Assert.That(gymCount.Equals(1));
        }

        [Test]
        public void RemoveAthleteThrowsExceptionWhenAtheleteIsNull()
        {

            var gym = new Gym("Gym", 2);
            string athleteName = null;
            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete(athleteName));


        }

        [Test]
        public void RemoveAthleteReducesGymCount()
        {
            var gym = new Gym("Gym", 2);
            var athlete = new Athlete("Name");
            gym.AddAthlete(athlete);
            gym.RemoveAthlete("Name");
            Assert.That(gym.Count == 0);

        }

        [Test]
        public void InjureAthleteChangesInjureStatusCorrectly()
        {

            var gym = new Gym("Gym", 2);
            var athlete = new Athlete("Name");
            gym.AddAthlete(athlete);
            gym.InjureAthlete("Name");
            var actualAthlete = gym.InjureAthlete("Name");
            Assert.IsTrue(athlete.IsInjured);
            Assert.That(actualAthlete.Equals(athlete));


        }
        [Test]
        public void InjureAtheleteThrowsExceptionWhenAthleteNameIsNull()
        {

            var gym = new Gym("Gym", 2);
            var athlete = new Athlete("Name");
            string athleteName = null;
            gym.AddAthlete(athlete);
            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete(athleteName));


        }
        [Test]
        public void ReportReturnsCorrectString()
        {
            var gym = new Gym("SuperGym", 1);
            var athlete = new Athlete("Name");
            gym.AddAthlete(athlete);

            var expectedString = "Active athletes at SuperGym: Name";
            var actualString = gym.Report();
            Assert.That(actualString, Is.EqualTo(expectedString));

        }

    }
}
