using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine {
    internal static class AssemblerLabeledLineNumberExtentions {

        public static Dictionary<string, short> CreateLabeledLineNumbersDictionary(this IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {
            var labeledLineNumbersDictionary = new Dictionary<string, short>();
            try {
                foreach (var parsedCodeLine in parsedCodeLines) {

                    if (string.IsNullOrWhiteSpace(parsedCodeLine.Label))
                        continue;

                    if ("variable" == parsedCodeLine.LineType)
                        if ("equ" != parsedCodeLine.Command) {
                            if (labeledLineNumbersDictionary.ContainsKey(parsedCodeLine.Label))
                                labeledLineNumbersDictionary.Remove(parsedCodeLine.Label);
                            labeledLineNumbersDictionary.Add(parsedCodeLine.Label, parsedCodeLine.LineNumber);
                        }
                }

                return labeledLineNumbersDictionary;
            } catch (Exception exception) {
                throw new AssemblerLabledLineNumberUnplannedException("UnPlanned Exception!", exception);
            }
        }

        public static IEnumerable<string> ToStrings(this Dictionary<string, short> dictionary) {
            var collection = new Collection<string>();

            foreach (var kvp in dictionary)
                collection.Add($"{$"{kvp.Key}:",-20} {kvp.Value:00000}");

            return collection;
        }

    }
}
