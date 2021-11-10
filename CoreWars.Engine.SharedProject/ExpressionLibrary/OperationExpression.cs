using System;

namespace CoreWars.Engine.ExpressionLibrary {
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
}
