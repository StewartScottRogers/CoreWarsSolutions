using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CoreWars.Engine.ExpressionLibrary;

namespace CoreWars.Engine.Extentions {
    internal static class ExpressionExtentions {
        public static short Parse(this Dictionary<string, string> labledValuePairDictionary, string expression) {
            var keys = labledValuePairDictionary.Keys.OrderBy(x => x.Length);
            foreach (string key in keys)
                expression = expression.Replace(key, labledValuePairDictionary[key]);

            ExpressionParser expressionParser = new ExpressionParser(expression);
            double evaluation = expressionParser.Parse().Evaluate();
            short result = Convert.ToInt16(evaluation);
            return result;
        }  
    }
}

