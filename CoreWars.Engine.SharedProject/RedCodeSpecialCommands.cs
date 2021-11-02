
using CoreWars.Engine.Attributes;

namespace CoreWars.Engine {
    internal enum RedCodeSpecialCommands : byte {

        [SpecialCommand(
            symbol: "END",
            description: "Stops compilation, further lines are treated as comments."
        )]
        END,

        [SpecialCommand(
            symbol: "ORG",
            description: "takes one parameter, which identifies the start location."
        )]
        ORG,

        [SpecialCommand(
            symbol: "LABEL",
            description: "Replaces all instances of <label> with <A>."
        )]
        LABEL,

        [SpecialCommand(
            symbol: "PIN",
            description: "Specifies P-Space identifier. If equal, the two programs share P-Space."
        )]
        PIN,

    }
}
