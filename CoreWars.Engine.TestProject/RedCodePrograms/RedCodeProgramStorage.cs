using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CoreWars.Engine.RedCodePrograms {
    internal static class RedCodeProgramStorage {

        public static (string Name, IEnumerable<(int lineNumber, string line)> Codelines) GetExample000() => GetEmbeddedProgram("Example000.redcode");
        public static (string Name, IEnumerable<(int lineNumber, string line)> Codelines) GetExample001() => GetEmbeddedProgram("Example001.redcode");
        public static (string Name, IEnumerable<(int lineNumber, string line)> Codelines) GetExample002() => GetEmbeddedProgram("Example002.redcode");
        public static (string Name, IEnumerable<(int lineNumber, string line)> Codelines) GetExample003() => GetEmbeddedProgram("Example003.redcode");
        public static (string Name, IEnumerable<(int lineNumber, string line)> Codelines) GetExample004() => GetEmbeddedProgram("Example004.redcode");
        public static (string Name, IEnumerable<(int lineNumber, string line)> Codelines) GetExample005() => GetEmbeddedProgram("Example005.redcode");


        private static (string Name, IEnumerable<(int lineNumber, string line)> Codelines) GetEmbeddedProgram(string programName) {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"CoreWars.Engine.RedCodePrograms.{programName}.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader streamReader = new StreamReader(stream)) {
                return (Name: programName, Codelines: streamReader.ReadToEnd().ToLines());
            }
        }

        private static IEnumerable<(int lineNumber, string line)> ToLines(this string lines) {
            using (StringReader stringReader = new StringReader(lines)) {
                string line;
                int lineNumber = 1;
                while ((line = stringReader.ReadLine()) != null) {
                    line = line.Trim();
                    yield return (lineNumber: lineNumber++, line: line);
                }
            }

        }
    }
}
