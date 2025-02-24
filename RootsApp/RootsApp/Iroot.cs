namespace RootsApp
{
    /// <summary>
    /// Interface which you must implement and use as the return values in IRoots
    /// </summary>
    public interface IRoot
    {
        double Root { get; set; }
        int Error { get; set; }


    }
    /// <summary>
    /// If you cannot return a root, set one of the errors below using IRoot above.
    /// </summary>
    public class Errors
    {
<<<<<<< HEAD
        public enum ROOT_ERRORS { NONE, SAME_SIGN, DIVISION_BY_ZERO, RUNAWAY, CYCLE };
=======
        public enum ROOT_ERRORS { NONE, DIVISION_BY_ZERO, RUNAWAY, CYCLE, SAME_SIGN };
>>>>>>> 6d4d72e403905b5e7aff6b30b90c8366378bc2ed
    }
}
