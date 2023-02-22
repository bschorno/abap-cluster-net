﻿using ABAPNet.Cluster.Attributes;

namespace ABAPNet.Cluster.Test.Unit
{
    public class Write_FlatTable
    {
        [Fact]
        public void Write_Char10_Table()
        {
            DataBuffer dataBuffer = new DataBuffer();

            byte[] bufferExpected = {
                0xFF, 0x06, 0x02, 0x01, 0x01, 0x02, 0x80, 0x00, 0x34, 0x31, 0x30, 0x33,
                0x00, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x14, 0x00,
                0x00, 0x00, 0x7D, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x54, 0x00, 0x41, 0x00, 0x42, 0x00, 0x4C, 0x00, 0x45, 0x00, 0xAD, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x14, 0xAA, 0x00, 0x00, 0x00, 0x00, 0x00, 0x14,
                0xAE, 0x00, 0x00, 0x00, 0x00, 0x00, 0x14, 0xBE, 0x00, 0x00, 0x00, 0x14,
                0x00, 0x00, 0x00, 0x02, 0xBC, 0x00, 0x00, 0x00, 0x14, 0x41, 0x00, 0x41,
                0x00, 0x41, 0x00, 0x41, 0x00, 0x41, 0x00, 0x41, 0x00, 0x41, 0x00, 0x41,
                0x00, 0x41, 0x00, 0x41, 0x00, 0xBD, 0xBC, 0x00, 0x00, 0x00, 0x14, 0x42,
                0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0x42,
                0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0xBD, 0xBF, 0x04
            };

            var bufferActual = dataBuffer.Export(new ClusterWithCharTable()
            {
                Table = new string[] {
                    "AAAAAAAAAA",
                    "BBBBBBBBBB"
                }
            });

            Assert.Equal(bufferExpected, bufferActual);
        }

        [Fact]
        public void Write_Int4_Table()
        {
            DataBuffer dataBuffer = new DataBuffer();

            byte[] bufferExpected = {
                0xFF, 0x06, 0x02, 0x01, 0x01, 0x02, 0x80, 0x00, 0x34, 0x31, 0x30, 0x33,
                0x00, 0x00, 0x00, 0x00, 0x03, 0x08, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00,
                0x00, 0x00, 0x71, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x54, 0x00, 0x41, 0x00, 0x42, 0x00, 0x4C, 0x00, 0x45, 0x00, 0xAD, 0x08,
                0x00, 0x00, 0x00, 0x00, 0x04, 0xAA, 0x08, 0x00, 0x00, 0x00, 0x00, 0x04,
                0xAE, 0x08, 0x00, 0x00, 0x00, 0x00, 0x04, 0xBE, 0x00, 0x00, 0x00, 0x04,
                0x00, 0x00, 0x00, 0x04, 0xBC, 0x00, 0x00, 0x00, 0x04, 0x01, 0x00, 0x00,
                0x00, 0xBD, 0xBC, 0x00, 0x00, 0x00, 0x04, 0x02, 0x00, 0x00, 0x00, 0xBD,
                0xBC, 0x00, 0x00, 0x00, 0x04, 0x03, 0x00, 0x00, 0x00, 0xBD, 0xBC, 0x00,
                0x00, 0x00, 0x04, 0x04, 0x00, 0x00, 0x00, 0xBD, 0xBF, 0x04
            };

            var bufferActual = dataBuffer.Export(new ClusterWithInt4Table()
            {
                Table = new int[] {
                    1,
                    2,
                    3,
                    4
                }
            });

            Assert.Equal(bufferExpected, bufferActual);
        }

        [Fact]
        public void Write_Struct_With_Two_Table()
        {
            DataBuffer dataBuffer = new DataBuffer();

            byte[] bufferExpected = {
                0xFF, 0x06, 0x02, 0x01, 0x01, 0x02, 0x80, 0x00, 0x34, 0x31, 0x30, 0x33,
                0x00, 0x00, 0x00, 0x00, 0x05, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00,
                0x00, 0x00, 0xD4, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x53, 0x00, 0x54, 0x00, 0x52, 0x00, 0x55, 0x00, 0x43, 0x00, 0x54, 0x00,
                0xAB, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x10, 0xAD, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x14, 0xAA, 0x00, 0x00, 0x00, 0x00, 0x00, 0x14, 0xAE, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x14, 0xAD, 0x08, 0x00, 0x00, 0x00, 0x00, 0x04, 0xAA,
                0x08, 0x00, 0x00, 0x00, 0x00, 0x04, 0xAE, 0x08, 0x00, 0x00, 0x00, 0x00,
                0x04, 0xAC, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x10, 0xBE, 0x00, 0x00, 0x00,
                0x14, 0x00, 0x00, 0x00, 0x02, 0xBC, 0x00, 0x00, 0x00, 0x14, 0x41, 0x00,
                0x41, 0x00, 0x41, 0x00, 0x41, 0x00, 0x41, 0x00, 0x41, 0x00, 0x41, 0x00,
                0x41, 0x00, 0x41, 0x00, 0x41, 0x00, 0xBD, 0xBC, 0x00, 0x00, 0x00, 0x14,
                0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00,
                0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0x42, 0x00, 0xBD, 0xBF, 0xBE, 0x00,
                0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x04, 0xBC, 0x00, 0x00, 0x00, 0x04,
                0x01, 0x00, 0x00, 0x00, 0xBD, 0xBC, 0x00, 0x00, 0x00, 0x04, 0x02, 0x00,
                0x00, 0x00, 0xBD, 0xBC, 0x00, 0x00, 0x00, 0x04, 0x03, 0x00, 0x00, 0x00,
                0xBD, 0xBC, 0x00, 0x00, 0x00, 0x04, 0x04, 0x00, 0x00, 0x00, 0xBD, 0xBF,
                0x04
            };

            var bufferActual = dataBuffer.Export(new ClusterWithStructAndTable()
            {
                Struct = new Struct()
                {
                    Table1 = new string[] {
                        "AAAAAAAAAA",
                        "BBBBBBBBBB"
                    },
                    Table2 = new int[] {
                        1,
                        2,
                        3,
                        4
                    }
                }
            });

            Assert.Equal(bufferExpected, bufferActual);
        }

        [Fact]
        public void Write_Struct_With_Empty_Table()
        {
            DataBuffer dataBuffer = new DataBuffer();

            byte[] bufferExpected = {
                0xFF, 0x06, 0x02, 0x01, 0x01, 0x02, 0x80, 0x00, 0x34, 0x31, 0x30, 0x33,
                0x00, 0x00, 0x00, 0x00, 0x05, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00,
                0x00, 0x00, 0x78, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x53, 0x00, 0x54, 0x00, 0x52, 0x00, 0x55, 0x00, 0x43, 0x00, 0x54, 0x00,
                0xAB, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x10, 0xAD, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x14, 0xAA, 0x00, 0x00, 0x00, 0x00, 0x00, 0x14, 0xAE, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x14, 0xAD, 0x08, 0x00, 0x00, 0x00, 0x00, 0x04, 0xAA,
                0x08, 0x00, 0x00, 0x00, 0x00, 0x04, 0xAE, 0x08, 0x00, 0x00, 0x00, 0x00,
                0x04, 0xAC, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x10, 0xBE, 0x00, 0x00, 0x00,
                0x14, 0x00, 0x00, 0x00, 0x00, 0xBF, 0xBE, 0x00, 0x00, 0x00, 0x04, 0x00,
                0x00, 0x00, 0x00, 0xBF, 0x04
            };

            var bufferActual = dataBuffer.Export(new ClusterWithStructAndTable()
            {
                Struct = new Struct()
                {
                    Table1 = new string[] { },
                    Table2 = new int[] { }
                }
            });

            Assert.Equal(bufferExpected, bufferActual);
        }

        private struct ClusterWithCharTable
        {
            [ClusterFieldName("TABLE")]
            [CharTable(10)]
            public string[] Table { get; set; }
        }

        private struct ClusterWithInt4Table
        {
            [ClusterFieldName("TABLE")]
            [Int4Table()]
            public int[] Table { get; set; }
        }

        private struct ClusterWithStructAndTable
        {
            [ClusterFieldName("STRUCT")]
            [DeepStruct]
            public Struct Struct { get; set; }
        }

        private struct Struct
        {
            [CharTable(10)]
            public string[] Table1 { get; set; }

            [Int4Table]
            public int[] Table2 { get; set; }
        }
    }
}
