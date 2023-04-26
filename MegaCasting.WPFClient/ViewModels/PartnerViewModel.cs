using MahApps.Metro.Converters;
using MegaCasting2022.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting.WPFClient.ViewModels
{
    public class PartnerViewModel : ViewModelBase
    {
        private ObservableCollection<PartenaireDiffusion> _PartenaireDiffusions;

        public ObservableCollection<PartenaireDiffusion> PartenaireDiffusions
        {
            get { return _PartenaireDiffusions; }
            set { _PartenaireDiffusions = value; }
        }

        private PartenaireDiffusion _SelectedPartner;

        public PartenaireDiffusion SelectedPartner
        {
            get { return _SelectedPartner; }
            set { _SelectedPartner = value; }
        }


        private PartenaireDiffusion _PartnerToAdd;

        public PartenaireDiffusion PartnerToAdd
        {
            get { return _PartnerToAdd; }
            set { _PartnerToAdd = value; }
        }


        public PartnerViewModel(MegaCastingSymfonyContext entites)
            : base(entites)
        {
            this.PartnerToAdd = new PartenaireDiffusion();
            this.Entities.PartenaireDiffusions.ToList();
            this.PartenaireDiffusions = this.Entities.PartenaireDiffusions.Local.ToObservableCollection();

        }

        public void Add()
        {
            this.Entities.PartenaireDiffusions.Add(this.PartnerToAdd);
           
            //this.PartnerToAdd = new PartenaireDiffusion();
            this.Entities.SaveChanges();
        }

        
        public void Remove()
        {
            if (this.SelectedPartner != null)
            {
                this.Entities.PartenaireDiffusions.Remove(this.SelectedPartner);
                this.Entities.SaveChanges();
            }
        }


    }
}
