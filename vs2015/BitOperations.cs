using System;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
    public static class BitOperations
    {
        public static int Log2( uint value )
        {
            int result = 0;
            while ( value != 0 )
            {
                value >>= 1;
                result++;
            }
            return result;
        }
    }
}
