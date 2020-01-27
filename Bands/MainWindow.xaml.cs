using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //create lists to hold all bands available
        List<Band> bands = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();
            CreateBands();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e) //create band objects list and sort it
        {
            CreateBands();
            bands.Sort();                              //sorts the bands list using the icomparable compareTo    
        }

        private List<Band> CreateBands()           //method to create and return the list of bands
        {
            //band objects are created
            Band B1 = new PopBand()
            {
                BandName = "Shpongle",
                YearFormed = 1996,
                Members = "Simon Posford, Raja Ram",
            };
            Band B2 = new PopBand()
            {
                BandName = "Younger Brother",
                YearFormed = 2003,
                Members = "Simon Posford, Benji Vaughan",
            };

            //add the above bands to the bands list
            bands.Add(B1);
            bands.Add(B2);
            
            //return the completed list
            return bands;

        }

        private void BandsLstBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selected = BandsLstBx.SelectedItem as Band;
            if (selected != null)
                BandInfoTxtBlck.Text = selected.ToString();
                AlbumTxtBlck.Text = selected.Albums.ToString();
        }
    }
}
