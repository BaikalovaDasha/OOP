using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class RandomPersonGenerator
    {
        public static Person Person
        {
            get
            {
                Random random = new Random();
                return new Person("Иванов", "Иван", random.Next(0, 110), Gender.Female);
            }
        }
    }
}
