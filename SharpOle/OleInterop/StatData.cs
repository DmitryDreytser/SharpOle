﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpOle.OleInterop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct StatData
    {
        public FormatEtc FORMATETC;
        public uint ADVF;
        [MarshalAs(UnmanagedType.Interface)]
        public IAdviseSink pAdvSink;
        public uint dwConnection;
    }
}
