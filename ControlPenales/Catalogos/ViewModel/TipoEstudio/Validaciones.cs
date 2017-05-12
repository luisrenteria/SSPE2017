﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlPenales
{
 partial class CatalogoTipoEstudioViewModel
    {
     private void setValidationRules()
     {
         base.ClearRules();
         base.AddRule(() => Descripcion, () => !string.IsNullOrEmpty(Descripcion), "DESCRIPCIÓN ES REQUERIDA!");
         base.AddRule(() => SelectedEstatus, () => SelectedEstatus != null, "ESTATUS ES REQUERIDO!");
     }


    }
}