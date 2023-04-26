using ControlzEx.Standard;
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
    /// Logique d'interaction pour ClientView.xaml
    /// </summary>
    public partial class ClientView : UserControl
    {

        public DbSet<Client> Clients { get; set; }

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
        
        public ClientView()
        {
            InitializeComponent();
        }

        private void SaveClient_Click(object sender, RoutedEventArgs e)
        {
            ((ClientViewModel)this.DataContext).Save();
        }
        /// <summary>
        /// add client
        /// </summary>
        private void AddClient_Click(object sender, RoutedEventArgs e) => ((ClientViewModel)this.DataContext).Add();

        /// <summary>
        /// delete client
        /// </summary>
        private void DeleteClient_Click(object sender, RoutedEventArgs e) => ((ClientViewModel)this.DataContext).Remove();

        private void Nom_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        private void Telephone_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        private void Email_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        private void Ville_TextChanged(object sender, TextChangedEventArgs e) => this.CheckAddButtonEnability();

        
        /// <summary>
        /// check si les champs sont remplis
        /// </summary>
        private void CheckAddButtonEnability()
        {
            this.AddClient.IsEnabled =
                (!string.IsNullOrWhiteSpace(Nom.Text)
                && !string.IsNullOrWhiteSpace(Telephone.Text)
                && !string.IsNullOrWhiteSpace(Email.Text)
                && !string.IsNullOrWhiteSpace(Ville.Text)
                );
        }
    }
    
}
