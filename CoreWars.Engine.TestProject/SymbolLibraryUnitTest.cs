using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {

    [TestClass]
    public class SymbolLibraryUnitTest {

        [TestMethod]
        public void Display_Symbols() {
            Console.WriteLine(string.Join(Environment.NewLine, SymbolLibrary.Symbols().ToStrings()));
        }

    }
}