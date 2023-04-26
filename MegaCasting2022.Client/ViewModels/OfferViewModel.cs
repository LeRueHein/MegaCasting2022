using MegaCasting2022.DBLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCasting2022.Client.ViewModels
{
    public class OfferViewModel : ViewModelBase
    {
        private ObservableCollection<ContractType> _ContractTypes;

        public ObservableCollection<ContractType> ContractTypes
        {
            get { return _ContractTypes; }
            set { _ContractTypes = value; }
        }


        private ContractType _SelectedContractType;

        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }


        public OfferViewModel(MegaCastingCsharpContext megaCastingCsharpContext)
            : base(megaCastingCsharpContext)
        {
            this.Entities.ContractTypes.ToList();
            this.ContractTypes = this.Entities.ContractTypes.Local.ToObservableCollection();


        }
    }
}
