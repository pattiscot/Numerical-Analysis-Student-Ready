using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootsApp
{
    public class Messages
    {
        public static IRoot DivisionByZeroError()
        {
            IRoot r = new Root();
            r.Root = double.NaN;
            r.Error = (int)Errors.ROOT_ERRORS.DIVISION_BY_ZERO;
            return r;
        }

        public static IRoot RunawayError()
        {
            IRoot r = new Root();
            r.Root = double.NaN;
            r.Error = (int)Errors.ROOT_ERRORS.RUNAWAY;
            return r;
        }

        public static IRoot CycleError()
        {
            IRoot r = new Root();
            r.Root = double.NaN;
            r.Error = (int)Errors.ROOT_ERRORS.CYCLE;
            return r;
        }
    }
}
