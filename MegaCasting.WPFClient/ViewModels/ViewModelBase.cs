using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCasting2022.DBLib.Class;

namespace MegaCasting.WPFClient.ViewModels
{
    /// <summary>
    /// ViewModel de base
    /// ne peut être instancié directement
    /// </summary>
    public abstract class ViewModelBase
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

        #region Constructors
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="megaCastingSymfonycONTEXT">Contexte de l'application</param>
        public ViewModelBase(MegaCastingSymfonyContext megaCastingSymfonycONTEXT)
        {
            this._Entities = megaCastingSymfonycONTEXT;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Sauvegarde les modifications de la base de donnnées
        /// </summary>
        public void Save() => this.Entities.SaveChanges();

        #endregion
    }
}
