﻿
namespace ControlPenales
{
    partial class AreaTecnicaViewModel
    {
        #region Validacion
        private void setValidationRules()
        {
            base.ClearRules();
            base.AddRule(() => Descripcion, () => !string.IsNullOrEmpty(Descripcion), "DESCRIPCIÓN ES REQUERIDA!");
            //base.AddRule(() => SelectedEstatus, () => SelectedEstatus != null, "ESTATUS ES REQUERIDO!");
        }
        #endregion
    }
}