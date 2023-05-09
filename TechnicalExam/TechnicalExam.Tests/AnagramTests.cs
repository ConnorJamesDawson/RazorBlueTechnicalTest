namespace TechnicalExam.Tests;
using TechnicalExam;

public class Tests
{

    [TestCase("eve", "vee", true)]
    [TestCase("evea", "veel", false)]
    [TestCase("evel", "veea", false)]
    [TestCase("evelaa", "veea", false)]
    [TestCase("anagram", "margana", true)]
    public void Test1(string anagram1, string anagram2, bool outcome)
    {
        bool sut = Task1.CompareAnagrams(anagram1, anagram2);

        Assert.That(sut, Is.EqualTo(outcome));
    }
}