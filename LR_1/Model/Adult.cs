using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Adult : PersonBase
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

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Adult(string name, string surname, int age, Gender gender)
            : base (name, surname, age, gender)
        {

        }
    }
}
