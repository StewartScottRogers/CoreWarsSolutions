using System;
using System.Text;

using CoreWars.Engine.Extentions;

namespace CoreWars.Engine {
    internal class MemoryCore {
        private const int DefaultChunkSize = 20;
        private readonly short[] Buffer;

        private int BufferChunkCount = 1;
        private int BufferChunkSize = DefaultChunkSize;

        public MemoryCore(int coreSize = DefaultChunkSize * 8) {
            BufferChunkSize = DefaultChunkSize / sizeof(short);
            if (coreSize < BufferChunkSize)
                coreSize = BufferChunkSize;

            BufferChunkCount = (int)(coreSize / BufferChunkSize);
            Buffer = new short[BufferChunkSize * BufferChunkCount];
        }

        public int Read(short memoryIndex)
            => Buffer[GetSafeBufferIndex(memoryIndex)];

        public void Write(short memoryIndex, short memoryValue)
            => Buffer[GetSafeBufferIndex(memoryIndex)] = memoryValue;

        public short Size { get => (short)Buffer.Length; }

        public override String ToString() {
            StringBuilder stringBuilder = new StringBuilder();

            for (int bufferSpanIndex = 0; bufferSpanIndex < BufferChunkCount; bufferSpanIndex++) {
                var bufferSpan = new Span<short>(Buffer, (bufferSpanIndex * BufferChunkSize), BufferChunkSize);
                var array = bufferSpan.ToArray();
                string hexString = array.ToHexString();
                stringBuilder.AppendLine(hexString);
            }

            return stringBuilder.ToString();
        }

        private short GetSafeBufferIndex(short memoryIndex) => (short)(memoryIndex % Size);
    }
}
