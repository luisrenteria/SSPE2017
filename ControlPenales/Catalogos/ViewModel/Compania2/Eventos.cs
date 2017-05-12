﻿using System.Windows.Input;

namespace ControlPenales
{
    partial class Compania2ViewModel
    {
        #region Click
        private ICommand _onClick;
        public ICommand OnClick
        {
            get { return _onClick ?? (_onClick = new RelayCommand(clickSwitch)); }
        }

        private ICommand _buscarClick;
        public ICommand BuscarClick
        {
            get { return _buscarClick ?? (_buscarClick = new RelayCommand(ClickEnter)); }
        }
        #endregion

        #region Load
        public ICommand CatalogoSimpleLoading
        {
            get { return new DelegateCommand<CatalogoSimpleNewView>(WindowLoad); }
        }
        #endregion
    }
}