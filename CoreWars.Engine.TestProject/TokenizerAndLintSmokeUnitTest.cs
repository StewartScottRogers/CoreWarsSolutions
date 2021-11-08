using System;
using System.Collections.Generic;

using CoreWars.Engine.TokenizerAndLintSmokeUnitTestSamples;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {

    [TestClass]
    public class TokenizerAndLintSmokeUnitTest {
        private void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode((string Name, string Cotent, IEnumerable<(short lineNumber, string line)> Codelines) program) {

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' Cotent.");
            Console.WriteLine(new string('-', 80));
            Console.WriteLine(program.Cotent);
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' Codelines.");
            Console.WriteLine(new string('-', 80));
            IEnumerable<(short lineNumber, string line)> codelines = program.Codelines;
            Console.WriteLine(string.Join(Environment.NewLine, codelines));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' ParsedCodeLines.");
            Console.WriteLine(new string('-', 80));
            IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> parsedCodeLines
                = codelines.ParseCodeLines();
            Console.WriteLine(string.Join(Environment.NewLine, parsedCodeLines.ToStrings()));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' lintedCodeLines.");
            Console.WriteLine(new string('-', 80));
            IEnumerable<(short OpcodePointer, short LineNumber, string LineType, string Label, string Command, string ParameterA, string ParameterB)> lintedCodeLines
               = parsedCodeLines.LintCodeLines();
            Console.WriteLine(string.Join(Environment.NewLine, lintedCodeLines.ToStrings()));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' LabeledLineNumbersDictionary.");
            Console.WriteLine(new string('-', 80));
            var labeledLineNumbersDictionary = parsedCodeLines.CreateLabeledLineNumbersDictionary();
            Console.WriteLine(string.Join(Environment.NewLine, labeledLineNumbersDictionary.ToStrings()));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' LabledValuePairDictionary.");
            Console.WriteLine(new string('-', 80));
            var labledValuePairDictionary = parsedCodeLines.CreateLabledVariableDictionary();
            Console.WriteLine(string.Join(Environment.NewLine, labledValuePairDictionary.ToStrings()));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

        }


        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example000() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample000());


        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example001() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample001());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example002() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample002());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example003() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample003());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example004() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample004());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example005() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample005());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example006() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample006());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example007() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample007());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example008() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample008());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example009() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample009());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example010() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample010());


        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example011() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample011());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example012() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample012());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example013() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample013());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example014() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample014());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example015() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample015());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example016() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample016());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example017() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample017());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example018() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample018());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example019() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample019());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example020() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample020());


        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example021() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample021());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example022() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample022());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example023() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample023());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example024() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample024());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example025() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample025());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example026() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample026());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example027() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample027());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example028() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample028());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example029() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample029());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example030() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample030());


        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example031() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample031());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example032() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample032());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example033() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample033());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example034() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample034());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example035() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample035());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example036() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample036());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example037() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample037());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example038() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample038());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example039() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample039());
        [TestMethod] public void Display_Loading_And_Tokenizing_And_Linting_Of_RedCode_Example040() => Display_Loading_And_Tokenizing_And_Linting_Of_RedCode(TokenizerAndLintSmokeUnitTestSamplesStorage.GetExample040());


    }
}