using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreWars.Engine.ExpressionLibrary {
    internal class ExpressionParser {
        private readonly Stack<char> _expression = new Stack<char>();

        public ExpressionParser(string expression) {
            foreach (Char c in expression.Reverse())
                _expression.Push(c);
        }

        public IExpression Parse() {
            var left = new Stack<IExpression>();
            var expressionOperands = new Stack<ExpressionOperand>();
            var right = new Stack<IExpression>();

            while (HasMoreChars) {
                var c = _expression.Peek();

                if (char.IsDigit(c)) {
                    var parameter = ReadParameterExpression();
                    var expression = ParseParameterExpression(parameter);
                    if (left.Count == right.Count) {
                        left.Push(expression);
                    } else {
                        right.Push(expression);
                    }
                } else if (IsOperand(c)) {
                    var operand = ParseOperand(_expression.Pop());

                    if (right.Any() && (operand == ExpressionOperand.Divide || operand == ExpressionOperand.Multiply)) {
                        left.Push(right.Pop());
                    }

                    while (expressionOperands.Any() && left.Any() && right.Any()) {
                        var expression = new OperationExpression(left.Pop(), expressionOperands.Pop(), right.Pop());

                        if (left.Count == right.Count) {
                            left.Push(expression);
                        } else {
                            right.Push(expression);
                        }
                    }

                    expressionOperands.Push(operand);
                } else if (IsOpeningBracket(c)) {
                    _expression.Pop();
                    var expression = Parse();

                    if (left.Count == right.Count) {
                        left.Push(expression);
                    } else {
                        right.Push(expression);
                    }
                } else if (IsClosingBracket(c)) {
                    _expression.Pop();

                    while (expressionOperands.Any()) {
                        var expression = new OperationExpression(left.Pop(), expressionOperands.Pop(), right.Pop());

                        if (left.Count == right.Count) {
                            left.Push(expression);
                        } else {
                            right.Push(expression);
                        }
                    }

                    return left.Pop();
                } else if (char.IsWhiteSpace(c)) {
                    _expression.Pop();
                } else {
                    throw new NotImplementedException($"Cannot parse char '{c}'");
                }
            }


            while (expressionOperands.Any()) {
                var expression = new OperationExpression(left.Pop(), expressionOperands.Pop(), right.Pop());

                if (left.Count == right.Count) {
                    left.Push(expression);
                } else {
                    right.Push(expression);
                }
            }

            return left.Pop();
        }

        internal static bool IsOperand(char c) {
            return c == '-' || c == '+' || c == '*' || c == '/';
        }

        internal static bool IsOpeningBracket(char c) {
            return c == '(';
        }

        internal static bool IsClosingBracket(char c) {
            return c == ')';
        }

        internal ExpressionOperand ParseOperand(char c) {
            switch (c) {
                case '-':
                    return ExpressionOperand.Minus;
                case '+':
                    return ExpressionOperand.Plus;
                case '/':
                    return ExpressionOperand.Divide;
                case '*':
                    return ExpressionOperand.Multiply;
                default:
                    throw new NotImplementedException($"Cannot parse {c} as an operand");
            }
        }

        internal string ReadParameterExpression() {
            var c = _expression.Pop();
            var expression = new StringBuilder();
            expression.Append(c);

            while (HasMoreChars) {
                c = _expression.Peek();
                if (char.IsDigit(c) || c == '.') {
                    c = _expression.Pop();
                    expression.Append(c);
                } else {
                    return expression.ToString();
                }
            }

            return expression.ToString();
        }

        private bool HasMoreChars => _expression.Any();

        internal IExpression ParseParameterExpression(string expression) {
            double value;

            if (!double.TryParse(expression, out value)) {
                throw new InvalidOperationException($"Couldn't parse expression {expression} as a double");
            }

            return new ParameterExpression(value);
        }
    }
}
