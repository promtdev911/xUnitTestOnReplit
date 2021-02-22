using Xunit;

public class CalculatorTest {

    [Fact]
    public void ShouldAdd() {
      
        var sut = new Calculator();

        var result = sut.Add(1, 2);

        Assert.Equal(3, result);
    }

}