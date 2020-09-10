using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MakeYourBodyMove
{
    class Win32
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;

            public override bool Equals(object obj)
            {
                if (!(obj is POINT))
                {
                    return false;
                }

                var pOINT = (POINT)obj;
                return x == pOINT.x &&
                       y == pOINT.y;
            }

            public override int GetHashCode()
            {
                var hashCode = 1502939027;
                hashCode = hashCode * -1521134295 + x.GetHashCode();
                hashCode = hashCode * -1521134295 + y.GetHashCode();
                return hashCode;
            }

            public static bool operator ==(POINT pOINT1, POINT pOINT2)
            {
                return pOINT1.Equals(pOINT2);
            }

            public static bool operator !=(POINT pOINT1, POINT pOINT2)
            {
                return !(pOINT1 == pOINT2);
            }
        }
    }
}
