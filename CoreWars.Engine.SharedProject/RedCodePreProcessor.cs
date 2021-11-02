using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CoreWars.Engine {
    internal static class RedCodePreProcessor {
        public static IEnumerable<string> PreProcess(this string lines) =>
            PreProcess(Parse(lines));


        private static IEnumerable<string> PreProcess(IEnumerable<string> lines) {
            foreach (string line in lines)
                yield return line;

        }

        private static IEnumerable<string> Parse(string lines) {
            using (StringReader stringReader = new StringReader(lines)) {
                string line;
                while ((line = stringReader.ReadLine()) != null) {
                    line = line.Trim();
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
}
