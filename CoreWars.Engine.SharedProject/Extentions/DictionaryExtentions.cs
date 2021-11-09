using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoreWars.Engine.Extentions {
    internal static class DictionaryExtentions {
        public static IEnumerable<string> ToStrings(this Dictionary<string, string> dictionary) {
            var collection = new Collection<string>();

            collection.Add($"{"[Label]",-20} {"[OpcodePointer]",-20}");
            collection.Add(new string('-', 80));
            foreach (var kvp in dictionary)
                collection.Add($"{$"{kvp.Key}:",-20} {$"{kvp.Value:00000}",-20}");

            return collection;
        }
    }
}
