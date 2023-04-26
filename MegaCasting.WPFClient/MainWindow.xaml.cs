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
using MahApps.Metro.Controls;
using MegaCasting.WPFClient.ViewModels;
using MegaCasting.WPFClient.Views;
using MegaCasting2022.DBLib.Class;

namespace MegaCasting.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        #region Attributes
        /// <summary>
        /// Context
        /// </summary>
        private MegaCastingSymfonyContext _Entities;
        #endregion

        #region Properties
        /// <summary>
        /// Obtient le context
        /// </summary>
        public MegaCastingSymfonyContext Entities
        {
            get { return _Entities; }
            private set { _Entities = value; }

        }
        #endregion

        #region Constructor

        #endregion

        #region Methods
        public MainWindow()
        {
            InitializeComponent();
            this.Entities = new MegaCastingSymfonyContext();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            HomeView view = new HomeView();
            this.DockPanelView.Children.Add(view);
        }

        private void ButtonOffer_Click(object sender, RoutedEventArgs e)
        {


            OfferViewModel offerViewModel = new OfferViewModel(this.Entities);
            this.DockPanelView.Children.Clear();
            OfferView view = new OfferView();

            view.DataContext = offerViewModel; 

            this.DockPanelView.Children.Add(view);
        }
        private void ButtonPartner_Click(object sender, RoutedEventArgs e)
        {
            PartnerViewModel partnerViewModel = new PartnerViewModel(this.Entities);
            this.DockPanelView.Children.Clear();
            PartnerView view = new PartnerView();

            view.DataContext = partnerViewModel;
            this.DockPanelView.Children.Add(view);
        }

        private void ButtonClient_Click(object sender, RoutedEventArgs e)
        {
            ClientViewModel clientViewModel = new ClientViewModel(this.Entities);
            this.DockPanelView.Children.Clear();
            ClientView view = new ClientView();

            view.DataContext = clientViewModel;

            this.DockPanelView.Children.Add(view);
        }

        
        #endregion


    }
}
