using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    internal enum AddressTypes {

        [Address(
            mnemonicEnabled: true,
            mnemonic: "#",
            standard: "",
            description: "Immediate: The number is directly in the opcode.",
            example: ""
        )]
        Immediate,

        [Address(
            mnemonicEnabled: true,
            mnemonic: "$",
            standard: "",
            description: "<Default/None> Direct: The opcode points to a cell relative to the current cell."
        )]
        Direct,

        [Address(
            mnemonicEnabled: false,
            mnemonic: "@",
            standard: "",
            description: "Indirect: The opcode points to a cell relative to the current cell. That cell's B value is added to the indirect pointer, to provide the target.",
            example: ""
        )]
        Indirect,

        [Address(
            mnemonicEnabled: false,
            mnemonic: "<",
            standard: "",
            description: "Indirect With Predecrement: The intermediate register is decreased before use.",
            example: ""
        )]
        IndirectWithPredecrement,

        [Address(
            mnemonicEnabled: false,
            mnemonic: "<",
            standard: "",
            description: "Indirect With Predecrement: The intermediate register is increased after use.",
            example: ""
        )]
        IndirectWithPostincrement,

    }
}
