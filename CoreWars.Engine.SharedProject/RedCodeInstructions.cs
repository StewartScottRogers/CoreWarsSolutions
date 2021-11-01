using CoreWars.Engine.Attributes;

namespace CoreWars.Engine {
    public enum RedCodeInstructions {

        // The ICWS-88 Instruction Set
        [Instruction(
            "DAT",
            "data (kills the process). - DAT A B: Remove executing process from process queue.",
            "Example: "
        )]
        DAT = 1,

        [Instruction(
            "MOV",
            "move (copies data from one address to another). - MOV A B: move A to B.",
            "Example: "
        )]
        MOV = 2,

        [Instruction(
            "ADD",
            "add (adds one number to another). - ADD A B: add A to B.",
            "Example: "
        )]
        ADD = 3,

        [Instruction(
            "SUB",
            "subtract (subtracts one number from another). - SUB A B: subtract A from B.",
            "Example: "
        )]
        SUB = 4,

        [Instruction(
            "JMP",
            "jump (continues execution from another address). - JMP A B: jump to A.",
            "Example: "
        )]
        JMP = 5,

        [Instruction(
            "JMZ",
            "jump if zero (tests a number and jumps to an address if it's 0). - JMZ A B: jump to A if B is zero.",
            "Example: "
        )]
        JMZ = 6,

        [Instruction(
            "JMN",
            "jump if not zero (tests a number and jumps if it isn't 0). - JMN A B: jump to A  if  B  is not zero.",
            "Example: "
        )]
        JMN = 7,

        [Instruction(
            "CMP",
            "compare (same as SEQ). - CMP A B: if A equals B, then skip the next instruction.",
            "Example: "
        )]
        CMP = 8,

        [Instruction(
            "SLT",
            "skip if lower than (compares two values, and skips the next instruction if the first is lower than the second). - SLT A B: if A is less than B then skip next instruction.",
            "Example: "
        )]
        SLT = 9,

        [Instruction(
            "DJN",
            "decrement and jump if not zero (decrements a number by one, and jumps unless the result is 0). - DJN  A B: decrement B; if B is not zero then jump to A",
            "Example: "
        )]
        DJN = 10,

        [Instruction(
            "SPL",
            "split (starts a second process at another address). place A in the process queue. - A B: place A  in  the process queue",
            "Example: "
        )]
        SPL = 11,




        // The ICWS- ++
        [Instruction(
            "MUL",
            "multiply (multiplies one number with another).",
            "Example: "
        )]
        MUL = 12,

        [Instruction(
            "DIV",
            "divide (divides one number with another).",
            "Example: "
        )]
        DIV = 13,

        [Instruction(
            "MOD",
            "modulus (divides one number with another and gives the remainder).",
            "Example: "
        )]
        MOD = 14,

        [Instruction(
            "SEQ",
            "skip if equal (compares two instructions, and skips the next instruction if they are equal).",
            "Example: "
        )]
        SEQ = 15,

        [Instruction(
            "SNE",
            "skip if not equal (compares two instructions, and skips the next instruction if they aren't equal).",
            "Example: "
        )]
        SNE = 16,

        [Instruction(
            "NOP",
            "no operation(does nothing).",
            "Example: "
        )]
        NOP = 17,

    }
}
