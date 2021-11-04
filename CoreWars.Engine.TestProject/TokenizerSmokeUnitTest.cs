using System;
using System.Collections.Generic;

using CoreWars.Engine.TokenizerSmokeUnitTestSamples;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {

    /// <summary>
    /// Tokenizes CorWars-RedCode examples gathered from the internet.
    /// This smoke test does not guarantee the tokenizer is working correectly.
    /// This smoke test of the Tokenizer guarentees that it will not throw 
    /// exception, and provides a means for visual inspections when questions arise.
    /// </summary>

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

        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example000() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample000());


        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example001() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample001());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example002() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample002());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example003() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample003());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example004() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample004());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example005() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample005());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example006() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample006());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example007() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample007());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example008() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample008());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example009() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample009());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example010() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample010());


        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example011() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample011());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example012() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample012());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example013() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample013());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example014() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample014());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example015() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample015());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example016() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample016());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example017() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample017());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example018() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample018());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example019() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample019());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example020() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample020());


        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example021() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample021());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example022() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample022());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example023() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample023());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example024() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample024());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example025() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample025());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example026() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample026());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example027() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample027());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example028() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample028());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example029() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample029());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example030() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample030());


        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example031() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample031());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example032() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample032());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example033() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample033());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example034() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample034());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example035() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample035());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example036() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample036());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example037() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample037());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example038() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample038());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example039() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample039());
        [TestMethod] public void Display_Loading_And_Tokenizing_Of_RedCode_Example040() => Display_Loading_And_Tokenizing_Of_RedCode(TokenizerSmokeUnitTestSamplesStorage.GetExample040());

    }
}