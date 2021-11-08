using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreWars.Engine {
    internal static class TokenizerExtentions {

        public static IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            ParseCodeLines(this IEnumerable<(short lineNumber, string line)> codeLines) {
            IEnumerable<(short opcodePointer, short lineNumber, string LineType, string Line)> processedCodeLines 
                = ProcessCodeLines(codeLines);
            return ProcessCodeLine(processedCodeLines);
        }

        public static IEnumerable<string>
            ToStrings(this IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {

            yield return $"{"[Type]",-10} {"[Line]",-8} {"[Label]",-15} {"[Pointer]",-15} {"[Command]",-15} {"[ParameterA]",-20} {"[ParameterB]",-20}";

            foreach ((short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB) parsedCodeLine in parsedCodeLines) {
                string lineNumber = $"{parsedCodeLine.LineNumber:0000}";
                string opcodePointer = $"{parsedCodeLine.OpcodePointer:0000}";
                string text = $"{parsedCodeLine.LineType,-10} {lineNumber,-8} {parsedCodeLine.Label,-15} {opcodePointer,-15} {parsedCodeLine.Command,-15} {parsedCodeLine.ParameterA,-20} {parsedCodeLine.ParameterB,-20}";
                yield return text;
            }
        }

        #region Private Methods
        private static IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string line)>
            ProcessCodeLines(this IEnumerable<(short lineNumber, string line)> codeLines) {

            short opcodePointer = 0;

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
                        OpcodePointer: opcodePointer++,
                        LineNumber: codeLine.lineNumber,
                        LineType: lineType,
                        line: timmedLine.Split(';', System.StringSplitOptions.RemoveEmptyEntries)[0]
                    );

                }
            }
        }

        private static IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            ProcessCodeLine(this IEnumerable<(short opcodePointer, short lineNumber, string lineType, string line)> codeLines) {

            foreach ((short opcodePointer, short lineNumber, string lineType, string line) codeLine in codeLines) {

                string line = codeLine.line.Replace(",", " ").Replace("\t", "    ");

                string[] lineParts
                    = line
                        .Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
                            .Reverse()
                                .ToArray();


                bool isLabled = ("variable" == codeLine.lineType);
                if (isLabled) {

                    if (lineParts.Length == 4) {

                        var result = (
                                        OpcodePointer: codeLine.opcodePointer,
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.lineType,

                                        Label: GetLinePart(lineParts, 3),
                                        Command: GetLinePart(lineParts, 2).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 1),
                                        ParameterB: GetLinePart(lineParts, 0)
                                     );

                        yield return result;

                    } else if (lineParts.Length == 3) {

                        var result = (
                                        OpcodePointer: codeLine.opcodePointer,
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.lineType,

                                        Label: GetLinePart(lineParts, 2),
                                        Command: GetLinePart(lineParts, 1).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 0),
                                        ParameterB: string.Empty
                                     );

                        yield return result;

                    } else if (lineParts.Length == 2) {

                        var result = (
                                        OpcodePointer: codeLine.opcodePointer,
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.lineType,

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
                                        OpcodePointer: codeLine.opcodePointer,
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.lineType,

                                        Label: string.Empty,
                                        Command: GetLinePart(lineParts, 2).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 1),
                                        ParameterB: GetLinePart(lineParts, 0)
                                     );

                        yield return result;

                    } else if (lineParts.Length == 2) {

                        var result = (
                                        OpcodePointer: codeLine.opcodePointer,
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.lineType,

                                        Label: string.Empty,
                                        Command: GetLinePart(lineParts, 1).ToLower(),
                                        ParameterA: GetLinePart(lineParts, 0),
                                        ParameterB: string.Empty
                                     );

                        yield return result;

                    } else if (lineParts.Length == 1) {

                        var result = (
                                        OpcodePointer: codeLine.opcodePointer,
                                        LineNumber: codeLine.lineNumber,
                                        LineType: codeLine.lineType,

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
