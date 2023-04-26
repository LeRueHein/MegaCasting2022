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
using MegaCasting2022.Client.Views;
using MegaCasting2022.Client.ViewModels;
using MegaCasting2022.DBLib.Class;

namespace MegaCasting2022.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        #region Attributes

        /// <summary>
        /// Contexte
        /// </summary>
        private MegaCastingCsharpContext _Entities;

        #endregion

        #region Properties 

        /// <summary>
        /// Obtient le contexte
        /// </summary>
        public MegaCastingCsharpContext Entities
        {
            get { return _Entities; }
            private set { _Entities = value; }
        }

        #endregion

        #region Constructor

        public MainWindow()
        {
            InitializeComponent();

            this.Entities = new MegaCastingCsharpContext();
        }
        #endregion

        #region Methods

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();
            HomeView view = new HomeView();
            this.DockPanelView.Children.Add(view);
        }

        private void ButtonOffer_Click(object sender, RoutedEventArgs e)
        {
            OfferViewModel viewModel = new OfferViewModel(this.Entities);
            this.DockPanelView.Children.Clear();
            OfferView view = new OfferView();

            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        #endregion
    }
}
