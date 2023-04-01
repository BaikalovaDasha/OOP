using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Child : PersonBase
    {
        /// <summary>
        /// Мама.
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// папа
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Информация о детском саду или школе.
        /// </summary>
        public string JobChild { get; set; }
    }
}
