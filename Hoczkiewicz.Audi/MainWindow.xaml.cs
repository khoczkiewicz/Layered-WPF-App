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
using static Hoczkiewicz.Audi.INTERFACES.Interfaces;


namespace Hoczkiewicz.Audi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BL.BL BusinessLogisticsLayer = new BL.BL();
        //public List<string> auta = new List<string>();
        private List<IAudi> _audis;
        public List<IAudi> Audis
        {
            get { return _audis; }
            set { _audis = value; }
        }
        public MainWindow()
        {
            Audis = BusinessLogisticsLayer.GetDataBase();
            InitializeComponent();            
        }

        private void AudisList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
