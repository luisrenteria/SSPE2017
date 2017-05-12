﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ControlPenales
{
    partial class CatalogoSubTipoServiciosAuxViewModel
    {
        #region Click

        private ICommand _onClick;
        public ICommand OnClick
        {
            get { return _onClick ?? (_onClick = new RelayCommand(ClickSwitch)); }
        }
        #endregion

        #region Load
        public ICommand CatalogoSubTipoServiciosAuxLoading
        {
            get { return new DelegateCommand<CatalogoSubTipoServiciosAuxView>(PageLoad); }
        }
        #endregion
    }
}
