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

        public Album(string name, int released, int sales)
        {
            this.Name = name;
            this.Released = released;
            this.Sales = sales;
        }
    }
}
