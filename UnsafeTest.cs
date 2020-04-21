using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Xunit;

namespace Tests
{
    public class UnsafeTests
    {
        [Fact]
        public static unsafe void WriteInt32()
        {
            int value = 10;
            int* address = (int*)Unsafe.AsPointer(ref value);
            int expected = 20;
            Unsafe.Write(address, expected);

            Assert.Equal(expected, value);
            Assert.Equal(expected, *address);
            Assert.Equal(expected, Unsafe.Read<int>(address));
        }
    }
}
