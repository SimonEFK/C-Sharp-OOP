using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShoudLoseHealthIfAttacked()
    {
        Dummy dummy = new Dummy(10, 10);

        dummy.TakeAttack(5);

        Assert.That(dummy.Health, Is.EqualTo(5), "Dummy doesn't lose health when attacked");
    }

    [Test]

    public void AttackingDeadDummyShouldThrowAnException()
    {
        Dummy dummy = new Dummy(10, 10);
        dummy.TakeAttack(10);

        
        
            Assert.That(() => dummy.TakeAttack(1), Throws.InvalidOperationException, "Attacking dead dummy should be impossible");

        
    }
    [Test]

    public void DummyShouldGiveExpirianceWhenIsDead()
    {
        Dummy dummy = new Dummy(10, 10);
        dummy.TakeAttack(10);
        //Assert.That(dummy.IsDead());
        Assert.That(dummy.GiveExperience(), Is.EqualTo(10));





    }
    [Test]
    public void DummyShouldNotGiveExpIfIsaLIVE()
    {
        
        Dummy dummy = new Dummy(10, 10);

        //Assert.That(dummy.IsDead(), Is.False);
        Assert.That(()=>dummy.GiveExperience(),Throws.InvalidOperationException);
        
       
    }
}
