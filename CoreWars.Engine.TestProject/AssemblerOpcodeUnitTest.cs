using System;
using System.Linq;

using CoreWars.Engine.Extentions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreWars.Engine {

    [TestClass]
    public class AssemblerOpcodeUnitTest {

        [TestMethod]
        public void Display_All_Supported_Oppcode_AssemblyCode() {
            var opcodeSymbols = SymbolLibrary.OpcodeSymbols().ToArray();
                      
            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"confirm that all Mnemonics can be assembled into opcodes.");
            Console.WriteLine(new string('-', 80));

            foreach (var opcodeSymbol in opcodeSymbols) {
                Console.WriteLine(new string('=', 80));
                Console.WriteLine($"Mnemonic '{opcodeSymbol.Mnemonic}' Cotent.");
                Console.WriteLine(new string('-', 80));
                short opcode = opcodeSymbol.Mnemonic.ToOpcode();
                Console.WriteLine($"  Opcode Value '{opcode}'.");
            }

            Console.WriteLine(new string('=', 80));
        }

    }
}