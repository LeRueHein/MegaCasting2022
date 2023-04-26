using MegaCasting2022.DBLib.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPFClient.ViewModels
{
    public class OfferViewModel : ViewModelBase
    {
        private ObservableCollection<OffreCasting> _OffreCastings;

        public ObservableCollection<OffreCasting> OffreCastings
        {
            get { return _OffreCastings; }
            set { _OffreCastings = value; }
        }

        private OffreCasting _SelectedOffreCasting;

        public OffreCasting SelectedOffreCasting
        {
            get { return _SelectedOffreCasting; }
            set { _SelectedOffreCasting = value; }
        }

        private OffreCasting _OffreCastingToAdd;

        public OffreCasting OffreCastingToAdd
        {
            get { return _OffreCastingToAdd; }
            set { _OffreCastingToAdd = value; }
        }

        private ObservableCollection<TypeContrat> _TypeContrats;

        public ObservableCollection<TypeContrat> TypeContrats
        {
            get { return _TypeContrats; }
            set { _TypeContrats = value; }
        }

        private TypeContrat _SelectedTypeContrat;

        public TypeContrat SelectedTypeContrat
        {
            get { return _SelectedTypeContrat; }
            set { _SelectedTypeContrat = value; }
        }

        private ObservableCollection<DomaineMetier> _DomaineMetiers;

        public ObservableCollection<DomaineMetier> DomaineMetiers
        {
            get { return _DomaineMetiers; }
            set { _DomaineMetiers = value; }
        }

        private DomaineMetier _SelectedDomaineMetier;

        public DomaineMetier SelectedDomaineMetier
        {
            get { return _SelectedDomaineMetier; }
            set { _SelectedDomaineMetier = value; }
        }

        private ObservableCollection<Metier> _Metiers;

        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        private Metier _SelectedMetier;
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }

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

         public OfferViewModel(MegaCastingSymfonyContext entities)
            : base(entities)
        {
            this.OffreCastingToAdd = new OffreCasting()
            {
                OffreDateStart = DateTime.Now,
                OffreDateEnd = DateTime.Now,
                ParutionDateTime = DateTime.Now,
            };
            this.Entities.OffreCastings.ToList();
            this.OffreCastings = this.Entities.OffreCastings.Local.ToObservableCollection();
            this.Entities.Clients.ToList();
            this.Clients = this.Entities.Clients.Local.ToObservableCollection();
            this.Entities.TypeContrats.ToList();
            this.TypeContrats = this.Entities.TypeContrats.Local.ToObservableCollection();

            
            this.Entities.OffreCastings
                .Include(o => o.IdentifiantOffreCastingsNavigation)
                
                .Include(o => o.IdentifiantOffreCastings)
                .ToList();

            this.Metiers = this.Entities.Metiers.Local.ToObservableCollection();
        }

        public void Add()
        {
            this.Entities.OffreCastings.Add(this.OffreCastingToAdd);
            //this.OffreCastingToAdd = new OffreCasting();
            this.Entities.SaveChanges();

        }


        public void Remove()
        {
            if (this.SelectedOffreCasting != null)
            {
                this.Entities.OffreCastings.Remove(this.SelectedOffreCasting);
                this.Entities.SaveChanges();
            }
        }



    }
}
