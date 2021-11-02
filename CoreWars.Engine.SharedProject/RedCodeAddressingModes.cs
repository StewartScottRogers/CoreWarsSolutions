using CoreWars.Engine.Attributes;

namespace CoreWars.Engine {
    internal enum RedCodeAddressingModes : byte {

        [AddressingMode(
            symbol: "#",
            description: "Immediate: The number is directly in the opcode."
        )]
        Immediate,

        [AddressingMode(
            symbol: "$",
            description: "<Default/None> Direct: The opcode points to a cell relative to the current cell."
        )]
        Direct,

        [AddressingMode(
            symbol: "@",
            description: "Indirect: The opcode points to a cell relative to the current cell. That cell's B value is added to the indirect pointer, to provide the target."
        )]
        Indirect,

        [AddressingMode(
            symbol: "<",
            description: "Indirect With Predecrement: The intermediate register is decreased before use."
        )]
        IndirectWithPredecrement,

        [AddressingMode(
           symbol: "<",
           description: "Indirect With Predecrement: The intermediate register is increased after use."
        )]
        IndirectWithPostincrement,

    }
}
