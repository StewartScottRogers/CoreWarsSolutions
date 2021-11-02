using CoreWars.Engine.Attributes;

namespace CoreWars.Engine {
    public enum RedCodeOpcodes : byte {

        // The ICWS-88 Instruction Set
        [Opcode(
            symbol: "DAT",
            description: "data (kills the process). - DAT A B: Remove executing process from process queue.",
            example: "Example: "
        )]
        DAT = 1,

        [Opcode(
            symbol: "MOV",
            description: "move (copies data from one address to another). - MOV A B: move A to B.",
            "Example: "
        )]
        MOV = 2,

        [Opcode(
            symbol: "ADD",
            description: "add (adds one number to another). - ADD A B: add A to B.",
            example: "Example: "
        )]
        ADD = 3,

        [Opcode(
            symbol: "SUB",
            description: "subtract (subtracts one number from another). - SUB A B: subtract A from B.",
            example: "Example: "
        )]
        SUB = 4,

        [Opcode(
            symbol: "JMP",
            description: "jump (continues execution from another address). - JMP A B: jump to A.",
            example: "Example: "
        )]
        JMP = 5,

        [Opcode(
            symbol: "JMZ",
            description: "jump if zero (tests a number and jumps to an address if it's 0). - JMZ A B: jump to A if B is zero.",
            example: "Example: "
        )]
        JMZ = 6,

        [Opcode(
            symbol: "JMN",
            description: "jump if not zero (tests a number and jumps if it isn't 0). - JMN A B: jump to A  if  B  is not zero.",
            example: "Example: "
        )]
        JMN = 7,

        [Opcode(
            symbol: "CMP",
            description: "compare (same as SEQ). - CMP A B: if A equals B, then skip the next instruction.",
            example: "Example: "
        )]
        CMP = 8,

        [Opcode(
            symbol: "SLT",
            description: "skip if lower than (compares two values, and skips the next instruction if the first is lower than the second). - SLT A B: if A is less than B then skip next instruction.",
            example: "Example: "
        )]
        SLT = 9,

        [Opcode(
            symbol: "DJN",
            description: "decrement and jump if not zero (decrements a number by one, and jumps unless the result is 0). - DJN  A B: decrement B; if B is not zero then jump to A",
            example: "Example: "
        )]
        DJN = 10,

        [Opcode(
            symbol: "SPL",
            description: "split (starts a second process at another address). place A in the process queue. - A B: place A  in  the process queue",
            example: "Example: "
        )]
        SPL = 11,




        // The ICWS- ++
        [Opcode(
            symbol: "MUL",
            description: "multiply (multiplies one number with another).",
            example: "Example: "
        )]
        MUL = 12,

        [Opcode(
            symbol: "DIV",
            description: "divide (divides one number with another).",
            example: "Example: "
        )]
        DIV = 13,

        [Opcode(
            symbol: "MOD",
            description: "modulus (divides one number with another and gives the remainder).",
            example: "Example: "
        )]
        MOD = 14,

        [Opcode(
            symbol: "SEQ",
            description: "skip if equal (compares two instructions, and skips the next instruction if they are equal).",
            example: "Example: "
        )]
        SEQ = 15,

        [Opcode(
            symbol: "SNE",
            description: "skip if not equal (compares two instructions, and skips the next instruction if they aren't equal).",
            example: "Example: "
        )]
        SNE = 16,

        [Opcode(
            symbol: "NOP",
            description: "no operation(does nothing).",
            example: "Example: "
        )]
        NOP = 17,

    }
}
