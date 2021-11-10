using System;
using System.Collections.Generic;
using System.Linq;

using CoreWars.Engine.Library;

namespace CoreWars.Engine.Extentions {
    internal static class ExpressionExtentions {
        public static short Parse(this Dictionary<string, string> labledValuePairDictionary, string expression) {
            var keys = labledValuePairDictionary.Keys.OrderBy(x => x.Length);
            foreach (string key in keys)
                expression = expression.Replace(key, labledValuePairDictionary[key]);

            short result = ExpressionParser.Parse(expression);
            return result;
        }  
    }
}

