﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Blake3Core
{
    class Output
    {
        public ChainingValue ChainingValue { get; private set; }

        public Output(ReadOnlyMemory<uint> key,
                      ReadOnlyMemory<uint> block,
                      ulong counter = 0,
                      int blockLen = Blake3.BlockLength,
                      Flag flag = Flag.None)
        {
            State s;
        }

        public byte[] GetRootBytes(int count)
        {
            //$ TODO: NYI
            return null;
        }
    }
}
