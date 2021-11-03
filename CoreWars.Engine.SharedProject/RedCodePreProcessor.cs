using System.Collections.Generic;
using System.Linq;

namespace CoreWars.Engine {
    internal static class RedCodePreProcessor {

        public static IEnumerable<(int LineNumber, string Label, string Opcode, string RegisterA, string RegisterB)> ParseCodeLines(this IEnumerable<(int lineNumber, string line)> codeLines)
            => ProcessCodeLine(ProcessCodeLines(codeLines));

        public static IEnumerable<string> ToLineString(this IEnumerable<(int LineNumber, string Label, string Opcode, string RegisterA, string RegisterB)> parsedCodeLines) {
            yield return $"{"####",-6}  {"Label",-15} {"Opcode",-15} {"RegisterA",-15} {"RegisterB",-15}";
            foreach ((int LineNumber, string Label, string Opcode, string RegisterA, string RegisterB) parsedCodeLine in parsedCodeLines) {
                string lineNumber = $"{parsedCodeLine.LineNumber:0000}";
                string text = $"{lineNumber,-6}  {parsedCodeLine.Label,-15} {parsedCodeLine.Opcode,-15} {parsedCodeLine.RegisterA,-15} {parsedCodeLine.RegisterB,-15}";
                yield return text;
            }
        }

        private static IEnumerable<(int lineNumber, string line)> ProcessCodeLines(this IEnumerable<(int lineNumber, string line)> codeLines) {
            foreach ((int lineNumber, string line) codeLine in codeLines) {
                string line = codeLine.line.Trim();
                if (!string.IsNullOrWhiteSpace(line)) {

                    if (line.StartsWith("END", System.StringComparison.OrdinalIgnoreCase))
                        yield break;

                    if (!line.StartsWith(";"))
                        yield return (
                            lineNumber: codeLine.lineNumber,
                            line: codeLine.line.Split(';', System.StringSplitOptions.RemoveEmptyEntries)[0].Trim()
                        );

                }
            }
        }

        private static IEnumerable<(int LineNumber, string Label, string Opcode, string RegisterA, string RegisterB)> ProcessCodeLine(this IEnumerable<(int lineNumber, string line)> codeLines) {
            foreach ((int lineNumber, string line) codeLine in codeLines) {

                string[] lineParts
                    = codeLine.line
                                .Split(' ', System.StringSplitOptions.RemoveEmptyEntries | System.StringSplitOptions.TrimEntries)
                                    .Reverse()
                                        .ToArray();

                yield return (
                    LineNumber: codeLine.lineNumber,

                    Label: GetLinePart(lineParts, 3),
                    Opcode: GetLinePart(lineParts, 2),
                    RegisterA: GetLinePart(lineParts, 1),
                    RegisterB: GetLinePart(lineParts, 0)
               );

            }
        }

        private static string GetLinePart(string[] lineParts, int index) {
            if (lineParts.Length > index) {
                string linePart = lineParts[index];
                if (linePart.EndsWith(","))
                    linePart = linePart.Substring(0, linePart.LastIndexOf(","));
                return linePart;
            }

            return string.Empty;
        }

    }
}
