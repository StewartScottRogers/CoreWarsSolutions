using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    public enum OpcodeTypes {

        // The ICWS-88 Instruction Set
        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "DAT",
            standard: "",
            description: "data (kills the process). - DAT A B: Remove executing process from process queue.",
            example: "DAT"
        )]
        DAT = 1,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "MOV",
            standard: "",
            description: "move (copies data from one address to another). - MOV A B: move A to B.",
            example: "MOV [a] [b]"
        )]
        MOV = 2,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "ADD",
            standard: "",
            description: "add (adds one number to another). - ADD A B: add A to B.",
            example: "ADD  [a] [b]"
        )]
        ADD = 3,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "SUB",
            standard: "",
            description: "subtract (subtracts one number from another). - SUB A B: subtract A from B.",
            example: "SUB  [a] [b]"
        )]
        SUB = 4,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "JMP",
            standard: "",
            description: "jump (continues execution from another address). - JMP A B: jump to A.",
            example: "JMP [a] [b]"
        )]
        JMP = 5,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "JMZ",
            standard: "",
            description: "jump if zero (tests a number and jumps to an address if it's 0). - JMZ A B: jump to A if B is zero.",
            example: "JMZ [a] [b]"
        )]
        JMZ = 6,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "JMN",
            standard: "",
            description: "jump if not zero (tests a number and jumps if it isn't 0). - JMN A B: jump to A if B  is not zero.",
            example: "JMN [a] [b]"
        )]
        JMN = 7,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "CMP",
            standard: "",
            description: "compare (same as SEQ). - CMP A B: if A equals B, then skip the next instruction.",
            example: "CMP [a] [b]"
        )]
        CMP = 8,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "SLT",
            standard: "",
            description: "skip if lower than (compares two values, and skips the next instruction if the first is lower than the second). - SLT A B: if A is less than B then skip next instruction.",
            example: "SLT [a] [b]"
        )]
        SLT = 9,

        [Opcode(
            mnemonicEnabled: true,
            mnemonic: "DJN",
            standard: "",
            description: "decrement and jump if not zero (decrements a number by one, and jumps unless the result is 0). - DJN  A B: decrement B; if B is not zero then jump to A",
            example: "DNJ [a] [b]"
        )]
        DJN = 10,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "SPL",
            standard: "",
            description: "split (starts a second process at another address). place A in the process queue. - A B: place A  in  the process queue",
            example: "SPL [a]"
        )]
        SPL = 11,




        // The ICWS- ++
        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "MUL",
            standard: "",
            description: "multiply (multiplies one number with another).",
            example: ""
        )]
        MUL = 12,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "DIV",
            standard: "",
            description: "divide (divides one number with another).",
            example: ""
        )]
        DIV = 13,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "MOD",
            standard: "",
            description: "modulus (divides one number with another and gives the remainder).",
            example: ""
        )]
        MOD = 14,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "SEQ",
            standard: "",
            description: "skip if equal (compares two instructions, and skips the next instruction if they are equal).",
            example: ""
        )]
        SEQ = 15,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "SNE",
            standard: "",
            description: "skip if not equal (compares two instructions, and skips the next instruction if they aren't equal).",
            example: ""
        )]
        SNE = 16,

        [Opcode(
            mnemonicEnabled: false,
            mnemonic: "NOP",
            standard: "",
            description: "no operation(does nothing).",
            example: ""
        )]
        NOP = 17,

    }
}
