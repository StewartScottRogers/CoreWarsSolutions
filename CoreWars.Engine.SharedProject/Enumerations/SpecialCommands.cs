
using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    internal enum SpecialCommands : byte {

        [SpecialCommand(
            symbol: "EQU",
            description: "Assigns value to a variable.",
            example: "[value] EQU [variable]"
        )]
        EQU,

        [SpecialCommand(
            symbol: "ORG",
            description: "takes one parameter, which identifies the start location.",
            example: "ORG <post description>"
        )]
        ORG,

        [SpecialCommand(
            symbol: "END",
            description: "Stops compilation, further lines are treated as comments.",
            example: "END <post description>"
        )]
        END,

        [SpecialCommand(
            symbol: "FOR",
            description: "For Interations",
            example: "For [A]"
        )]
        FOR,

        [SpecialCommand(
            symbol: "ROF",
            description: "End of For Interations",
            example: "ROF"
        )]
        ROF,
    }
}
