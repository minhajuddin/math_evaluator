using Xunit;

namespace MathEvaluator.Tests {
  public class EvaluatorTests {

    readonly Evaluator _eval;

    public EvaluatorTests() {
      _eval = new Evaluator();
    }

    [Fact]
    public void Evaluate_Returns8_For5Plus3() {
      var result = _eval.Evaluate("3+5");
      Assert.True(result == 8);
    }

    [Fact]
    public void Evaluate_ReturnsValidResult_ForFourAdditions() {
      var result = _eval.Evaluate("5+3+2+5");
      Assert.True(result == 15);
    }

    [Fact]
    public void Evaluate_ReturnsValidResult_ForSimpleSubtraction() {
      var result = _eval.Evaluate("5-2");
      Assert.True(result == 3);
    }

    [Fact]
    public void Evaluate_ReturnsValidResult_ForComplexSubtraction() {
      var result = _eval.Evaluate("5-2-1.1+2.2-2.4");
      Assert.True(result == 1.7M);
    }

    [Fact]
    public void Evaluate_ReturnsValidResult_ForComplexMultiplication() {
      var result = _eval.Evaluate("5*2-1.1*2.2-2.4");
      Assert.True(result == 5.18M);
    }


    [Fact]
    public void Evaluate_ReturnsValidResult_ForComplexDivision() {
      var result = _eval.Evaluate("5*2-1.1*2.2-2.4+5/2+5*3/2+5/2*3");
      Assert.True(result == 22.68M);
    }


  }
}