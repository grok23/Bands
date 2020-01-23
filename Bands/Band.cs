using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    public abstract class Band : IComparable
    {
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }
        public string[] Albums { get; set; }





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

    public class RockBand : Band
    {
        public RockBand()
        {
            Albums = new Album[10];
        }

        public override string ToString()
        {
            return (this.BandName + " - Rock");
        }

    }
}
