using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {

    [TestClass]
    public class MemoryCoreUnitTest {

        [TestMethod]
        public void Display_New_MemoryCore_As_String() {
            Console.WriteLine(new MemoryCore(memoryCellsSize: 64).ToString());
        }

        [TestMethod]
        public void Display_MemoryCore_Before_And_After_Overwriting_As_String() {
            MemoryCore memoryCore = new MemoryCore(memoryCellsSize: 64);
            Console.WriteLine(memoryCore.ToString());
            for (short memoryIndex = 0; memoryIndex < memoryCore.Length; memoryIndex++)
                memoryCore.AccessMemoryCell(memoryIndex, 1);
            Console.WriteLine(memoryCore.ToString());
        }

  
    }
}