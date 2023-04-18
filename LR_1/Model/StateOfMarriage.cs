using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Перечисление состояний брака.
    /// </summary>
    public enum StateOfMarriage
    {
        /// <summary>
        /// Состояние брака: не замужем / не женат
        /// </summary>
        notMarried,

        /// <summary>
        /// Состояние брака: разведена / разведён
        /// </summary>
        divorced,

        /// <summary>
        /// Состояние брака: замужем / женат
        /// </summary>
        married,
    }
}
