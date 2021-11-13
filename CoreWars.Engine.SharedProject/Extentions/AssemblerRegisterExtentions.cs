using System.Collections.Generic;

using CoreWars.Engine.Enumerations;

namespace CoreWars.Engine.Extentions {
    internal static class AssemblerRegisterExtentions {
        public static (AddressTypes AddressType, short Result) ToRegister(this string register, Dictionary<string, string> dictionary) {
            if (dictionary.ContainsKey(register)) {
                string value = dictionary[register];
                short parsedResult = (short)short.Parse(value);
                return (AddressTypes.Direct, parsedResult);
            }

            (AddressTypes AddressType, string Value) = register.ToAddressType();
            short result = (short)dictionary.Parse(Value);
            return (AddressType, result);
        }
    }
}
