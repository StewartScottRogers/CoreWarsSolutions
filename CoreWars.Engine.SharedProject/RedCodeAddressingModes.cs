using CoreWars.Engine.Attributes;

namespace CoreWars.Engine {
    internal enum RedCodeAddressingModes {

        [AddressingMode(
            "#",
            "Immediate: "
        )]
        Immediate,

        [AddressingMode(
            "$",
            "Direct: "
        )]
        Direct,

        [AddressingMode(
            "@",
            "Indirect: "
        )]
        Indirect,

        [AddressingMode(
            "<",
            "Indirect With Predecrement: "
        )]
        IndirectWithPredecrement,

    }
}
