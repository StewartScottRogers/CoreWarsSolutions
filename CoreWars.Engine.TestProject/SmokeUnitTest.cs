using System;

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
    }
}