namespace CoreWars.Engine {
    internal class ProcessorCore {
        private MemoryCore MemoryCore { get; set; }
        public short MemoryPointer { get; private set; }
        public short RegisterInstruction { get; private set; }
        public short RegisterA { get; private set; }
        public short RegisterB { get; private set; }

        public ProcessorCore(MemoryCore memoryCore, short memoryPointer) {
            MemoryCore = memoryCore;
            MemoryPointer = memoryPointer;
        }

        private void LoadInstruction() {
            var v = MemoryCore.Read(MemoryPointer);
        }
    }
}
