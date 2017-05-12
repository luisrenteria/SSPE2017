﻿using System.Windows.Input;

namespace ControlPenales
{
    partial class CatalogoColoniasViewModel
    {
        private ICommand _onClick;
        public ICommand OnClick
        {
            get { return _onClick ?? (_onClick = new RelayCommand(ClickSwitch)); }
        }

        private ICommand _buscarClick;
        public ICommand BuscarClick
        {
            get { return _buscarClick ?? (_buscarClick = new RelayCommand(ClickEnter)); }
        }

        public ICommand ColoniaLoading
        {
            get { return new DelegateCommand<CatalogoColoniasView>(ColoniaLoad); }
        }
    }
}
