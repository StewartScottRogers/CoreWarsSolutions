using System;
using System.Collections.Generic;

using CoreWars.Engine.Enumerations;
using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine {
    internal static class LinterExtentions {

        private static Dictionary<String, (MnemonicTypes MnemonicType, string Mnemonic, bool ParameterRequiredA, bool ParameterRequiredB, string Description, string Example)> OpcodeDictionary
            = SymbolLibrary.OpcodeSymbols().ToSymbolsDictionary();

        private static Dictionary<String, (MnemonicTypes MnemonicType, string Mnemonic, bool ParameterRequiredA, bool ParameterRequiredB, string Description, string Example)> DirectiveDictionary
            = SymbolLibrary.DirectiveSymbols().ToSymbolsDictionary();

        private static Dictionary<String, (MnemonicTypes MnemonicType, string Mnemonic, bool ParameterRequiredA, bool ParameterRequiredB, string Description, string Example)> AddressDictionary
            = SymbolLibrary.AddressSymbols().ToSymbolsDictionary();


        public static IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            LintCodeLines(this IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> codeLines) {

            foreach (var codeLine in codeLines) {

                if (DirectiveDictionary.ContainsKey(codeLine.Command)) {

                    var symbolDirective = DirectiveDictionary[codeLine.Command];

                    if (symbolDirective.ParameterRequiredA) 
                        if (string.IsNullOrWhiteSpace(codeLine.ParameterA))
                            throw new LinterOpcodeMissingParameterAException(codeLine);

                    if (symbolDirective.ParameterRequiredB)
                        if (string.IsNullOrWhiteSpace(codeLine.ParameterB))
                            throw new LinterOpcodeMissingParameterBException(codeLine);

                    yield return codeLine;

                } else if (OpcodeDictionary.ContainsKey(codeLine.Command)) {

                    var symbolOpcode = OpcodeDictionary[codeLine.Command];

                    if (symbolOpcode.ParameterRequiredA)
                        if (string.IsNullOrWhiteSpace(codeLine.ParameterA))
                            throw new LinterDirectiveMissingParameterAException(codeLine);

                    if (symbolOpcode.ParameterRequiredB)
                        if (string.IsNullOrWhiteSpace(codeLine.ParameterB))
                            throw new LinterDirectiveMissingParameterBException(codeLine);

                    yield return codeLine;

                } else {
                    throw new LinterCommandUnknownException(codeLine);
                }
            }

        }

    }
}