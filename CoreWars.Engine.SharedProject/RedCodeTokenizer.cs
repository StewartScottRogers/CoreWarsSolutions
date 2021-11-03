using System.Collections.Generic;
using System.Linq;

namespace CoreWars.Engine {
    internal static class RedCodeTokenizer {

        public static IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> ParseCodeLines(this IEnumerable<(int lineNumber, string line)> codeLines)
            => ProcessCodeLine(ProcessCodeLines(codeLines));

        public static IEnumerable<string> ToStrings(this IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {

            yield return $"{"[Type]",-10} {"[####]",-8} {"[Label]",-15} {"[Command]",-15} {"[ParameterA]",-15} {"[ParameterB]",-15}";

            foreach ((int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) parsedCodeLine in parsedCodeLines) {
                string lineNumber = $"{parsedCodeLine.LineNumber:0000}";
                string text = $"{parsedCodeLine.LineType,-10} {lineNumber,-8} {parsedCodeLine.Label,-15} {parsedCodeLine.Command,-15} {parsedCodeLine.ParameterA,-15} {parsedCodeLine.ParameterB,-15}";
                yield return text;
            }
        }

        private static IEnumerable<(int lineNumber, string LineType, string line)> ProcessCodeLines(this IEnumerable<(int lineNumber, string line)> codeLines) {
            foreach ((int lineNumber, string line) codeLine in codeLines) {
                string line = codeLine.line;
                string timmedLine = line.Trim();

                if (!string.IsNullOrWhiteSpace(line)) {

                    if (timmedLine.StartsWith("END", System.StringComparison.OrdinalIgnoreCase))
                        yield break;

                    if (timmedLine.StartsWith(";"))
                        continue;

                    string lineType = "labled";
                    if (line.StartsWith(" "))
                        lineType = "";

                    yield return (
                        lineNumber: codeLine.lineNumber,
                        LineType: lineType,
                        line: timmedLine.Split(';', System.StringSplitOptions.RemoveEmptyEntries)[0]
                    );

                }
            }
        }

        private static IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> ProcessCodeLine(this IEnumerable<(int lineNumber, string lineType, string line)> codeLines) {
            foreach ((int lineNumber, string LineType, string line) codeLine in codeLines) {

                string[] lineParts
                    = codeLine.line
                                .Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
                                    .Reverse()
                                        .ToArray();

                int linePartCount = lineParts.Length;


                if (linePartCount <= 1) {

                    var result = (
                                    LineNumber: codeLine.lineNumber,
                                    LineType: codeLine.LineType,

                                    Label: string.Empty,
                                    Command: GetLinePart(lineParts, 0),
                                    ParameterA: string.Empty,
                                    ParameterB: string.Empty
                                );

                    yield return result;
                } else {

                    bool assignmentEQU = GetLinePart(lineParts, 1).ToUpper() == nameof(RedCodeSpecialCommands.EQU);

                    if (assignmentEQU) {
                        if (linePartCount <= 3) {

                            var result = (
                                            LineNumber: codeLine.lineNumber,
                                            LineType: codeLine.LineType,

                                            Label: string.Empty,
                                            Command: GetLinePart(lineParts, 1),
                                            ParameterA: GetLinePart(lineParts, 0),
                                            ParameterB: GetLinePart(lineParts, 2)
                                        );

                            yield return result;
                        } else {

                            var result = (
                                              LineNumber: codeLine.lineNumber,
                                              LineType: codeLine.LineType,

                                              Label: string.Empty,
                                              Command: GetLinePart(lineParts, 1),
                                              ParameterA: GetLinePart(lineParts, 0),
                                              ParameterB: GetLinePart(lineParts, 2)
                                         );

                            yield return result;
                        }
                    } else {
                        if (linePartCount <= 2) {

                            var result = (
                                            LineNumber: codeLine.lineNumber,
                                            LineType: codeLine.LineType,

                                            Label: string.Empty,
                                            Command: GetLinePart(lineParts, 1),
                                            ParameterA: GetLinePart(lineParts, 0),
                                            ParameterB: string.Empty
                                        );

                            yield return result;
                        } else {

                            var result = (
                                           LineNumber: codeLine.lineNumber,
                                           LineType: codeLine.LineType,

                                           Label: GetLinePart(lineParts, 3),
                                           Command: GetLinePart(lineParts, 2),
                                           ParameterA: GetLinePart(lineParts, 1),
                                           ParameterB: GetLinePart(lineParts, 0)
                                         );

                            yield return result;
                        }
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
