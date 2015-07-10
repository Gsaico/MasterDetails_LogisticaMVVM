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
            set { itemusuario = value; 
                RaisePropertyChanged("ItemUsuario"); 
                }
        }

        private ObservableCollection<usuarioDTO> listausuarios;
        public ObservableCollection<usuarioDTO> ListaUsuarios
        {
            get { return listausuarios; }
            set { listausuarios = value; 
                RaisePropertyChanged("ListaUsuarios"); 
                }
        }         

        #endregion


        public UsuarioViewModel()
        {
            if (IsInDesignMode) return;
            _ServicioUsuario = new UsuarioServiceClient();

            ListaUsuarios = new ObservableCollection<usuarioDTO>();
            ItemUsuario = new usuarioDTO();

           _ServicioUsuario.ListarUsuariosAsync();
           _ServicioUsuario.ListarUsuariosCompleted += _ServicioUsuario_ListarUsuariosCompletedBusquedaRapida;
           //ListarUsuariosCommandAction();
         
            ListarUsuariosCommand = new CommandBase(p => true, p => ListarUsuariosCommandAction()) { IsEnable = true };
            GuardarUsuarioCommand = new CommandBase(p => true, p => GuardarUsuarioCommandAccion()) { IsEnable = true };
            EliminarUsuarioCommand = new CommandBase(p => true, p => EliminarUsuarioCommandAccion()) { IsEnable = true };
            NuevoUsuarioCommand = new CommandBase(p => true, p => NuevoUsuarioCommandAccion()) { IsEnable = true };
                        
        }

        private void _ServicioUsuario_ListarUsuariosCompletedBusquedaRapida(object sender, ListarUsuariosCompletedEventArgs e)
        {
            _ServicioUsuario.ListarUsuariosCompleted -= _ServicioUsuario_ListarUsuariosCompletedBusquedaRapida;

            ListaUsuariosBusquedaRapida = e.Result;
        }

        


        #region Basicos
        private void EliminarUsuarioCommandAccion()
        {
            if (ItemUsuario != null && ItemUsuario.ID_Usuario  != 0)
            {
                MessageBoxResult result = MessageBox.Show("Esta usted seguro de eliminar el usuario: " +
                    ItemUsuario.nombres , "Eliminar Usuario", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    _ServicioUsuario.EliminarUsuarioAsync(ItemUsuario.ID_Usuario );
                    _ServicioUsuario.EliminarUsuarioCompleted+=_ServicioUsuario_EliminarUsuarioCompleted; 
                }
                else
                {

                    MessageBox.Show("No hay datos del usuario, para almacenar en el sistema");
                }

            }
            else
            {

                MessageBox.Show("Seleccione Usuario");
            }
        }

        private void _ServicioUsuario_EliminarUsuarioCompleted(object sender, EliminarUsuarioCompletedEventArgs e)
        {
            _ServicioUsuario.EliminarUsuarioCompleted -= _ServicioUsuario_EliminarUsuarioCompleted; 
            if (e.Result == true)
            {
                ListarUsuariosCommandAction();
                MessageBox.Show("El  Usuario se elimino correctamente");
                
            }
            else
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
        }

        private void GuardarUsuarioCommandAccion()
        {
            try
            {
                if (ItemUsuario.ID_Usuario  == 0)//
                {
                    _ServicioUsuario.InsertarUsuarioAsync(ItemUsuario);
                    _ServicioUsuario.InsertarUsuarioCompleted+=_ServicioUsuario_InsertarUsuarioCompleted;
                   //Insert
                }
                else
                {
                    _ServicioUsuario.ActualizarUsuarioAsync(ItemUsuario);
                    _ServicioUsuario.ActualizarUsuarioCompleted += _ServicioUsuario_ActualizarUsuarioCompleted;
                   //Update
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Error al guardar Usuario");
            }
        }

        private void _ServicioUsuario_InsertarUsuarioCompleted(object sender, InsertarUsuarioCompletedEventArgs e)
        {
            _ServicioUsuario.InsertarUsuarioCompleted -= _ServicioUsuario_InsertarUsuarioCompleted;
            if (e.Result != null)//?????
            {
                MessageBox.Show("El  Usuario se ingreso correctamente a la BD, con el Nombre: " + itemusuario.nombres  );
                ListarUsuariosCommandAction();
            }
            else
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
        }

        private void _ServicioUsuario_ActualizarUsuarioCompleted(object sender, ActualizarUsuarioCompletedEventArgs e)
        {
            _ServicioUsuario.ActualizarUsuarioCompleted -= _ServicioUsuario_ActualizarUsuarioCompleted;
            if (e.Result == true)
            {
                MessageBox.Show("El  Usuario se actualizo correctamente");
                ListarUsuariosCommandAction();
            }
            else
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
        }

        private void NuevoUsuarioCommandAccion()
        {
            if (ItemUsuario != null && ItemUsuario.ID_Usuario  != 0)
            {
                MessageBoxResult result = MessageBox.Show("Realmente desea ingresar un nuevo usuario.", "Nuevo Usuario",
                    MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    ItemUsuario = new usuarioDTO();
                }
                else
                {

                    MessageBox.Show("No hay datos del usuario, para almacenar en el sistema");
                }

            }
            else
            {

                ItemUsuario = new usuarioDTO();
            }
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
            _ServicioUsuario.ListarUsuariosCompleted -= _ServicioUsuario_ListarUsuariosCompleted;
            
            ListaUsuarios.Clear();
            

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message + e.Error);
                return;
            }
           
             
                ListaUsuarios = e.Result; 
           
            
        }

        #endregion

        #region ComplejoBusqueda

        private usuarioDTO itemusuariobusquedarapida;
        public usuarioDTO ItemUsuarioBusquedaRapida
        {
            get { return itemusuariobusquedarapida; }
            set
            {
                itemusuariobusquedarapida = value;
                RaisePropertyChanged("ItemUsuarioBusquedaRapida"); 
                }
        }

        private ObservableCollection<usuarioDTO> listausuariosbusquedarapida;
        public ObservableCollection<usuarioDTO> ListaUsuariosBusquedaRapida
        {
            get { return listausuariosbusquedarapida; }
            set
            {
                listausuariosbusquedarapida = value;
                RaisePropertyChanged("ListaUsuariosBusquedaRapida"); 
                }
        }
        //
        #endregion

        #region push
        public ICommand GuardarUsuarioCommand { get; set; }
        public ICommand EliminarUsuarioCommand { get; set; }
        public ICommand ListarUsuariosCommand { get; set; }
        public ICommand NuevoUsuarioCommand { get; set; }
        #endregion 
    }
}
