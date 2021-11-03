using System.Collections.Generic;
using System.Linq;

namespace CoreWars.Engine {
    internal static class RedCodeTokenizer {

        public static IEnumerable<(int LineNumber, string Label, string Command, string ParameterA, string ParameterB)> ParseCodeLines(this IEnumerable<(int lineNumber, string line)> codeLines)
            => ProcessCodeLine(ProcessCodeLines(codeLines));

        public static IEnumerable<string> ToLineString(this IEnumerable<(int LineNumber, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {
            yield return $"{"[####]",-6}  {"[Label]",-15} {"[Command]",-15} {"[ParameterA]",-15} {"[ParameterB]",-15}";
            foreach ((int LineNumber, string Label, string Command, string ParameterA, string ParameterB) parsedCodeLine in parsedCodeLines) {
                string lineNumber = $"{parsedCodeLine.LineNumber:0000}";
                string text = $" {lineNumber,-6}  {parsedCodeLine.Label,-15} {parsedCodeLine.Command,-15} {parsedCodeLine.ParameterA,-15} {parsedCodeLine.ParameterB,-15}";
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
                            line: codeLine.line.Split(';', System.StringSplitOptions.RemoveEmptyEntries)[0]
                        );

                }
            }
        }

        private static IEnumerable<(int LineNumber, string Label, string Command, string ParameterA, string ParameterB)> ProcessCodeLine(this IEnumerable<(int lineNumber, string line)> codeLines) {
            foreach ((int lineNumber, string line) codeLine in codeLines) {
                bool startsWithBlankSpace = codeLine.line.StartsWith(" ");
                

                string[] lineParts
                                     = codeLine.line
                                                 .Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
                                                     .Reverse()
                                                         .ToArray();

                if (startsWithBlankSpace) {
                   
                    yield return (
                        LineNumber: codeLine.lineNumber,

                        Label: GetLinePart(lineParts, 3),
                        Command: GetLinePart(lineParts, 2),
                        ParameterA: GetLinePart(lineParts, 1),
                        ParameterB: GetLinePart(lineParts, 0)
                   );
                } else {
                    bool assignmentEQU = GetLinePart(lineParts, 1).ToUpper() == nameof(RedCodeSpecialCommands.EQU);

                    if (assignmentEQU) {
                        yield return (
                            LineNumber: codeLine.lineNumber,

                            Label: string.Empty,
                            Command: GetLinePart(lineParts, 1),
                            ParameterA: GetLinePart(lineParts, 0),
                            ParameterB: GetLinePart(lineParts, 2)
                       );
                    } else {
                        yield return (
                            LineNumber: codeLine.lineNumber,

                            Label: GetLinePart(lineParts, 3),
                            Command: GetLinePart(lineParts, 2),
                            ParameterA: GetLinePart(lineParts, 1),
                            ParameterB: GetLinePart(lineParts, 0)
                        );
                    }

                 
                }
            }
        }

        private static string GetLinePart(string[] lineParts, int index) {
            if (lineParts.Length > index) {
                string linePart = lineParts[index].Trim();
                if (linePart.EndsWith(","))
                    linePart = linePart.Substring(0, linePart.LastIndexOf(","));
                return linePart;
            }

            return string.Empty;
        }

    }
}
