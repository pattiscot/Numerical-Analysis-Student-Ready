namespace RootsApp
{
    public class Messages
    {
        public static void DivisionByZeroError(Root r)
        {
            //Root r = new Root();
            r.root = double.NaN;
            r.error = (int)Errors.ROOT_ERRORS.DIVISION_BY_ZERO;
            //return r;
        }

<<<<<<< HEAD
        public static void SameSign(Root r)
=======
        public static IRoot SameSign()
        {
            IRoot r = new Root();
            r.Root = double.NaN;
            r.Error = (int)Errors.ROOT_ERRORS.SAME_SIGN;
            return r;
        }

        public static IRoot RunawayError()
>>>>>>> 6d4d72e403905b5e7aff6b30b90c8366378bc2ed
        {

            r.root = double.NaN;
            r.error = (int)Errors.ROOT_ERRORS.SAME_SIGN;

        }

        public static void RunawayError(Root r)
        {
            //Root r = new Root();
            r.root = double.NaN;
            r.error = (int)Errors.ROOT_ERRORS.RUNAWAY;
            //return r;
        }

        public static void CycleError(Root r)
        {
            //Root r = new Root();
            r.root = double.NaN;
            r.error = (int)Errors.ROOT_ERRORS.CYCLE;
            //return r;
        }
    }
}
