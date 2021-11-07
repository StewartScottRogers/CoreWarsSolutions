using System.Collections.Generic;
using System.IO;

namespace CoreWars.Engine.Extentions {
    internal static class LinesExtentions {
        public static IEnumerable<(short lineNumber, string line)> ToLines(this string lines) {
            using StringReader stringReader = new StringReader(lines);
            string line;
            short lineNumber = 1;
            while ((line = stringReader.ReadLine()) != null)
                yield return (lineNumber: lineNumber++, line: line);

        }
    }
}
