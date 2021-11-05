using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    internal enum AddressTypes {

        // The ICWS-88 Instruction Set
        [Address(
            mnemonicEnabled: true,
            mnemonic: "",
            standard: "ICWS-88",
            description: "<Default/None> Direct: The opcode points to a cell relative to the current cell."
        )]
        Default,




        // The ICWS-94 Instruction Set
        [Address(
             mnemonicEnabled: true,
             mnemonic: "$",
             standard: "ICWS-94",
             description: "Direct: The opcode points to a cell relative to the current cell."
         )]
        Direct,

        [Address(
            mnemonicEnabled: false,
            mnemonic: "#",
            standard: "ICWS-94",
            description: "Immediate: The number is directly in the opcode.",
            example: ""
        )]
        Immediate,

       

        [Address(
            mnemonicEnabled: false,
            mnemonic: "*",
            standard: "ICWS-94",
            description: "Indirect: The opcode points to a cell relative to the current cell. That cell's A value is added to the indirect pointer, to provide the target.",
            example: ""
        )]
        IndirectA,

        [Address(
            mnemonicEnabled: false,
            mnemonic: "@",
            standard: "ICWS-94",
            description: "Indirect: The opcode points to a cell relative to the current cell. That cell's B value is added to the indirect pointer, to provide the target.",
            example: ""
        )]
        IndirectB,



        [Address(
            mnemonicEnabled: false,
            mnemonic: "{",
            standard: "ICWS-94",
            description: "Indirect With Predecrement: The intermediate register is decreased before use.",
            example: ""
        )]
        IndirectWithPredecrementA,

        [Address(
            mnemonicEnabled: false,
            mnemonic: "<",
            standard: "ICWS-94",
            description: "Indirect With Predecrement: The intermediate register is decreased before use.",
            example: ""
        )]
        IndirectWithPredecrementB,



        [Address(
            mnemonicEnabled: false,
            mnemonic: "}",
            standard: "ICWS-94",
            description: "Indirect With Predecrement: The intermediate register is increased after use.",
            example: ""
        )]
        IndirectWithPostincrementA,

        [Address(
           mnemonicEnabled: false,
           mnemonic: ">",
           standard: "ICWS-94",
           description: "Indirect With Predecrement: The intermediate register is increased after use.",
           example: ""
       )]
        IndirectWithPostincrementB,
    }
}
