﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine {
    internal static class AssemblerLabledVariableExtentions {

        public static Dictionary<string, string> CreateLabledVariableDictionary(this IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines) {
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
                throw new AssemblerLabledVariableUnplannedException("UnPlanned Exception!", exception);
            }
        }

        public static IEnumerable<string> ToStrings(this Dictionary<string, string> dictionary) {
            var collection = new Collection<string>();

            foreach (var kvp in dictionary)
                collection.Add($"{$"{kvp.Key}:",-20} '{kvp.Value}'");

            return collection;
        }

    }
}
