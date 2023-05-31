using MegaCasting2022.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCasting.WPFClient.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {


        private ObservableCollection<Client> _Clients;

        public ObservableCollection<Client> Clients
        {
            get { return _Clients; }
            set { _Clients = value; }
        }

        private Client _SelectedClient;

        public Client SelectedClient
        {
            get { return _SelectedClient; }
            set { _SelectedClient = value; }
        }

        private Client _ClientToAdd;

        public Client ClientToAdd
        {
            get { return _ClientToAdd; }
            set { _ClientToAdd = value; }
        }

        public ClientViewModel(MegaCastingSymfonyContext entities)
           : base(entities)
        {
            this.ClientToAdd = new Client();
            this.Entities.Clients.ToList();
            this.Clients = this.Entities.Clients.Local.ToObservableCollection();

        }

        public void Add()
        {
            this.Entities.Clients.Add(this.ClientToAdd);

            //this.ClientToAdd = new Client();
            this.Entities.SaveChanges();
        }


        public void Remove()
        {
            if (this.SelectedClient != null)
            {
            
                if (this.SelectedClient.OffreCastings.Count > 0)
                {
                    MessageBox.Show("vous ne pouvez pas supprimer un client qui à une offre");
                    return;
                }
                else
                {
                    this.Entities.Clients.Remove(this.SelectedClient);
                    this.Entities.SaveChanges();
                }
             
                
            }
        }
    }
}
