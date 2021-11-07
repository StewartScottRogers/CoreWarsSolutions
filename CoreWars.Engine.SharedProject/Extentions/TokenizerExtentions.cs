using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreWars.Engine {
    internal static class TokenizerExtentions {

        public static IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            ParseCodeLines(this IEnumerable<(short lineNumber, string line)> codeLines)
            => ProcessCodeLine(ProcessCodeLines(codeLines));

        public static IEnumerable<string>
            ToStrings(this IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {

            yield return $"{"[Type]",-10} {"[####]",-8} {"[Label]",-15} {"[Command]",-15} {"[ParameterA]",-20} {"[ParameterB]",-20}";

            foreach ((short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) parsedCodeLine in parsedCodeLines) {
                string lineNumber = $"{parsedCodeLine.LineNumber:0000}";
                string text = $"{parsedCodeLine.LineType,-10} {lineNumber,-8} {parsedCodeLine.Label,-15} {parsedCodeLine.Command,-15} {parsedCodeLine.ParameterA,-20} {parsedCodeLine.ParameterB,-20}";
                yield return text;
            }
        }

        public static Dictionary<string, short> CreateLabeledLineNumbersDictionary(this IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {
            var labeledLineNumbersDictionary = new Dictionary<string, short>();
            try {
                foreach (var parsedCodeLine in parsedCodeLines) {

                    if (string.IsNullOrWhiteSpace(parsedCodeLine.Label))
                        continue;

                    if ("label" == parsedCodeLine.LineType) {
                        if(labeledLineNumbersDictionary.ContainsKey(parsedCodeLine.Label))
                            labeledLineNumbersDictionary.Remove(parsedCodeLine.Label);
                        labeledLineNumbersDictionary.Add(parsedCodeLine.Label, parsedCodeLine.LineNumber);

                    }
                }

                return labeledLineNumbersDictionary;
            } catch (Exception exception) {
                throw exception;
            }
        }

        public static Dictionary<string, string> CreateLabledValuePairDictionary(this IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {
            var labledValuePairDictionary = new Dictionary<string, string>();
            try {
                foreach (var parsedCodeLine in parsedCodeLines)
                    if ("variable" == parsedCodeLine.LineType)
                        if ("equ" == parsedCodeLine.Command) {
                            if (labledValuePairDictionary.ContainsKey(parsedCodeLine.Label))
                                labledValuePairDictionary.Remove(parsedCodeLine.Label);
                            labledValuePairDictionary.Add(parsedCodeLine.Label, parsedCodeLine.ParameterA);
                        }

                return labledValuePairDictionary;
            } catch (Exception exception) {
                throw exception;
            }
        }

        #region Private Methods
        private static IEnumerable<(short lineNumber, string LineType, string line)>
            ProcessCodeLines(this IEnumerable<(short lineNumber, string line)> codeLines) {
            foreach ((short lineNumber, string line) codeLine in codeLines) {
                string line = codeLine.line;
                string timmedLine = line.Trim();

                if (!string.IsNullOrWhiteSpace(line)) {

                    if (timmedLine.StartsWith("END", System.StringComparison.OrdinalIgnoreCase))
                        yield break;

                    if (timmedLine.StartsWith(";"))
                        continue;

                    string lineType = "variable";
                    if (line.StartsWith(" ") || line.StartsWith("\t"))
                        lineType = "";

                    yield return (
                        lineNumber: codeLine.lineNumber,
                        LineType: lineType,
                        line: timmedLine.Split(';', System.StringSplitOptions.RemoveEmptyEntries)[0]
                    );

                }
            }
        }

        private static IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            ProcessCodeLine(this IEnumerable<(short lineNumber, string lineType, string line)> codeLines) {
            foreach ((short lineNumber, string LineType, string line) codeLine in codeLines) {

                string line = codeLine.line.Replace(",", " ").Replace("\t", "    ");

                string[] lineParts
                    = line
                        .Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
                            .Reverse()
                                .ToArray();


                bool isLabled = ("variable" == codeLine.LineType);
                if (isLabled) {

                    if (lineParts.Length == 4) {

                        var result = (
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.LineType,

                                        Label: GetLinePart(lineParts, 3),
                                        Command: GetLinePart(lineParts, 2).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 1),
                                        ParameterB: GetLinePart(lineParts, 0)
                                     );

                        yield return result;

                    } else if (lineParts.Length == 3) {

                        var result = (
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.LineType,

                                        Label: GetLinePart(lineParts, 2),
                                        Command: GetLinePart(lineParts, 1).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 0),
                                        ParameterB: string.Empty
                                     );

                        yield return result;

                    } else if (lineParts.Length == 2) {

                        var result = (
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.LineType,

                                        Label: GetLinePart(lineParts, 2),
                                        Command: GetLinePart(lineParts, 1).ToLower(),
                                        ParameterA: string.Empty,
                                        ParameterB: string.Empty
                                     );

                        yield return result;

                    }

                } else {

                    if (lineParts.Length == 3) {

                        var result = (
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.LineType,

                                          Label: string.Empty,
                                        Command: GetLinePart(lineParts, 2).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 1),
                                        ParameterB: GetLinePart(lineParts, 0)
                                     );

                        yield return result;

                    } else if (lineParts.Length == 2) {

                        var result = (
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.LineType,

                                        Label: string.Empty,
                                        Command: GetLinePart(lineParts, 1).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 0),
                                        ParameterB: string.Empty
                                     );

                        yield return result;

                    } else if (lineParts.Length == 1) {

                        var result = (
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.LineType,

                                        Label: string.Empty,
                                        Command: GetLinePart(lineParts, 0).ToLower(),
                                        ParameterA: string.Empty,
                                        ParameterB: string.Empty
                                     );

                        yield return result;

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
        #endregion
    }
}
