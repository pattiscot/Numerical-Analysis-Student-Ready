using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivativeEstimationApp
{
    public interface IDerivatives
    {
        /// <summary>
        /// These are parts of the Derivative Estimate Object. Note that
        /// DerEstimate is the estimated derivative at the point given
        /// Error is the error allowed by the user (either specified by 
        /// the user or calculated if the user supplies n).
        /// Iterations is the number of iterations necessary to calculate the 
        /// derivative estimate. Don't change this part of the program.
        /// </summary>
        double DerEstimate { get; set; }
        double Error { get; set; }
        int Iterations { get; set; }

        /// <summary>
        /// This should iteratively approximate the derivative of f. The Derivative object
        /// includes the approximate derivative, the approximate error of that derivative, 
        /// and the number of iterations used for this computation.
        /// </summary>
        /// <param name="x"> the x value that you wish to evaluate the derivative at</param>
        /// <param name="h"> the short distance h for Taylor approximation</param>
        /// <param name="f"> the function which you want to take the derivative of</param>
        /// <param name="epsilon">maximum allowable error determined by the user</param>
        /// <param name="maxFTriplePrime"> maximum of the third derivative on the interval
        /// - used in the error estimate. For sinx and cosx this is 1.</param>
        /// <returns></returns>

        void Derivative(double x, double h, Func<double, double> f, double epsilon, double maxFTriplePrime);
    }
}
