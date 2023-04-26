using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCasting2022.DBLib.Class;

namespace MegaCasting2022.Client.ViewModels
{
    /// <summary>
    /// View modèle de base
    /// ne peut être instancié directement
    /// </summary>
    public abstract class ViewModelBase
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

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="megaCastingCsharpContext">contexte de l'application</param>
        public ViewModelBase(MegaCastingCsharpContext megaCastingCsharpContext)
        {
            this._Entities = megaCastingCsharpContext;
        }


        #endregion

        #region Methods

        /// <summary>
        /// Sauvegarde les modifications de la base de données
        /// </summary>
        public void Save() => this.Entities.SaveChanges();

        #endregion
    }
}
