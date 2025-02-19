using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public enum ROOT_ERRORS { NONE, DIVISION_BY_ZERO, RUNAWAY, CYCLE, SAME_SIGN };
    }
}
