using Exercice02.Classes;

namespace Exercice02.NUnit;

public class Tests
{
    [Test]
    [TestCase(1)]
    public void GetFibSeries_ShouldNotReturnEmptyList(int range)
    {
        var fib = new Fib(range);

        var result = fib.GetFibSeries();
        
        CollectionAssert.IsNotEmpty(result);
    }
    
    [Test]
    [TestCase(1, 0)]
    [TestCase(6, 0, 1, 1, 2, 3, 5)]
    public void GetFibSeries_ShouldReturnList(int range, params int[] expected)
    {
        var fib = new Fib(range);

        var result = fib.GetFibSeries();

        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    [TestCase(6, 3)]
    public void GetFibSeries_ResultShouldContainGivenNumber(int range, int given)
    {
        var fib = new Fib(range);

        var result = fib.GetFibSeries();
        
        CollectionAssert.Contains(result, given);
    }

    [Test]
    [TestCase(6, 6)]
    public void GetFibSeries_ResultContainsExpectedNumberOfElements(int range, int expected)
    {
        var fib = new Fib(range);

        var result = fib.GetFibSeries();

        Assert.That(expected, Is.EqualTo(result.Count));
    }
    
    [Test]
    [TestCase(6, 4)]
    public void GetFibSeries_ResultDoesNotContainsExpectedElements(int range, int expected)
    {
        var fib = new Fib(range);

        var result = fib.GetFibSeries();

        CollectionAssert.DoesNotContain(result, expected);
    }
    
    [Test]
    [TestCase(6)]
    public void GetFibSeries_ResultIsOrdered(int range)
    {
        var fib = new Fib(range);

        var result = fib.GetFibSeries();

        CollectionAssert.IsOrdered(result);
    }
    
    
}