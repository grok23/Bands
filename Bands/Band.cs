using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    class Band: IComparable
    {
        public string BandName { get; set; }
        public DateTime YearFormed { get; set; }
        public string Members { get; set; }





        //method to enable sorting by band names
        public int CompareTo(object obj)
        {
            //get reference to next object in list
            Band objectToCompareTo = obj as Band;

            //compare to is set to compare the ActivityDate
            int returnValue = this.BandName.CompareTo(objectToCompareTo.BandName);
            return returnValue;
        }
    }
}
