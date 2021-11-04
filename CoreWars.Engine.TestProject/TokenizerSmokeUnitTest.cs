using System;
using System.Collections.Generic;

using CoreWars.Engine.RedCodePrograms;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {

    [TestClass]
    public class TokenizerSmokeUnitTest {
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
            IEnumerable<(int LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines
                = codelines.ParseCodeLines();
            Console.WriteLine(string.Join(Environment.NewLine, parsedCodeLines.ToStrings()));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

        }

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example000() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample000());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example001() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample001());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example002() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample002());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example003() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample003());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example004() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample004());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example005() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample005());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example006() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample006());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example007() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample007());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example008() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample008());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example009() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample009());



        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example010() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample010());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example011() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample011());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example012() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample012());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example013() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample013());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example014() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample014());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example015() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample015());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example016() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample016());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example017() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample017());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example018() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample018());

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example019() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample019());


        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example020() => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample020());

        
    }
}