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
//NECESARIOS
using LogisticaDB_ViewModel.ServiceReference_LogisticaDB;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using HostalDB_ViewModel.Commands; 


namespace LogisticaDB_ViewModel.ViewModels
{
    public class UsuarioViewModel : ViewModelBase
    {
        private ServiceReference_LogisticaDB.UsuarioServiceClient _ServicioUsuario;
        private ServiceReference_LogisticaDB.DepartamentoServiceClient  _ServicioDepartamento;
        private ServiceReference_LogisticaDB.ProyectoServiceClient  _ServicioProyecto;

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%  PROPIEDADES %%%%%%%%%%%%%%%%%%%%%%%%%%%%%
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

        #region propiedades del Departamento
        private departamentoDTO  itemdepartamento;
        public departamentoDTO ItemDepartamento
        {
            get { return itemdepartamento; }
            set
            {
                itemdepartamento = value;

                RaisePropertyChanged("ItemDepartamento");
            }
        }
       
        private ObservableCollection<departamentoDTO> listadepartamento;
        public ObservableCollection<departamentoDTO> ListaDepartamento
        {
            get { return listadepartamento; }
            set { listadepartamento = value; RaisePropertyChanged("ListaDepartamento"); }
        }

        #endregion

        #region propiedades del Proyecto
        private proyectoDTO  itemproyecto;
        public proyectoDTO ItemProyecto
        {
            get { return itemproyecto; }
            set
            {
                itemproyecto = value;

                RaisePropertyChanged("ItemProyecto");
            }
        }

        private ObservableCollection<proyectoDTO> listaproyectos;
        public ObservableCollection<proyectoDTO> ListaProyectos
        {
            get { return listaproyectos; }
            set { listaproyectos = value; RaisePropertyChanged("ListaProyectos"); }
        }

        #endregion


        #region propiedades del Autocomplete

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

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%% COMANDOS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        #region Comandos  Usuarios
        public ICommand NuevoUsuarioCommand { get; set; }
        public ICommand GuardarUsuarioCommand { get; set; }
        public ICommand EliminarUsuarioCommand { get; set; }
        
        #endregion

        #region Comandos  Proyectos
        public ICommand AgregarProyectoCommand { get; set; }
        public ICommand NuevoProyectoCommand { get; set; }
        public ICommand EliminarProyectoCommand { get; set; }

        #endregion 

        #region Comandos  Busqueda
        public ICommand ListarUsuariosCommand { get; set; }
        public ICommand ListarUsuariosXNombreCommand { get; set; }
        #endregion

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%% CONSTRUCTOR %%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        #region CONSTRUCTOR
        public UsuarioViewModel()
        {
            if (IsInDesignMode) return;//por si acaso ? 
            _ServicioUsuario = new UsuarioServiceClient();
            _ServicioDepartamento = new DepartamentoServiceClient();
            _ServicioProyecto = new ProyectoServiceClient();

            ListaUsuarios = new ObservableCollection<usuarioDTO>();
            ItemUsuario = new usuarioDTO();
                    
            NuevoUsuarioCommand = new CommandBase(p => true, p => NuevoUsuarioCommandAccion()) { IsEnable = true };
            GuardarUsuarioCommand = new CommandBase(p => true, p => GuardarUsuarioCommandAccion()) { IsEnable = true };
            EliminarUsuarioCommand = new CommandBase(p => true, p => EliminarUsuarioCommandAccion()) { IsEnable = true };


            NuevoProyectoCommand = new CommandBase(p => true, p => NuevoProyectoCommandAccion()) { IsEnable = true };
            AgregarProyectoCommand = new CommandBase(p => true, p => AgregarProyectoCommandAccion()) { IsEnable = true };                 
            EliminarProyectoCommand = new CommandBase(p => true, p => EliminarProyectoCommandAccion()) { IsEnable = true };

            
            ListarUsuariosCommand = new CommandBase(p => true, p => ListarUsuariosCommandAction()) { IsEnable = true };
            ListarUsuariosXNombreCommand = new CommandBase(p => true, p => ListarUsuariosXNombreCommandCommandAccion()) { IsEnable = true };

            //lista los usuarios busqueda rapida
            _ServicioUsuario.ListarUsuariosAsync();
            _ServicioUsuario.ListarUsuariosCompleted += _ServicioUsuario_ListarUsuariosCompletedBusquedaRapida;


            //lista los departamentos
            _ServicioDepartamento.ListarDepartamentosAsync();
            _ServicioDepartamento.ListarDepartamentosCompleted += _ServicioDepartamento_ListarDepartamentosCompleted;


            ListarUsuariosCommandAction();
                        
        }

      
        #endregion

        //%%%%%%%%%%%%%%%%%%%%%% ASINCRONOS Y COMPLETE %%%%%%%%%%%%%%%%%%%%%%%%%%
        #region Asincronos y Complete Usuario
        /// <summary>
        /// Nuevo usuario
        /// </summary>
        private void NuevoUsuarioCommandAccion()
        {
            if (ItemUsuario != null && ItemUsuario.ID_Usuario != 0)
            {
                MessageBoxResult result = MessageBox.Show("Realmente desea ingresar un nuevo usuario.", "Nuevo Usuario", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                  
                    ItemUsuario = new usuarioDTO();

                    ItemUsuario.proyecto = new ObservableCollection<proyectoDTO>();

                }
                else
                {

                    MessageBox.Show("No hay datos del usuario, para almacenar en el sistema");
                }

            }
            else
            {
               
                ItemUsuario = new usuarioDTO();
                ItemUsuario.proyecto = new ObservableCollection<proyectoDTO>();
            }
        }
        /// <summary>
        /// Guardar Usuario
        /// </summary>
        private void GuardarUsuarioCommandAccion()
        {
            try
            {
                if (ItemUsuario.ID_Usuario == 0)//
                {
                    _ServicioUsuario.InsertarUsuarioAsync(ItemUsuario);
                    _ServicioUsuario.InsertarUsuarioCompleted += _ServicioUsuario_InsertarUsuarioCompleted;
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

            MessageBox.Show("El  Usuario se ingreso correctamente a la BD");
            ListarUsuariosCommandAction();
            ItemUsuario.ID_Usuario = e.Result;

        }

        private void _ServicioUsuario_ActualizarUsuarioCompleted(object sender, ActualizarUsuarioCompletedEventArgs e)
        {
            _ServicioUsuario.ActualizarUsuarioCompleted -= _ServicioUsuario_ActualizarUsuarioCompleted;
            if (e.Result == true)
            {
                MessageBox.Show("El  Usuario se actualizo correctamente");
             
            }
            else
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
        }
        /// <summary>
        /// Eliminar Usuario
        /// </summary>
        private void EliminarUsuarioCommandAccion()
        {
            if (ItemUsuario != null && ItemUsuario.ID_Usuario != 0)
            {
                MessageBoxResult result = MessageBox.Show("Esta usted seguro de eliminar el usuario: " +
                    ItemUsuario.nombres, "Eliminar Usuario", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {
                    _ServicioUsuario.EliminarUsuarioAsync(ItemUsuario.ID_Usuario);
                    _ServicioUsuario.EliminarUsuarioCompleted += _ServicioUsuario_EliminarUsuarioCompleted;
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

        #endregion

        #region Asincronos y Complete Proyectos
              
        private void NuevoProyectoCommandAccion()
        {         
                MessageBoxResult result = MessageBox.Show("Realmente desea ingresar un nuevo proyecto.", "Nuevo Proyecto", MessageBoxButton.OKCancel);

                if (result == MessageBoxResult.OK)
                {                  
                    ItemProyecto = new proyectoDTO();
                 
                }

      
        }
        private void AgregarProyectoCommandAccion()
        {
          ItemUsuario.proyecto.Add(ItemProyecto);
        }

        private void EliminarProyectoCommandAccion()
        {
         ItemUsuario.proyecto.Remove(ItemProyecto);
        }
          
        #endregion

        //%%%%%%%%%%%%%%%%%%%%%% SECUNDARIOS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        #region Asincronos y Complete Departamentos
        private void _ServicioDepartamento_ListarDepartamentosCompleted(object sender, ListarDepartamentosCompletedEventArgs e)
        {
            ListaDepartamento = e.Result;  
        }

        #endregion

        #region Asincronos y Complete Busqueda de Usuarios
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

        private void ListarUsuariosXNombreCommandCommandAccion()
        {
            _ServicioUsuario.ListarUsuarioXnombreAsync(ItemUsuarioBusquedaRapida.nombres);
            _ServicioUsuario.ListarUsuarioXnombreCompleted += _ServicioUsuario_ListarUsuarioXnombreCompleted;
        }

        private void _ServicioUsuario_ListarUsuarioXnombreCompleted(object sender, ListarUsuarioXnombreCompletedEventArgs e)
        {
            ListaUsuarios.Clear();

            _ServicioUsuario.ListarUsuarioXnombreCompleted += _ServicioUsuario_ListarUsuarioXnombreCompleted;
            if (e.Result != null)
            {
                ListaUsuarios = e.Result;

            }
            else
            {
                MessageBox.Show(e.Error.Message + e.Error);
            }
        }
        private void _ServicioUsuario_ListarUsuariosCompletedBusquedaRapida(object sender, ListarUsuariosCompletedEventArgs e)
        {
            _ServicioUsuario.ListarUsuariosCompleted -= _ServicioUsuario_ListarUsuariosCompletedBusquedaRapida;

            ListaUsuariosBusquedaRapida = e.Result;
        }
        #endregion

       

       
    }
}
