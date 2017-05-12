﻿using SSP.Servidor;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControlPenales
{
    partial class RegistroIngresoViewModel
    {
        #region Datos Traslado
        private ObservableCollection<TRASLADO_MOTIVO> lstMotivoTraslado;
        public ObservableCollection<TRASLADO_MOTIVO> LstMotivoTraslado
        {
            get { return lstMotivoTraslado; }
            set { lstMotivoTraslado = value; OnPropertyChanged("LstMotivoTraslado"); }
        }

        private ObservableCollection<EMISOR> lstCentroOrigenTraslado;
        public ObservableCollection<EMISOR> LstCentroOrigenTraslado
        {
            get { return lstCentroOrigenTraslado; }
            set { lstCentroOrigenTraslado = value; OnPropertyChanged("LstCentroOrigenTraslado"); }
        }


        private int id_autoridad_traslado;
        private string autoridad_traslado;
        public string Autoridad_Traslado
        {
            get { return autoridad_traslado; }
            set { autoridad_traslado = value; OnPropertyChanged("Autoridad_Traslado"); }
        }


        private bool justificacion = true;
        public bool Justificacion
        {
            get { return justificacion; }
            set { justificacion = value; }
        }

        private short? dTMotivo;
        public short? DTMotivo
        {
            get { return dTMotivo; }
            set
            {
                dTMotivo = value;
                if (dTMotivo.HasValue)
                    OnPropertyValidateChanged("DTMotivo");
                else
                    OnPropertyChanged("DTMotivo");
            }
        }

        private string dTJustificacion;
        public string DTJustificacion
        {
            get { return dTJustificacion; }
            set
            {
                dTJustificacion = value;
                if (!string.IsNullOrWhiteSpace(dTJustificacion))
                    OnPropertyValidateChanged("DTJustificacion");
                else
                    OnPropertyChanged("DTJustificacion");
            }
        }

        private int? dTCentroOrigen;
        public int? DTCentroOrigen
        {
            get { return dTCentroOrigen; }
            set
            {
                dTCentroOrigen = value;
                if (dTCentroOrigen.HasValue)
                    OnPropertyValidateChanged("DTCentroOrigen");
                else
                    OnPropertyChanged("DTCentroOrigen");
            }
        }

        private string dTNoOficio;
        public string DTNoOficio
        {
            get { return dTNoOficio; }
            set
            {
                dTNoOficio = value;
                if (!string.IsNullOrWhiteSpace(dTNoOficio))
                    OnPropertyValidateChanged("DTNoOficio");
                else
                    OnPropertyChanged("DTNoOficio");
            }
        }

        private string dtCentroNombre;
        public string DTCentroNombre
        {
            get { return dtCentroNombre; }
            set { dtCentroNombre = value; RaisePropertyChanged("DTCentroNombre"); }
        }

        #endregion

        #region Ampliar Descripcion
        private string tituloHeaderExpandirDescripcion;
        public string TituloHeaderExpandirDescripcion
        {
            get { return tituloHeaderExpandirDescripcion; }
            set { tituloHeaderExpandirDescripcion = value; OnPropertyChanged("TituloHeaderExpandirDescripcion"); }
        }

        private string textAmpliarDescripcion;
        public string TextAmpliarDescripcion
        {
            get { return textAmpliarDescripcion; }
            set { textAmpliarDescripcion = value; OnPropertyChanged("TextAmpliarDescripcion"); }
        }

        private short maxLengthAmpliarDescripcion = 1000;
        public short MaxLengthAmpliarDescripcion
        {
            get { return maxLengthAmpliarDescripcion; }
            set { maxLengthAmpliarDescripcion = value; OnPropertyChanged("MaxLengthAmpliarDescripcion"); }
        }

        
        #endregion
    }
}