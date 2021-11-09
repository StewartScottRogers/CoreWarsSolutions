using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWars.Engine.Extentions {
    internal static class ExpressionExtentions {
        public static short Parse(this Dictionary<string, string> labledValuePairDictionary, string expression) {

            return 0;
        }

        // #1
        /// ExpressionParser p = new ExpressionParser();
        /// Map vars = new HashMap<String, Double>();
        /// vars.put("x", 2.50);
        /// var result = p.eval(" 5 + 6 * x - 1", vars);
        /// System.out.println(result);


        // #2
        // ExpressionParser parser = new ExpressionParser();
        // parser.Values.Add("x", 2);
        // parser.Values.Add("y", 10);

        // // Parse once
        // string func = "x^3+5x^2-3";
        // parser.Parse(func);
        // // Fetch expression
        // Expression expression = parser.Expressions[func];

        // // Evaluate saved expression
        // double result = parser.EvalExpression(expression);

    }
}
