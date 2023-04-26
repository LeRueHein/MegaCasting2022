using MegaCasting.WPFClient.ViewModels;
using MegaCasting2022.DBLib.Class;
using Microsoft.EntityFrameworkCore;
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

namespace MegaCasting.WPFClient.Views
{
    /// <summary>
    /// Logique d'interaction pour PartnerView.xaml
    /// </summary>
    public partial class PartnerView : UserControl
    {
        public DbSet<PartenaireDiffusion> PartenaireDiffusions { get; set; }

        #region Attributes
        /// <summary>
        /// Context
        /// </summary>
        private MegaCastingSymfonyContext _Entities;
        public MegaCastingSymfonyContext Entities
        {
            get { return _Entities; }
            private set { _Entities = value; }
        }
        
        #endregion

        public PartnerView()
        {
            InitializeComponent();
        }

        private void SaveDiffusionPartner_Click(object sender, RoutedEventArgs e)
        {
            ((PartnerViewModel)this.DataContext).Save();
        }
        /// <summary>
        /// add partner
        /// </summary>
        private void AddDiffusionPartner_Click(object sender, RoutedEventArgs e) =>  ((PartnerViewModel)this.DataContext).Add();

        /// <summary>
        /// delete partner
        /// </summary>
        private void DeleteDiffusionPartner_Click(object sender, RoutedEventArgs e) =>  ((PartnerViewModel)this.DataContext).Remove();

        private void Login_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();


        private void Password_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();


        /// <summary>
        /// check si les champs sont remplis
        /// </summary>
        private void CheckAddButtonEnability()
        {
            this.AddDiffusionPartner.IsEnabled =
                (!string.IsNullOrWhiteSpace(Login.Text)
                && !string.IsNullOrWhiteSpace(Password.Text)
                );
        }
    }
}
