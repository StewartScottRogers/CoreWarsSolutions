
using CoreWars.Engine.Attributes;

namespace CoreWars.Engine {
    internal enum RedCodeSpecialCommands : byte {

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
    }
}
