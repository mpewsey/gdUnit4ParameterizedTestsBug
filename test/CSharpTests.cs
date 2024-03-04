using GdUnit4;
using System.Threading.Tasks;

[TestSuite]
public class CSharpTests
{
    [TestCase(1, 2, 3, 6)]
    [TestCase(3, 4, 5, 12)]
    [TestCase(6, 7, 8, 21)]
    public void TestCaseArguments(int a, int b, int c, int expect)
    {
        Assertions.AssertThat(a + b + c).IsEqual(expect);
    }

    [TestCase(1, 2, 3, 6)]
    [TestCase(3, 4, 5, 12)]
    [TestCase(6, 7, 8, 21)]
    public async Task TestCaseArgumentsWithScene(int a, int b, int c, int expect)
    {
        var runner = ISceneRunner.Load("res://test_scene.tscn", true, true);
        await runner.AwaitMillis(10000);
        Assertions.AssertThat(a + b + c).IsEqual(expect);
    }
}
