
using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    internal enum DirectiveTypes {

        [Directive(
            mnemonicEnabled: true,
            mnemonic: "EQU",
            description: "Assigns value to a variable.",
            example: "[value] EQU [variable]"
        )]
        EQU,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "ORG",
            description: "takes one parameter, which identifies the start location.",
            example: "ORG <post description>"
        )]
        ORG,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "END",
            description: "Stops compilation, further lines are treated as comments.",
            example: "END <post description>"
        )]
        END,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "FOR",
            description: "For Interations",
            example: "For [A]"
        )]
        FOR,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "ROF",
            description: "End of For Interations",
            example: "ROF"
        )]
        ROF,
    }
}
