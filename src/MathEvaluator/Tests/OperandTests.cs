using Xunit;

namespace MathEvaluator.Tests {
  public class OperandTests {

    [Fact]
    public void OperationReturnsItsOwnValueWhenSingleParameterConstructorIsCalled() {
      var operand = new Operand(23);
      Assert.True(operand.Value == 23);
    }

    [Fact]
    public void NineIsImplicityConvertedToOperandNine() {
      Operand operand = 9;
      Assert.True(operand.Value == 9);
    }

    [Fact]
    public void OperationReturnsSumWhenOperationIsPlus() {
      var operand = new Operand(23, 33, '+');
      Assert.True(operand.Value == 56);
    }

    [Fact]
    public void OperationReturnsDifferenceWhenOperationIsMinus() {
      var operand = new Operand(23, 33, '-');
      Assert.True(operand.Value == -10);
    }

    [Fact]
    public void OperationReturnsProductWhenOperationIsAsterisk() {
      var operand = new Operand(23, 30, '*');
      Assert.True(operand.Value == 690);
    }

    [Fact]
    public void OperationReturnsDivisionWhenOperationIsSlash() {
      var operand = new Operand(35, 2, '/');
      Assert.True(operand.Value == 17.5M);
    }

    [Fact]
    public void OperationReturnsSameValueForIdentityOperation() {
      var operand = new Operand(35, null, '|');
      Assert.True(operand == 35);
    }

    [Fact]
    public void OperandIsImplicitlyConvertibleToDecimal() {
      decimal operand = new Operand(3);
      Assert.True(operand == 3);
    }

  }
}