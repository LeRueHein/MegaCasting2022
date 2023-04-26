using MegaCasting2022.Client.ViewModels;
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

namespace MegaCasting2022.Client.Views
{
    /// <summary>
    /// Logique d'interaction pour OfferView.xaml
    /// </summary>
    public partial class OfferView : UserControl
    {
        public OfferView()
        {
            InitializeComponent();

        }

        private void SaveContractType_Click(object sender, RoutedEventArgs e)
        {
            ((OfferViewModel)this.DataContext).Save();
        }
    }
}
