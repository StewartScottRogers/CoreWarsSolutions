
using CoreWars.Engine.Attributes;

namespace CoreWars.Engine.Enumerations {
    internal enum DirectiveTypes {

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "EQU",
            standard: "",
            description: "Assigns value to a variable.",
            example: "[value] EQU [variable]"
        )]
        EQU,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "ORG",
            standard: "",
            description: "takes one parameter, which identifies the start location.",
            example: "ORG <post description>"
        )]
        ORG,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "END",
            standard: "",
            description: "Stops compilation, further lines are treated as comments.",
            example: "END <post description>"
        )]
        END,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "FOR",
            standard: "",
            description: "For Interations",
            example: "For [A]"
        )]
        FOR,

        [Directive(
            mnemonicEnabled: false,
            mnemonic: "ROF",
            standard: "",
            description: "End of For Interations",
            example: "ROF"
        )]
        ROF,
    }
}
