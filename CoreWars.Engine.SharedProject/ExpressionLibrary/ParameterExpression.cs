namespace CoreWars.Engine.ExpressionLibrary {
    internal class ParameterExpression : IExpression {
        public double Parameter { get; }

        public ParameterExpression(double parameter) {
            Parameter = parameter;
        }

        public double Evaluate() {
            return Parameter;
        }
    }
}
