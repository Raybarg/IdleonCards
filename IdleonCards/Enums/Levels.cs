using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleonCards.Enums
{
    /// <summary>
    /// Card levels
    /// </summary>
    public enum Levels
    {
        /// <summary>
        /// Has not been found yet
        /// </summary>
        NotFound = 0,
        /// <summary>
        /// Has been found but no star upgrades
        /// </summary>
        Found = 1,
        /// <summary>
        /// One star upgrade
        /// </summary>
        Star1 = 2,
        /// <summary>
        /// Two star upgrade
        /// </summary>
        Star2 = 3,
        /// <summary>
        /// Three star upgrade
        /// </summary>
        Star3 = 4
    }
}
