using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        [SetUp]
        public void SetUp()
        {
            axe = new Axe(100, 100);

        }
        [Test]
        public void AxeCreatedWithCorrectValues()
        {            
            Assert.That(axe.AttackPoints.Equals(100));
            Assert.That(axe.DurabilityPoints.Equals(100));
        }

        [Test]
        public void AxeThrowsExceptionWhenDurabilityIsZero()
        {
            var axe1 = new Axe(100, 0);
            var dummy = new Dummy(100, 5);
            Assert.Throws<InvalidOperationException>(() => axe1.Attack(dummy));
        
        }


        [Test]
        public void AxelossesDurabilityWhenAttackingDummy()
        {
            var dummy = new Dummy(100, 5);
            axe.Attack(dummy);
            Assert.That(axe.DurabilityPoints.Equals(99));

        }



    }

}

