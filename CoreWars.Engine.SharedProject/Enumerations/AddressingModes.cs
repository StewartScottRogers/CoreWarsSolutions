using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    internal enum AddressingModes : byte {

        [AddressingMode(
            symbolEnabled: true,
            symbol: "#",
            description: "Immediate: The number is directly in the opcode.",
            example: ""
        )]
        Immediate,

        [AddressingMode(
            symbolEnabled: true,
            symbol: "$",
            description: "<Default/None> Direct: The opcode points to a cell relative to the current cell."
        )]
        Direct,

        [AddressingMode(
            symbolEnabled: false,
            symbol: "@",
            description: "Indirect: The opcode points to a cell relative to the current cell. That cell's B value is added to the indirect pointer, to provide the target.",
            example: ""
        )]
        Indirect,

        [AddressingMode(
            symbolEnabled: false,
            symbol: "<",
            description: "Indirect With Predecrement: The intermediate register is decreased before use.",
            example: ""
        )]
        IndirectWithPredecrement,

        [AddressingMode(
            symbolEnabled: false,
            symbol: "<",
            description: "Indirect With Predecrement: The intermediate register is increased after use.",
            example: ""
        )]
        IndirectWithPostincrement,

    }
}
