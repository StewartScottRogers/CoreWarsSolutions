using System;
using System.Collections.Generic;
using System.Linq;

using CoreWars.Engine.RedCodePrograms;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {
    [TestClass]
    public class SmokeUnitTest {
        [TestMethod]
        public void Display_New_MemoryCore_As_String() {
            Console.WriteLine(new MemoryCore(eightyByteBufferChunkCount: 3).ToString());
        }

        [TestMethod]
        public void Display_MemoryCore_Before_And_After_Overwriting_As_String() {
            MemoryCore memoryCore = new MemoryCore(eightyByteBufferChunkCount: 3);
            Console.WriteLine(memoryCore.ToString());
            for (int memoryIndex = 0; memoryIndex < memoryCore.Size; memoryIndex++)
                memoryCore.Write(memoryIndex, Convert.ToByte('A'));
            Console.WriteLine(memoryCore.ToString());
        }

        [TestMethod]
        public void Display_Loading_And_Tokenizing_Of_RedCode_Example000()
            => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample000());

        [TestMethod]
        public void Display_Loading_And_Tokenizing_Of_RedCode_Example001()
            => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample001());

        [TestMethod]
        public void Display_Loading_And_Tokenizing_Of_RedCode_Example002()
          => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample002());


        [TestMethod]
        public void Display_Loading_And_Tokenizing_Of_RedCode_Example003()
          => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample003());

        [TestMethod]
        public void Display_Loading_And_Tokenizing_Of_RedCode_Example004()
          => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample004());

        [TestMethod]
        public void Display_Loading_And_Tokenizing_Of_RedCode_Example005()
          => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample005());

        [TestMethod]
        public void Display_Loading_And_Tokenizing_Of_RedCode_Example006()
          => Display_Loading_And_Tokenizing_Of_RedCode(RedCodeProgramStorage.GetExample006());



        private void Display_Loading_And_Tokenizing_Of_RedCode((string Name, IEnumerable<(int lineNumber, string line)> Codelines) program) {

            IEnumerable<(int lineNumber, string line)> codelines = program.Codelines;

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' Raw.");
            Console.WriteLine(new string('-', 80));
            Console.WriteLine(string.Join(Environment.NewLine, codelines));
            Console.WriteLine(new string('=', 80));

            Console.WriteLine();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"Program Name: '{program.Name}' Pre Processed.");
            Console.WriteLine(new string('-', 80));

            IEnumerable<(int LineNumber, string Label, string Opcode, string RegisterA, string RegisterB)> preProcessCodelines 
                = codelines.ParseCodeLines();
            
            Console.WriteLine(string.Join(Environment.NewLine, preProcessCodelines.ToLineString()));
            Console.WriteLine(new string('=', 80));

          
        }
    }
}