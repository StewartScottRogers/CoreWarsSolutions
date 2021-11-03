using System;
using System.Collections.Generic;

using CoreWars.Engine.RedCodePrograms;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {

    [TestClass]
    public class TokenizerSmokeUnitTest {

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example000() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample000());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example001() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample001());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example002() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample002());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example003() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample003());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example004() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample004());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example005() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample005());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example006() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample006());



        private void Display_Loading_And_Tokenizing_Of_RedCode((string Name, string Cotent, IEnumerable<(int lineNumber, string line)> Codelines) program) {

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' Cotent.");
            Console.WriteLine(new string('-', 80));
            Console.WriteLine(program.Cotent);
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' Codelines.");
            Console.WriteLine(new string('-', 80));
            IEnumerable<(int lineNumber, string line)> codelines = program.Codelines;
            Console.WriteLine(string.Join(Environment.NewLine, codelines));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' ParsedCodeLines.");
            Console.WriteLine(new string('-', 80));
            IEnumerable<(int LineNumber, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines
                = codelines.ParseCodeLines();
            Console.WriteLine(string.Join(Environment.NewLine, parsedCodeLines.ToLineString()));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

        }
    }
}