﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Threading.Tasks;

namespace ControlPenales
{
    class AlmacenViewModel : ValidationViewModelBase, IPageViewModel
    {

        #region constructor
        public AlmacenViewModel()
        {
        }
        void IPageViewModel.inicializa()
        {
            CatalogoHeader = "Almacen";
            HeaderAgregar = "Agregar Almacen";
            ComboBoxLigado = "Tipo de Almacen";
            NewItem = new Usuario();
            UpdateItem = new Usuario();
            //LLENAR 
            EditarVisible = false;
            NuevoVisible = false;
            FiltroVisible = false;
            ListItems = new ObservableCollection<Usuario>();
            ListItems.Add(new Usuario() { Username = "PRUEBAS", Password = "TIPO 1" });
            ListItems.Add(new Usuario() { Username = "TEST", Password = "TIPO 2" });
            ListaEjemplo = new List<string>() { "TIPO 1", "TIPO 2" };

            AgregarVisible = false;

            GuardarMenuEnabled = false;
            AgregarMenuEnabled = true;
            EliminarMenuEnabled = false;
            EditarMenuEnabled = false;
            CancelarMenuEnabled = false;
            AyudaMenuEnabled = true;
            SalirMenuEnabled = true;
            ExportarMenuEnabled = true;

            SeleccionIndice = -1;
        }

        #endregion

        #region variables
        public string Name
        {
            get
            {
                return "catalogo_almacen";
            }
        }

        #region Otros
        private List<string> listaEjemplo;
        public List<string> ListaEjemplo
        {
            get { return listaEjemplo; }
            set { listaEjemplo = value; OnPropertyChanged("ListaEjemplo"); }
        }
        private bool focusText;
        public bool FocusText
        {
            get { return focusText; }
            set { focusText = value; OnPropertyChanged("FocusText"); }
        }
        public bool bandera_editar = false;
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; OnPropertyChanged("Descripcion"); }
        }
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; OnPropertyChanged("Tipo"); }
        }
        private string catalogHeader;
        public string CatalogoHeader
        {
            get { return catalogHeader; }
            set { catalogHeader = value; }
        }
        private string headerAgregar;
        public string HeaderAgregar
        {
            get { return headerAgregar; }
            set { headerAgregar = value; }
        }
        private string comboBoxLigado;
        public string ComboBoxLigado
        {
            get { return comboBoxLigado; }
            set { comboBoxLigado = value; }
        }
        private int seleccionIndice;
        public int SeleccionIndice
        {
            get { return seleccionIndice; }
            set { seleccionIndice = value; OnPropertyChanged("SeleccionIndice"); }
        }
        #endregion

        #region BotonesMenuEnabled
        private bool guardarMenuEnabled;
        public bool GuardarMenuEnabled
        {
            get { return guardarMenuEnabled; }
            set { guardarMenuEnabled = value; OnPropertyChanged("GuardarMenuEnabled"); }
        }
        private bool agregarMenuEnabled;
        public bool AgregarMenuEnabled
        {
            get { return agregarMenuEnabled; }
            set { agregarMenuEnabled = value; OnPropertyChanged("AgregarMenuEnabled"); }
        }
        private bool editarMenuEnabled;
        public bool EditarMenuEnabled
        {
            get { return editarMenuEnabled; }
            set { editarMenuEnabled = value; OnPropertyChanged("EditarMenuEnabled"); }
        }
        private bool eliminarMenuEnabled;
        public bool EliminarMenuEnabled
        {
            get { return eliminarMenuEnabled; }
            set { eliminarMenuEnabled = value; OnPropertyChanged("EliminarMenuEnabled"); }
        }
        private bool cancelarMenuEnabled;
        public bool CancelarMenuEnabled
        {
            get { return cancelarMenuEnabled; }
            set { cancelarMenuEnabled = value; OnPropertyChanged("CancelarMenuEnabled"); }
        }
        private bool exportarMenuEnabled;
        public bool ExportarMenuEnabled
        {
            get { return exportarMenuEnabled; }
            set { exportarMenuEnabled = value; OnPropertyChanged("ExportarMenuEnabled"); }
        }
        private bool salirMenuEnabled;
        public bool SalirMenuEnabled
        {
            get { return salirMenuEnabled; }
            set { salirMenuEnabled = value; OnPropertyChanged("SalirMenuEnabled"); }
        }
        private bool ayudaMenuEnabled;
        public bool AyudaMenuEnabled
        {
            get { return ayudaMenuEnabled; }
            set { ayudaMenuEnabled = value; OnPropertyChanged("AyudaMenuEnabled"); }
        }
        #endregion

        #region Visibles
        private bool filtroVisible;
        public bool FiltroVisible
        {
            get { return filtroVisible; }
            set { filtroVisible = value; OnPropertyChanged("FiltroVisible"); }
        }
        private bool agregarVisible;
        public bool AgregarVisible
        {
            get { return agregarVisible; }
            set { agregarVisible = value; OnPropertyChanged("AgregarVisible"); }
        }
        private bool editarVisible;
        public bool EditarVisible
        {
            get { return editarVisible; }
            set { editarVisible = value; OnPropertyChanged("EditarVisible"); }
        }
        private bool nuevoVisible;
        public bool NuevoVisible
        {
            get { return nuevoVisible; }
            set { nuevoVisible = value; OnPropertyChanged("NuevoVisible"); }
        }
        #endregion

        #region Items
        private Usuario updateItem;
        public Usuario UpdateItem
        {
            get { return updateItem; }
            set { updateItem = value; OnPropertyChanged("UpdateItem"); }
        }
        private Usuario newItem;
        public Usuario NewItem
        {
            get { return newItem; }
            set { newItem = value; OnPropertyChanged("NewItem"); }
        }
        private ObservableCollection<Usuario> listItems;
        public ObservableCollection<Usuario> ListItems
        {
            get { return listItems; }
            set { listItems = value; OnPropertyChanged("ListItems"); }
        }
        #endregion

        #endregion

        #region metodos
        private async void clickSwitch(Object obj)
        {
            switch (obj.ToString())
            {
                case "menu_editar":
                    if (_selectedItem != null)
                    {
                        EditarVisible = true;
                        NuevoVisible = false;
                        Descripcion = SelectedItem.Username;
                        Tipo = SelectedItem.Password;

                        GuardarMenuEnabled = true;
                        AgregarMenuEnabled = false;
                        EliminarMenuEnabled = false;
                        EditarMenuEnabled = false;
                        CancelarMenuEnabled = true;
                        AyudaMenuEnabled = true;
                        SalirMenuEnabled = true;
                        ExportarMenuEnabled = false;

                        AgregarVisible = true;

                        bandera_editar = true;
                        FocusText = true;
                    }
                    else
                    {
                        bandera_editar = false;
                        var met = Application.Current.Windows[0] as MetroWindow;
                        await met.ShowMessageAsync("Validación", "Debe seleccionar una opcion.");
                    }
                    break;
                case "menu_agregar":
                    EditarVisible = false;
                    NuevoVisible = true;

                    GuardarMenuEnabled = true;
                    AgregarMenuEnabled = false;
                    EliminarMenuEnabled = false;
                    EditarMenuEnabled = false;
                    CancelarMenuEnabled = true;
                    AyudaMenuEnabled = true;
                    SalirMenuEnabled = true;
                    ExportarMenuEnabled = false;

                    AgregarVisible = true;

                    bandera_editar = false;
                    FocusText = true;
                    break;
                case "menu_guardar":
                    if (bandera_editar == false)
                    {
                        ListItems.Add(new Usuario() { Username = Descripcion, Password = Tipo });
                    }
                    else
                    {
                        SelectedItem.Username = Descripcion;
                        SelectedItem.Password = Tipo;
                    }

                    EditarVisible = false;
                    NuevoVisible = false;

                    GuardarMenuEnabled = false;
                    AgregarMenuEnabled = true;
                    EliminarMenuEnabled = false;
                    EditarMenuEnabled = false;
                    CancelarMenuEnabled = false;
                    AyudaMenuEnabled = true;
                    SalirMenuEnabled = true;
                    ExportarMenuEnabled = true;

                    AgregarVisible = false;

                    SelectedItem = null;
                    SeleccionIndice = -1;
                    Descripcion = string.Empty;
                    Tipo = string.Empty;
                    break;
                case "menu_cancelar":
                    NuevoVisible = false;

                    GuardarMenuEnabled = false;
                    AgregarMenuEnabled = true;
                    EliminarMenuEnabled = false;
                    EditarMenuEnabled = false;
                    CancelarMenuEnabled = false;
                    AyudaMenuEnabled = true;
                    SalirMenuEnabled = true;
                    ExportarMenuEnabled = true;

                    AgregarVisible = false;

                    SelectedItem = null;
                    SeleccionIndice = -1;
                    Descripcion = string.Empty;
                    Tipo = string.Empty;
                    break;
                case "menu_eliminar":
                    var metro = Application.Current.Windows[0] as MetroWindow;
                    if (_selectedItem != null)
                    {
                        var mySettings = new MetroDialogSettings()
                        {
                            AffirmativeButtonText = "Aceptar",
                            NegativeButtonText = "Cancelar",
                            AnimateShow = true,
                            AnimateHide = false
                        };
                        var result = await metro.ShowMessageAsync("Borrar", "¿Está seguro que desea borrar esto? [ " + SelectedItem.Username + " ]", MessageDialogStyle.AffirmativeAndNegative, mySettings);
                        if (result == MessageDialogResult.Affirmative)
                        {
                            var i = ListItems.IndexOf(_selectedItem);
                            if (i >= 0)
                            {
                                ListItems.RemoveAt(i);

                                var dialog = (BaseMetroDialog)metro.Resources["ConfirmacionDialog"];
                                await metro.ShowMetroDialogAsync(dialog);
                                await TaskEx.Delay(1500);
                                await metro.HideMetroDialogAsync(dialog);

                                //MENSAJE EXTERNO
                                //dialog = dialog.ShowDialogExternally();
                                //await TaskEx.Delay(1500);
                                //await dialog.RequestCloseAsync();
                            }
                        }
                    }
                    else
                        await metro.ShowMessageAsync("Validación", "Debe seleccionar una opcion");
                    SelectedItem = null;
                    SeleccionIndice = -1;
                    Descripcion = string.Empty;
                    Tipo = string.Empty;
                    break;
                case "menu_exportar":
                    SelectedItem = null;
                    SeleccionIndice = -1;
                    Descripcion = string.Empty;
                    Tipo = string.Empty;
                    break;
                case "menu_ayuda":
                    SelectedItem = null;
                    SeleccionIndice = -1;
                    Descripcion = string.Empty;
                    Tipo = string.Empty;
                    break;
                case "menu_salir":
                    SelectedItem = null;
                    SeleccionIndice = -1;
                    Descripcion = string.Empty;
                    Tipo = string.Empty;
                    break;
            }
            if (_selectedItem == null)
            {
                EliminarMenuEnabled = false;
                EditarMenuEnabled = false;
            }
        }
        #endregion

        #region command
        private ICommand _onClick;
        public ICommand OnClick
        {
            get
            {
                return _onClick ?? (_onClick = new RelayCommand(clickSwitch));
            }
        }
        Usuario _selectedItem = null;
        public Usuario SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                if (_selectedItem == null)
                {
                    EliminarMenuEnabled = false;
                    EditarMenuEnabled = false;
                }
                else
                {
                    EliminarMenuEnabled = true;
                    EditarMenuEnabled = true;
                }
            }
        }
        #endregion

    }
}