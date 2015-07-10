using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using LogisticaDB_ViewModel.ServiceReference_LogisticaDB;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using HostalDB_ViewModel.Commands; 


namespace LogisticaDB_ViewModel.ViewModels
{
    public class UsuarioViewModel : ViewModelBase
    {
        private ServiceReference_LogisticaDB.UsuarioServiceClient _ServicioUsuario;

        #region Propiedades del Usuario
        private usuarioDTO  itemusuario;
        public usuarioDTO ItemUsuario
        {
            get { return itemusuario; }
            set { itemusuario = value; RaisePropertyChanged("ItemUsuario"); }
        }

        private ObservableCollection<usuarioDTO> listausuarios;
        public ObservableCollection<usuarioDTO> ListaUsuarios
        {
            get { return listausuarios; }
            set { listausuarios = value; RaisePropertyChanged("ListaUsuarios"); }
        }         

        #endregion


        public UsuarioViewModel()
        {
            if (IsInDesignMode) return;
            _ServicioUsuario = new UsuarioServiceClient();

            ListaUsuarios = new ObservableCollection<usuarioDTO>();
            ItemUsuario = new usuarioDTO();
            
           // InsertarCommand = new CommandBase(p => true,p=> InsertarCommandAction() ) { IsEnable = true };
          //  EliminarCommand = new CommandBase(p => true, p => EliminarCommandAction()) { IsEnable = true };
          //  BuscarCommand = new CommandBase(p => true, p => BuscarCommandAction()) { IsEnable = true };
            ListarUsuariosCommand = new CommandBase(p => true, p => ListarUsuariosCommandAction()) { IsEnable = true };
            //NuevoCommand = new CommandBase(p => true, p => NuevoCommandAction()) { IsEnable = true };
                        
        }

        private void ListarUsuariosCommandAction()
        {
            try
            {
                _ServicioUsuario.ListarUsuariosAsync();
                _ServicioUsuario.ListarUsuariosCompleted += _ServicioUsuario_ListarUsuariosCompleted;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al devolver datos");
            }
        }

        private void _ServicioUsuario_ListarUsuariosCompleted(object sender, ListarUsuariosCompletedEventArgs e)
        {
            ListaUsuarios.Clear();


            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
            else
            {
             
                ListaUsuarios = e.Result; 
            }
            _ServicioUsuario.ListarUsuariosCompleted -= _ServicioUsuario_ListarUsuariosCompleted;
        }

        #region push
        public ICommand InsertarCommand { get; set; }
        public ICommand EliminarCommand { get; set; }
        public ICommand BuscarCommand { get; set; }
        public ICommand ListarUsuariosCommand { get; set; }
        public ICommand NuevoCommand { get; set; }
        #endregion 
    }
}
