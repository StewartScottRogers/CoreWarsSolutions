using System.Collections.Generic;

namespace CoreWars.Engine {
    internal static class LinterExtentions {


        public static IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            LintCodeLines(this IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> codeLines) {

            foreach (var codeLine in codeLines) {
                yield return codeLine;
            }

        }
    }
}
