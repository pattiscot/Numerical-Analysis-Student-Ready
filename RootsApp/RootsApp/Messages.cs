namespace RootsApp
{
    //public class Errors
    //{
    //    public enum ROOT_ERRORS { NONE, SAME_SIGN, DIVISION_BY_ZERO, RUNAWAY, CYCLE };
    //}
    public class Messages
    {

        public enum ROOT_ERRORS { NONE, SAME_SIGN, DIVISION_BY_ZERO, RUNAWAY, CYCLE };
        public static void DivisionByZeroError(RootObj r)
        {
            //Root r = new Root();
            r.root = double.NaN;
            r.error = (int)ROOT_ERRORS.DIVISION_BY_ZERO;
            //return r;
        }

        public static void SameSign(RootObj r)
        {

            r.root = double.NaN;
            r.error = (int)ROOT_ERRORS.SAME_SIGN;

        }

        public static void RunawayError(RootObj r)
        {
            //Root r = new Root();
            r.root = double.NaN;
            r.error = (int)ROOT_ERRORS.RUNAWAY;
            //return r;
        }

        public static void CycleError(RootObj r)
        {
            //Root r = new Root();
            r.root = double.NaN;
            r.error = (int)ROOT_ERRORS.CYCLE;
            //return r;
        }
    }
}
