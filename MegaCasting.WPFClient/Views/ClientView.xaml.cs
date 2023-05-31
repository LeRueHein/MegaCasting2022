using ControlzEx.Standard;
using MegaCasting.WPFClient.ViewModels;
using MegaCasting2022.DBLib.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        Boolean EmailValide = false;

        private void AddClient_Click(object sender, RoutedEventArgs e) {
            if (EmailValide == true)
            {
                ((ClientViewModel)this.DataContext).Add();
            } else
            {
                MessageBox.Show("L'email n'est pas valide, il doit contenir un @");
            }
        }
        /// <summary>
        /// delete client
        /// </summary>
        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette offre ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes) 
            { 
                ((ClientViewModel)this.DataContext).Remove(); 
            }
            
        }

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

        private void Telephone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            /// Vérifie si le texte entré ne contient que des chiffres
            if (!IsTextAllowed(e.Text))
            {
                /// Empêche la saisie de texte si elle ne contient pas que des chiffres
                e.Handled = true;
            }
        }

        private bool IsTextAllowed(string text)
        {
            /// Expression régulière pour valider uniquement les nombres
            Regex regex = new Regex("[^0-9]+"); /// Seul des nombres

            return !regex.IsMatch(text);
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Email.Text.Contains("@") || string.IsNullOrEmpty(Email.Text))
            {
                /// Forcer le caractere @ 
                EmailValide = true;
            }
            else
            {
                /// si le caractère "@" n'est pas présent dans l'email
                /// Message erreur
                EmailValide = false;
                MessageBox.Show("L'email n'est pas valide");

            }
        }

        

    }
    
}
