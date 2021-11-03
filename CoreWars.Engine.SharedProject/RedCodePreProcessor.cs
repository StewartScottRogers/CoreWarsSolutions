using System.Collections.Generic;
using System.Linq;

namespace CoreWars.Engine {
    internal static class RedCodePreProcessor {

        public static IEnumerable<(int lineNumber, string line)> PreProcess(this IEnumerable<(int lineNumber, string line)> codeLines) {
            foreach ((int lineNumber, string line) codeLine in codeLines) {
                string line = codeLine.line.Trim();
                if (!string.IsNullOrWhiteSpace(line)) {
                    if (line.StartsWith("END", System.StringComparison.OrdinalIgnoreCase))
                        yield break;

                    if (!line.StartsWith(";")) 
                        yield return codeLine;
                    
                }
            }

        }

    }
}
