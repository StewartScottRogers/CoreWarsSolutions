using System;
using System.Linq;
using System.Reflection;

using CoreWars.Engine.Attributes.Library;
using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Attributes {

    internal static class SymbolAttributeExtentions {

        public static SymbolAttribute GetSymbol(this AddressTypes value) => GetSymbolAttribute(value);
        public static SymbolAttribute GetSymbol(this OpcodeTypes value) => GetSymbolAttribute(value);
        public static SymbolAttribute GetSymbol(this DirectiveTypes value) => GetSymbolAttribute(value);


        private static SymbolAttribute GetSymbolAttribute(Enum value) {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            SymbolAttribute[] symbolAttribute
                = fieldInfo.GetCustomAttributes(typeof(SymbolAttribute), false) as SymbolAttribute[];

            if (symbolAttribute != null && symbolAttribute.Any())
                return symbolAttribute.First();

            return new SymbolAttribute(mnemonicEnabled: false, mnemonic: "", description: "NO ATTRIBUTE FOUND ON ENUM!", example: ""); ;
        }
    }
}
