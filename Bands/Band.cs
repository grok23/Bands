using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bands
{
    public abstract class Band : IComparable
    {
        //properties for all bands
        public string BandName { get; set; }
        public int YearFormed { get; set; }
        public string Members { get; set; }
        
        //Albums list generation and retrieval
        private List<Album> albums = new List<Album>();
        public List<Album> Albums
        {
            get { return albums; }
            set { albums = value; }
        }

        public override string ToString()
        {
            return string.Format($"{BandName} - Formed {YearFormed} - Members {Members}");
        }



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
          //List <Album> Albums = new List <Album>();   //should move generation of List of albums to the band class, as it's currently just being repeated in each sub class
        }

        public override string ToString()
        {
            return (this.BandName + " - Rock");
        }

    }

    public class PopBand : Band
    {
        public PopBand()
        {
           // List<Album> Albums = new List<Album>();
        }

        public override string ToString()
        {
            return (this.BandName + " - Pop");
        }

    }

    public class IndieBand : Band
    {
        public IndieBand()
        {
            //List<Album> Albums = new List<Album>();
        }

        public override string ToString()
        {
            return (this.BandName + " - Indie");
        }
    }
}
