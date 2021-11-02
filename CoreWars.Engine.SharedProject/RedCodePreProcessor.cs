using System.Collections.Generic;
using System.Linq;

namespace CoreWars.Engine {
    internal static class RedCodePreProcessor {

        public static IEnumerable<string> PreProcess(this IEnumerable<string> codeLines) {
            foreach (string codeLine in codeLines) {
                string line = codeLine.Trim();
                if (!string.IsNullOrWhiteSpace(line)) {
                    if (line.StartsWith("END", System.StringComparison.OrdinalIgnoreCase))
                        yield break;

                    if (!line.StartsWith(";")) {
                        string[] lineParts = line.Split(';', System.StringSplitOptions.RemoveEmptyEntries);
                        yield return lineParts.First().Trim();
                    }
                }
            }

        }

    }
}
