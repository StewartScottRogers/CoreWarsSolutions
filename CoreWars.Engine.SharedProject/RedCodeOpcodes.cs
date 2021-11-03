using CoreWars.Engine.Attributes;

namespace CoreWars.Engine {
    public enum RedCodeOpcodes : byte {

        // The ICWS-88 Instruction Set
        [OpXcode(
            symbol: "DAT",
            description: "data (kills the process). - DAT A B: Remove executing process from process queue.",
            example: "DAT"
        )]
        DAT = 1,

        [OpXcode(
            symbol: "MOV",
            description: "move (copies data from one address to another). - MOV A B: move A to B.",
            "MOV [a] [b]"
        )]
        MOV = 2,

        [OpXcode(
            symbol: "ADD",
            description: "add (adds one number to another). - ADD A B: add A to B.",
            example: "ADD  [a] [b]"
        )]
        ADD = 3,

        [OpXcode(
            symbol: "SUB",
            description: "subtract (subtracts one number from another). - SUB A B: subtract A from B.",
            example: "SUB  [a] [b]"
        )]
        SUB = 4,

        [OpXcode(
            symbol: "JMP",
            description: "jump (continues execution from another address). - JMP A B: jump to A.",
            example: "JMP [a] [b]"
        )]
        JMP = 5,

        [OpXcode(
            symbol: "JMZ",
            description: "jump if zero (tests a number and jumps to an address if it's 0). - JMZ A B: jump to A if B is zero.",
            example: "JMZ [a] [b]"
        )]
        JMZ = 6,

        [OpXcode(
            symbol: "JMN",
            description: "jump if not zero (tests a number and jumps if it isn't 0). - JMN A B: jump to A if B  is not zero.",
            example: "JMN [a] [b]"
        )]
        JMN = 7,

        [OpXcode(
            symbol: "CMP",
            description: "compare (same as SEQ). - CMP A B: if A equals B, then skip the next instruction.",
            example: "CMP [a] [b]"
        )]
        CMP = 8,

        [OpXcode(
            symbol: "SLT",
            description: "skip if lower than (compares two values, and skips the next instruction if the first is lower than the second). - SLT A B: if A is less than B then skip next instruction.",
            example: "SLT [a] [b]"
        )]
        SLT = 9,

        [OpXcode(
            symbol: "DJN",
            description: "decrement and jump if not zero (decrements a number by one, and jumps unless the result is 0). - DJN  A B: decrement B; if B is not zero then jump to A",
            example: "DNJ [a] [b]"
        )]
        DJN = 10,

        [OpXcode(
            symbol: "SPL",
            description: "split (starts a second process at another address). place A in the process queue. - A B: place A  in  the process queue",
            example: "SPL [a]"
        )]
        SPL = 11,




        // The ICWS- ++
        [OpXcode(
            symbol: "MUL",
            description: "multiply (multiplies one number with another).",
            example: ""
        )]
        MUL = 12,

        [OpXcode(
            symbol: "DIV",
            description: "divide (divides one number with another).",
            example: ""
        )]
        DIV = 13,

        [OpXcode(
            symbol: "MOD",
            description: "modulus (divides one number with another and gives the remainder).",
            example: ""
        )]
        MOD = 14,

        [OpXcode(
            symbol: "SEQ",
            description: "skip if equal (compares two instructions, and skips the next instruction if they are equal).",
            example: ""
        )]
        SEQ = 15,

        [OpXcode(
            symbol: "SNE",
            description: "skip if not equal (compares two instructions, and skips the next instruction if they aren't equal).",
            example: ""
        )]
        SNE = 16,

        [OpXcode(
            symbol: "NOP",
            description: "no operation(does nothing).",
            example: ""
        )]
        NOP = 17,

    }
}
