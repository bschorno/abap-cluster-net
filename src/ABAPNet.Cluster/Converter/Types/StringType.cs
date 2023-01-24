﻿using System.Text;

namespace ABAPNet.Cluster.Converter.Types
{
    internal class StringType : IStringType, IType
    {
        public byte KindFlag => 0x07;

        public byte TypeFlag => 0x13;

        public byte SpecFlag => 0x00;

        public byte StructDescrFlag => 0xaa;

        public int StructDescrByteLength => 8;

        public int AlignmentFactor => 4;

        public ReadOnlySpan<byte> GetBytes(object? data, DataBufferConfiguration configuration)
        {
            if (data == null)
                return ReadOnlySpan<byte>.Empty;

            if (data is not string stringValue)
                throw new InvalidTypeException(data, typeof(string));

            Span<byte> buffer = new Span<byte>(new byte[stringValue.Length * 2]);

            configuration.CodePage.Encoding.GetBytes(stringValue, buffer);
            return buffer;
        }
    }
}