using System;
using System.Collections.Generic;

namespace MathEvaluator {
  public class Operand {
    static readonly Dictionary<char, Func<Operand, Operand, decimal>> _operationDefinitions =
      new Dictionary<char, Func<Operand, Operand, decimal>>
          {
            {'+', (first, second) => first.Value + second.Value},
            {'-', (first, second) => first.Value - second.Value},
            {'*', (first, second) => first.Value*second.Value},
            {'/', (first, second) => first.Value/second.Value}
          };

    public static implicit operator Operand(decimal value) {
      return new Operand(value);
    }

    public static implicit operator Decimal(Operand operand) {
      return operand.Value;
    }

    public decimal Value { get; private set; }

    public Operand(decimal value) {
      Value = value;
    }

    public Operand(Operand firstOperand, Operand secondOperand, char operation) {
      Value = secondOperand == null 
                    ? firstOperand.Value 
                    : _operationDefinitions[operation](firstOperand, secondOperand);
    }
  }
}