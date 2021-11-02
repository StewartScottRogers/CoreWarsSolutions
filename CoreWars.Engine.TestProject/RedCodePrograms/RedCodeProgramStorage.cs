using System.IO;
using System.Reflection;

namespace CoreWars.Engine.RedCodePrograms {
    internal static class RedCodeProgramStorage {

        public static (string Name, string Code) GetExample000() => GetEmbeddedProgram("Example000.redcode");
        public static (string Name, string Code) GetExample001() => GetEmbeddedProgram("Example001.redcode");
        public static (string Name, string Code) GetExample002() => GetEmbeddedProgram("Example002.redcode");
        public static (string Name, string Code) GetExample003() => GetEmbeddedProgram("Example003.redcode");
        public static (string Name, string Code) GetExample004() => GetEmbeddedProgram("Example004.redcode");
        public static (string Name, string Code) GetExample005() => GetEmbeddedProgram("Example005.redcode");


        private static (string Name, string Code) GetEmbeddedProgram(string programName) {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"CoreWars.Engine.RedCodePrograms.{programName}.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream)) {
                return (Name: programName, Code: reader.ReadToEnd());
            }
        }

    }
}
