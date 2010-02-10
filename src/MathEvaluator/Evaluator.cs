using System;

namespace MathEvaluator {
  public class Evaluator {
    public decimal Evaluate(string expression) {
      return Reduce(expression,
                    '+',
                    x => Reduce(x,
                      '-',
                      y => Reduce(y,
                        '*', z => Reduce(z,
                              '/', s => decimal.Parse(s)))));
    }

    private decimal Reduce(string expression, char operation, Func<string, decimal> furtherReduction) {
      var tokens = expression.Split(operation);
      Operand operand = furtherReduction(tokens[0]);
      for (int i = 1; i < tokens.Length; i++) {
        operand = new Operand(operand, furtherReduction(tokens[i]), operation);
      }
      return operand;
    }
  }
}