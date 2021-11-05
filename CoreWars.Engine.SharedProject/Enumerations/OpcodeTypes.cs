using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    public enum OpcodeTypes {

        // The ICWS-88 Instruction Set
        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "DAT",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "ICWS-88",
            description: "data (kills the process). - DAT A B: Remove executing process from process queue if executed..",
            example: "DAT"
        )]
        DAT = 1,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "MOV",
            parameterRequiredA: true,
            parameterRequiredB: true,
            standard: "ICWS-88",
            description: "move (copies data from one address to another). - MOV A B: move A to B.",
            example: "MOV [a] [b]"
        )]
        MOV = 2,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "ADD",
            parameterRequiredA: true,
            parameterRequiredB: true,
            standard: "ICWS-88",
            description: "add (adds one number to another). - ADD A B: add A to B.",
            example: "ADD  [a] [b]"
        )]
        ADD = 3,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "SUB",
            parameterRequiredA: true,
            parameterRequiredB: true,
            standard: "ICWS-88",
            description: "subtract (subtracts one number from another). - SUB A B: subtract A from B.",
            example: "SUB  [a] [b]"
        )]
        SUB = 4,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "JMP",
            standard: "ICWS-88",
            parameterRequiredA: true,
            parameterRequiredB: false,
            description: "jump (continues execution from another address). - JMP A: jump to A.",
            example: "JMP [a]"
        )]
        JMP = 5,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "DJZ",
            parameterRequiredA: true,
            parameterRequiredB: true,
            standard: "ICWS-88",
            description: " Decrement contents of location A by 1. If location A now holds 0, jump to location B, otherwise continue with next instruction.",
            example: "DJZ [a] [b]"
        )]
        DJZ = 6,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "CMP",
            parameterRequiredA: true,
            parameterRequiredB: true,
            standard: "ICWS-88",
            description: "compare (same as SEQ). - CMP A B: if A equals B, then skip the next instruction.",
            example: "CMP [a] [b]"
         )]
        CMP = 7,


        // The ICWS- ++

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "JMZ",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "jump if zero (tests a number and jumps to an address if it's 0). - JMZ A B: jump to A if B is zero.",
            example: "JMZ [a] [b]"
        )]
        JMZ = 8,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "JMN",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "jump if not zero (tests a number and jumps if it isn't 0). - JMN A B: jump to A if B  is not zero.",
            example: "JMN [a] [b]"
        )]
        JMN = 9,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "SLT",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "skip if lower than (compares two values, and skips the next instruction if the first is lower than the second). - SLT A B: if A is less than B then skip next instruction.",
            example: "SLT [a] [b]"
        )]
        SLT = 10,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "DJN",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "decrement and jump if not zero (decrements a number by one, and jumps unless the result is 0). - DJN  A B: decrement B; if B is not zero then jump to A",
            example: "DNJ [a] [b]"
        )]
        DJN = 11,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "SPL",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "split (starts a second process at another address). place A in the process queue. - A B: place A  in  the process queue",
            example: "SPL [a]"
        )]
        SPL = 12,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "MUL",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "multiply (multiplies one number with another).",
            example: ""
        )]
        MUL = 13,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "DIV",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "divide (divides one number with another).",
            example: ""
        )]
        DIV = 14,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "MOD",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "modulus (divides one number with another and gives the remainder).",
            example: ""
        )]
        MOD = 15,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "SEQ",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "skip if equal (compares two instructions, and skips the next instruction if they are equal).",
            example: ""
        )]
        SEQ = 16,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "SNE",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "skip if not equal (compares two instructions, and skips the next instruction if they aren't equal).",
            example: ""
        )]
        SNE = 17,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "NOP",
            parameterRequiredA: false,
            parameterRequiredB: false,
            standard: "",
            description: "no operation(does nothing).",
            example: ""
        )]
        NOP = 18,

    }
}
