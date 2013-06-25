﻿namespace StartProcessAsUser.PInvoke
{
    using System;
    using System.Runtime.InteropServices;

    internal partial class NativeMethods
    {
        [StructLayout(LayoutKind.Sequential)]
        public class SecurityAttributes
        {
            public Int32 Length = 0;
            public IntPtr lpSecurityDescriptor = IntPtr.Zero;
            public bool bInheritHandle = false;

            public SecurityAttributes()
            {
                this.Length = Marshal.SizeOf(this); 
            }
        }
    }
}
