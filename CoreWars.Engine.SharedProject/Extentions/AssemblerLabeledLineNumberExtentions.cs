using System;
using System.Collections.Generic;

using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine {
    internal static class AssemblerLabeledLineNumberExtentions {

        public static Dictionary<string, string> CreateLabeledLineNumbersDictionary(this IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {
            var labeledLineNumbersDictionary = new Dictionary<string, string>();
            try {
                foreach (var parsedCodeLine in parsedCodeLines) {

                    if (string.IsNullOrWhiteSpace(parsedCodeLine.Label))
                        continue;

                    if ("variable" == parsedCodeLine.LineType)
                        if ("equ" != parsedCodeLine.Command) {
                            if (labeledLineNumbersDictionary.ContainsKey(parsedCodeLine.Label))
                                labeledLineNumbersDictionary.Remove(parsedCodeLine.Label);
                            labeledLineNumbersDictionary.Add(parsedCodeLine.Label, parsedCodeLine.OpcodePointer.ToString());
                        }
                }

                return labeledLineNumbersDictionary;
            } catch (Exception exception) {
                throw new AssemblerLabledLineNumberUnplannedException("UnPlanned Exception!", exception);
            }
        }

    }
}
