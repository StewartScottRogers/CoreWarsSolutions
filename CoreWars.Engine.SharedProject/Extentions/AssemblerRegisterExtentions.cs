using System.Collections.Generic;

namespace CoreWars.Engine.Extentions {
    internal static class AssemblerRegisterExtentions {
        public static short ToRegister(this string register, Dictionary<string, string> dictionary) {
            if (dictionary.ContainsKey(register)) {
                string value = dictionary[register];
                return (short) short.Parse(value);  
            }
            short result = (short)dictionary.Parse(register);
            return result;
        }
    }
}
