using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CoreWars.Engine.RedCodePrograms {
    internal static class RedCodeProgramStorage {

        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample000() => GetEmbeddedProgram("Example000.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample001() => GetEmbeddedProgram("Example001.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample002() => GetEmbeddedProgram("Example002.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample003() => GetEmbeddedProgram("Example003.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample004() => GetEmbeddedProgram("Example004.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample005() => GetEmbeddedProgram("Example005.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample006() => GetEmbeddedProgram("Example006.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample007() => GetEmbeddedProgram("Example007.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample008() => GetEmbeddedProgram("Example008.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample009() => GetEmbeddedProgram("Example009.redcode");

        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample010() => GetEmbeddedProgram("Example010.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample011() => GetEmbeddedProgram("Example011.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample012() => GetEmbeddedProgram("Example012.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample013() => GetEmbeddedProgram("Example013.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample014() => GetEmbeddedProgram("Example014.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample015() => GetEmbeddedProgram("Example015.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample016() => GetEmbeddedProgram("Example016.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample017() => GetEmbeddedProgram("Example017.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample018() => GetEmbeddedProgram("Example018.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample019() => GetEmbeddedProgram("Example019.redcode");
        public static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetExample020() => GetEmbeddedProgram("Example020.redcode");


        private static (string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) GetEmbeddedProgram(string programName) {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"CoreWars.Engine.RedCodeSamples.{programName}.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader streamReader = new StreamReader(stream)) {
                string content = streamReader.ReadToEnd();
                return (Name: programName, Cotent: content, Codelines: content.ToLines());
            }
        }

        private static IEnumerable<(int lineNumber, string line)> ToLines(this string lines) {
            using (StringReader stringReader = new StringReader(lines)) {
                string line;
                int lineNumber = 1;
                while ((line = stringReader.ReadLine()) != null)
                    yield return (lineNumber: lineNumber++, line: line);
            }

        }
    }
}
