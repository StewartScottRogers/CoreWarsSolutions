using System;
using System.Linq;

using CoreWars.Engine.Attributes;
using CoreWars.Engine.Enumerations;
using CoreWars.Engine.Extentions.Exceptions;

namespace CoreWars.Engine.Extentions {
    internal static class AssemblerAddressExtentions {
        public static (AddressTypes AddressType, string Value) ToAddressType(this string register) {
            var registerTrimmed = register.Trim();
            string firstOrDefault = registerTrimmed.ToCharArray().FirstOrDefault().ToString();
            string remainingOrDefault = string.Empty;
            if (firstOrDefault.Length > 0)
                remainingOrDefault = registerTrimmed.Substring(firstOrDefault.Length);

            AddressTypes[] addressTypes = Enum.GetValues(typeof(AddressTypes)).Cast<AddressTypes>().ToArray();
            foreach (AddressTypes addressType in addressTypes) {
                SymbolAttribute symbolAttribute = addressType.GetSymbol();
                if (!symbolAttribute.MnemonicEnabled)
                    continue;


                switch (addressType) {
                    case AddressTypes.Immediate: {
                            if (firstOrDefault == symbolAttribute.Mnemonic)
                                return (AddressTypes.Immediate, remainingOrDefault);
                            break;
                        }


                    case AddressTypes.Direct: {
                            if (firstOrDefault == symbolAttribute.Mnemonic)
                                return (AddressTypes.Direct, remainingOrDefault);
                            break;
                        }
                    case AddressTypes.Default: {
                            if (
                                  firstOrDefault != "$"
                                ||
                                  firstOrDefault != "#"
                                )
                                break;

                            return (AddressTypes.Direct, registerTrimmed); // Direct is not a mistake.                            
                        }
                    default: {
                            break;
                        }

                }

            }

            throw new AssemblerAddressExceptionException("No Memmory Address Types enabled.");

        }


    }
}
