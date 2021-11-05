using System;
using System.Collections.Generic;

using CoreWars.Engine.Enumerations;
using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine {
    internal static class LinterExtentions {

        private static Dictionary<String, (MnemonicTypes MnemonicType, String Mnemonic, String Description, String Example)> OpcodeDictionary
               = SymbolLibrary.OpcodeSymbols().ToSymbolsDictionary();

        private static Dictionary<String, (MnemonicTypes MnemonicType, String Mnemonic, String Description, String Example)> DirectiveDictionary
            = SymbolLibrary.DirectiveSymbols().ToSymbolsDictionary();

        private static Dictionary<String, (MnemonicTypes MnemonicType, String Mnemonic, String Description, String Example)> AddressDictionary
            = SymbolLibrary.AddressSymbols().ToSymbolsDictionary();


        public static IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            LintCodeLines(this IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> codeLines) {

            foreach ((Int32 LineNumber, String LineType, String Label, String Command, String ParameterA, String ParameterB) codeLine in codeLines) {

                if (DirectiveDictionary.ContainsKey(codeLine.Command)) {


                    yield return codeLine;
                } else if (OpcodeDictionary.ContainsKey(codeLine.Command)) {


                    yield return codeLine;
                } else {
                    throw new LinterUnknownCommandException(codeLine);
                }
            }

        }

    }
}