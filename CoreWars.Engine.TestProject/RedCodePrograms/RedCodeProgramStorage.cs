using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CoreWars.Engine.RedCodePrograms {
    internal static class RedCodeProgramStorage {

        public static (string ProgramName, string ProgramCode) GetExample000() => GetEmbeddedProgram("Example000.redcode");
        public static (string ProgramName, string ProgramCode) GetExample001() => GetEmbeddedProgram("Example001.redcode");


        private static (string ProgramName, string ProgramCode) GetEmbeddedProgram(string programName) {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"CoreWars.Engine.RedCodePrograms.{programName}.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream)) {
                return (ProgramName: programName, ProgramCode: reader.ReadToEnd());
            }
        }

    }
}
