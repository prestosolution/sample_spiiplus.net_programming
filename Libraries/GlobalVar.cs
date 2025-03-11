using System;
using System.Linq.Expressions;

namespace ACS.Helpers
{
    internal class GlobalVar
    {
        public const int MAX_AXES = (int)SPiiPlusNET.Axis.ACSC_AXIS_64;

        public static bool Connected = false;
    }
}
