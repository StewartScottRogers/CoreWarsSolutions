using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CoreWars.Engine.Attributes;
using CoreWars.Engine.Attributes.Library;
using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine {
    internal static class SymbolLibrary {

        public static IEnumerable<(string Mnemonic, string Description, string Example)> Symbols() {
            foreach (var symbol in OpcodeTypes())
                yield return symbol;

            foreach (var symbol in AddressTypes())
                yield return symbol;

            foreach (var symbol in DirectiveTypes())
                yield return symbol;
        }

        public static IEnumerable<(string Mnemonic, string Description, string Example)> OpcodeTypes() {
            OpcodeTypes[] opcodeTypes = Enum.GetValues(typeof(OpcodeTypes)).Cast<OpcodeTypes>().ToArray();
            foreach (OpcodeTypes opcodeType in opcodeTypes) {
                SymbolAttribute symbolAttribute = opcodeType.GetSymbol();
                if (symbolAttribute.MnemonicEnabled)
                    yield return (
                                    Mnemonic: symbolAttribute.Mnemonic,
                                    Description: symbolAttribute.Description,
                                    Example: symbolAttribute.Example
                                 );
            }
        }

        public static IEnumerable<(string Mnemonic, string Description, string Example)> AddressTypes() {
            AddressTypes[] addressTypes = Enum.GetValues(typeof(AddressTypes)).Cast<AddressTypes>().ToArray();
            foreach (AddressTypes addressType in addressTypes) {
                SymbolAttribute symbolAttribute = addressType.GetSymbol();
                if (symbolAttribute.MnemonicEnabled)
                    yield return (
                                    Mnemonic: symbolAttribute.Mnemonic,
                                    Description: symbolAttribute.Description,
                                    Example: symbolAttribute.Example
                                 );
            }
        }

        public static IEnumerable<(string Mnemonic, string Description, string Example)> DirectiveTypes() {
            DirectiveTypes[] directiveTypes = Enum.GetValues(typeof(DirectiveTypes)).Cast<DirectiveTypes>().ToArray();
            foreach (DirectiveTypes directiveType in directiveTypes) {
                SymbolAttribute symbolAttribute = directiveType.GetSymbol();
                if (symbolAttribute.MnemonicEnabled)
                    yield return (
                                    Mnemonic: symbolAttribute.Mnemonic,
                                    Description: symbolAttribute.Description,
                                    Example: symbolAttribute.Example
                                 );
            }
        }

        public static IEnumerable<string> ToStrings(this IEnumerable<(string Mnemonic, string Description, string Example)> symbols) {

            StringBuilder stringBuilderPre = new();

            stringBuilderPre.AppendLine(new string('#', 80));
            stringBuilderPre.AppendLine($"Symbol Library: Provides services to the Linter, Assembler, and the end user documentation.");
            stringBuilderPre.AppendLine(new string('#', 80));
            stringBuilderPre.AppendLine($"");

            yield return stringBuilderPre.ToString().Trim();

            foreach ((String Mnemonic, String Description, String Example) symbol in symbols) {

                StringBuilder stringBuilderSymbol = new();

                stringBuilderSymbol.AppendLine(new string('=', 80));
                stringBuilderSymbol.AppendLine($"Mnemonic:    {symbol.Mnemonic}");
                stringBuilderSymbol.AppendLine(new string('-', 80));
                stringBuilderSymbol.AppendLine($"Description: {symbol.Description}");
                stringBuilderSymbol.AppendLine($"Example:     {symbol.Example}");

                yield return stringBuilderSymbol.ToString().Trim();
            }


            StringBuilder stringBuilderPost = new();

            stringBuilderPost.AppendLine(new string('=', 80));

            yield return stringBuilderPost.ToString().Trim();

        }
    }
}
