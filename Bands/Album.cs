using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    class Album
    {
        public string Name { get; set; }
        public int Released { get; set; }
        public int Sales { get; set; }

        //random number generation for album release year
        private static readonly Random getRandomYear = new Random();

        public static int GetRandomYear(int min, int max)
        {
            lock(getRandomYear) // synchronize
            {
                return getRandomYear.Next(min, max);
            }
        }

        //full constructor for album
        public Album(string name, int released, int sales)
        {
            this.Name = name;
            this.Released = released;
            this.Sales = sales;
        }

        //partial constructor which will be adapted to use RNG for release date
        public Album(string name, int sales)
        {
            this.Name = name;
            this.Sales = sales;
            this.Released = GetRandomYear(1960,2020); // currently using 1995 as earliest possible album date, might be nice to set it to not allow a year to be before band formation date
        }

    }
}
