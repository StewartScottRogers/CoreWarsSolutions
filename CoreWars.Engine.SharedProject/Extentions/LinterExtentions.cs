using System;
using System.Collections.Generic;

using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine {
    internal static class LinterExtentions {


        public static IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)>
            LintCodeLines(this IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> codeLines) {

            Dictionary<String, (String MnemonicType, String Mnemonic, String Description, String Example)> opcodeDictionary 
                = SymbolLibrary.OpcodeSymbols().ToSymbolsDictionary();

            Dictionary<String, (String MnemonicType, String Mnemonic, String Description, String Example)> addressDictionary 
                = SymbolLibrary.AddressSymbols().ToSymbolsDictionary();

            Dictionary<String, (String MnemonicType, String Mnemonic, String Description, String Example)> directiveDictionary 
                = SymbolLibrary.DirectiveSymbols().ToSymbolsDictionary();


            foreach ((Int32 LineNumber, String LineType, String Label, String Command, String ParameterA, String ParameterB) codeLine in codeLines) {






                yield return codeLine;
            }

        }

    }
}