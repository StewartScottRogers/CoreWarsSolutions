using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreWars.Engine.Library {
    internal static class ExpressionParser {

        public static short Parse(string expression) {
            Stack<char> expressionStack = new Stack<char>();
            foreach (Char c in expression.Reverse())
                expressionStack.Push(c);
            IExpression iExpression = Parse(expressionStack);
            double result = iExpression.Evaluate();
            return (short)result;
        }


        #region Private Methods
        private static IExpression Parse(Stack<char> expressionStack) {
            var left = new Stack<IExpression>();
            var expressionOperands = new Stack<ExpressionOperand>();
            var right = new Stack<IExpression>();

            while (expressionStack.Any()) {
                var c = expressionStack.Peek();

                if (char.IsDigit(c)) {
                    var parameter = ReadParameterExpression(expressionStack);
                    var expression = ParseParameterExpression(parameter);
                    if (left.Count == right.Count) {
                        left.Push(expression);
                    } else {
                        right.Push(expression);
                    }
                } else if (IsOperand(c)) {
                    var operand = ParseOperand(expressionStack.Pop());

                    if (right.Any() && (operand == ExpressionOperand.Divide || operand == ExpressionOperand.Multiply)) {
                        left.Push(right.Pop());
                    }

                    while (expressionOperands.Any() && left.Any() && right.Any()) {
                        var operationExpression = new OperationExpression(left.Pop(), expressionOperands.Pop(), right.Pop());

                        if (left.Count == right.Count) {
                            left.Push(operationExpression);
                        } else {
                            right.Push(operationExpression);
                        }
                    }

                    expressionOperands.Push(operand);
                } else if (IsOpeningBracket(c)) {
                    expressionStack.Pop();
                    var expression = Parse(expressionStack);

                    if (left.Count == right.Count) {
                        left.Push(expression);
                    } else {
                        right.Push(expression);
                    }
                } else if (IsClosingBracket(c)) {
                    expressionStack.Pop();

                    while (expressionOperands.Any()) {
                        var operationExpression = new OperationExpression(left.Pop(), expressionOperands.Pop(), right.Pop());

                        if (left.Count == right.Count) {
                            left.Push(operationExpression);
                        } else {
                            right.Push(operationExpression);
                        }
                    }

                    return left.Pop();
                } else if (char.IsWhiteSpace(c)) {
                    expressionStack.Pop();
                } else {
                    throw new NotImplementedException($"Cannot parse char '{c}'");
                }
            }


            while (expressionOperands.Any()) {
                var operationExpression = new OperationExpression(left.Pop(), expressionOperands.Pop(), right.Pop());

                if (left.Count == right.Count) {
                    left.Push(operationExpression);
                } else {
                    right.Push(operationExpression);
                }
            }

            return left.Pop();
        }

        private static bool IsOperand(char c) {
            return c == '-' || c == '+' || c == '*' || c == '/';
        }

        private static bool IsOpeningBracket(char c) {
            return c == '(';
        }

        private static bool IsClosingBracket(char c) {
            return c == ')';
        }

        private static ExpressionOperand ParseOperand(char c) {
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

        private static string ReadParameterExpression(Stack<char> expressionStack) {
            var c = expressionStack.Pop();
            var ctringBuilder = new StringBuilder();
            ctringBuilder.Append(c);

            while (expressionStack.Any()) {
                c = expressionStack.Peek();
                if (char.IsDigit(c) || c == '.') {
                    c = expressionStack.Pop();
                    ctringBuilder.Append(c);
                } else {
                    return ctringBuilder.ToString();
                }
            }

            return ctringBuilder.ToString();
        }


        private static IExpression ParseParameterExpression(string expression) {
            double value;

            if (!double.TryParse(expression, out value)) {
                throw new InvalidOperationException($"Couldn't parse expression {expression} as a double");
            }

            return new ParameterExpression(value);
        }

        #endregion

        #region Private Classes
        internal interface IExpression {
            double Evaluate();
        }

        internal enum ExpressionOperand {
            Plus,
            Minus,
            Multiply,
            Divide
        }

        internal class OperationExpression : IExpression {
            public IExpression Left { get; set; }
            public IExpression Right { get; set; }
            public ExpressionOperand Operand { get; }

            public OperationExpression(IExpression left, ExpressionOperand operand, IExpression right) {
                Operand = operand;
                Left = left;
                Right = right;
            }

            public double Evaluate() {
                switch (Operand) {
                    case ExpressionOperand.Plus:
                        return Left.Evaluate() + Right.Evaluate();
                    case ExpressionOperand.Minus:
                        return Left.Evaluate() - Right.Evaluate();
                    case ExpressionOperand.Multiply:
                        return Left.Evaluate() * Right.Evaluate();
                    case ExpressionOperand.Divide:
                        return Left.Evaluate() / Right.Evaluate();
                    default:
                        throw new NotImplementedException("Operation not supported");
                }
            }
        }

        internal class ParameterExpression : IExpression {
            public double Parameter { get; }

            public ParameterExpression(double parameter) {
                Parameter = parameter;
            }

            public double Evaluate() {
                return Parameter;
            }
        }
        #endregion 
    }
}
