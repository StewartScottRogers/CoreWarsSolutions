using System;

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
        public void Display_RedCode_Examples() {
            var program000 = RedCodeProgramStorage.GetExample000();
            Console.WriteLine(program000.ProgramName);
            Console.WriteLine(program000.ProgramCode);

            var program001 = RedCodeProgramStorage.GetExample001();
            Console.WriteLine(program001.ProgramName);
            Console.WriteLine(program001.ProgramCode);
        }
    }
}