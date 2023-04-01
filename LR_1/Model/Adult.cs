using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Adult : PersonBase
    {
        /// <summary>
        /// Паспортные данные персоны (серия и номер).
        /// </summary>
        private int _seriesAndNumber;

        /// <summary>
        /// Чтение и запись паспортных данных.
        /// </summary>
        public int SeriesAndNumber
        {
            get
            { 
                return _seriesAndNumber; 
            } 
            set 
            { 
                _seriesAndNumber = value; 
            } 
        }

        /// <summary>
        /// Чтение и запись состояние брака.
        /// </summary>
        public StateOfMarriage StateOfMarriage { get; set; }

        /// <summary>
        /// Чтение и запись супруги / супруга.
        /// </summary>
        public Adult Spouse { get; set; }

        /// <summary>
        /// Место работы персоны.
        /// </summary>
        public string Job { get; set; }
    }
}
