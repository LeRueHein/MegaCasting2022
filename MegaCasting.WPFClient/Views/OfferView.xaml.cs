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
    /// Logique d'interaction pour OfferView.xaml
    /// </summary>
    public partial class OfferView : UserControl
    {
        public DbSet<OffreCasting> OffreCastings { get; set; }

        public DbSet<TypeContrat> ContractTypes { get; set; }


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

        public OfferView()
        {
            InitializeComponent();

        }

        private void SaveOffer_Click(object sender, RoutedEventArgs e)
        {
            ((OfferViewModel)this.DataContext).Save();
        }
        /// <summary>
        /// add offre
        /// </summary>
       private void AddOffer_Click(object sender, RoutedEventArgs e) => ((OfferViewModel)this.DataContext).Add();

        /// <summary>
        /// delete client
        /// </summary>
        private void DeleteOffer_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette offre ?", "Confirmation", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes) 
            {

                ((OfferViewModel)this.DataContext).Remove();

            }
            

        }


        private void Libel_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        private void Reference_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        private void Localisation_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        private void ParutionDateTime_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => this.CheckAddButtonEnability();
      
        private void OffreDateStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => this.CheckAddButtonEnability();
       
        private void OffreDateEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e) => this.CheckAddButtonEnability();


        /// <summary>
        /// check si les champs sont remplis
        /// </summary>
        private void CheckAddButtonEnability()
        {
            this.AddOffer.IsEnabled =
                (!string.IsNullOrWhiteSpace(Localisation.Text)
                && !string.IsNullOrWhiteSpace(Libel.Text)
                && ParutionDateTime.SelectedDate != null
                && OffreDateStart.SelectedDate != null
                && OffreDateEnd.SelectedDate != null
                && TypeContrat.SelectedItem != null
                && Client.SelectedItem != null
                && Metier.SelectedItem != null
                
                );
        }

        private void Client_SelectionChanged(object sender, SelectionChangedEventArgs e) => this.CheckAddButtonEnability();

        private void TypeContrat_SelectionChanged(object sender, SelectionChangedEventArgs e) => this.CheckAddButtonEnability();

        private void Metier_SelectionChanged(object sender, SelectionChangedEventArgs e) => this.CheckAddButtonEnability();
    }
}
