
using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    internal enum SpecialCommands : byte {

        [SpecialCommand(
            symbolEnabled: true,
            symbol: "EQU",
            description: "Assigns value to a variable.",
            example: "[value] EQU [variable]"
        )]
        EQU,

        [SpecialCommand(
            symbolEnabled: false,
            symbol: "ORG",
            description: "takes one parameter, which identifies the start location.",
            example: "ORG <post description>"
        )]
        ORG,

        [SpecialCommand(
            symbolEnabled: false,
            symbol: "END",
            description: "Stops compilation, further lines are treated as comments.",
            example: "END <post description>"
        )]
        END,

        [SpecialCommand(
            symbolEnabled: false,
            symbol: "FOR",
            description: "For Interations",
            example: "For [A]"
        )]
        FOR,

        [SpecialCommand(
            symbolEnabled: false,
            symbol: "ROF",
            description: "End of For Interations",
            example: "ROF"
        )]
        ROF,
    }
}
