using System.Collections.Generic;

namespace CoreWars.Engine.Extentions {
    internal static class AssemblerExtentions {
        public static (string Name, string Cotent, IEnumerable<(short lineNumber, string line)> Codelines) GetProgram(string programName, string programContent)
            => (Name: programName, Cotent: programContent, Codelines: programContent.ToLines());


        public static IEnumerable<short> Assemble((string Name, string Cotent, IEnumerable<(short lineNumber, string line)> Codelines) program) {

            IEnumerable<(short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines
                = program.Codelines.ParseCodeLines();

            var labeledLineNumbersDictionary = parsedCodeLines.CreateLabeledLineNumbersDictionary();
            var labledValuePairDictionary = parsedCodeLines.CreateLabledValuePairDictionary();

            foreach (var parsedCodeLine in parsedCodeLines) {


            }

            yield break;
        }


      
    }
}
