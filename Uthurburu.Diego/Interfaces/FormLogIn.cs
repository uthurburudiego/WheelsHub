using Entidades;
using WheelsHub;
using WheelsHub.Logica;
using Newtonsoft.Json;
using System.Drawing;

namespace Interfaces
{
    public partial class FormLogIn : Form
    {
        #region Atributos
        private System.Windows.Forms.Timer timer;
        private Usuario usuario;
        private List<Usuario> listaUsuarios;
        string path;
        List<string> registroUsuarios;
        ManejadorArchivos<List<string>> serializadoraRegistros = new ManejadorArchivos<List<string>>();
        ManejadorArchivos<List<Usuario>> serializadoraUsuarios = new ManejadorArchivos<List<Usuario>>();


        #endregion

        #region Eventos
        public event DelegadoAdevetencia ErrorLogIn;
        public event DelegadoExito ExitoLog;
        public event DelegadoVaciarTexto LimpiarTexto;


        #endregion

        #region Propiedades
        public Usuario Usuario { get => usuario; set => usuario = value; }
        #endregion

        #region Constructor
        public FormLogIn()
        {
            InitializeComponent();
            this.usuario = new Usuario();
            registroUsuarios = new List<string>();
            this.ErrorLogIn += ErrorLog;
            this.ExitoLog += IngresoExitoso;
            this.LimpiarTexto += Funciones.LimpiarTexto;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (actualiza cada segundo)
            timer.Tick += Timer_Tick;

            // Iniciar el temporizador
            timer.Start();

        }
        #endregion

        #region Botones
        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVer.Checked)
            {
                chkVer.Text = "Ocultar";
                txtContrase�a.UseSystemPasswordChar = false;
            }
            else
            {
                chkVer.Text = "Ver";
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.usuario.Correo = this.txtUsuario.Text;
            this.usuario.Clave = this.txtContrase�a.Text;
            this.path = ManejadorArchivos<List<string>>.ObtenerPath(@"..\..\..\..\Datos\MOCK_DATA.json");
            this.listaUsuarios = serializadoraUsuarios.Deserializar(path);

            if (ValidarUsuario())
            {
                this.registroUsuarios.Add(this.usuario.Registro());
                this.path = ManejadorArchivos<string>.ObtenerPath(@"..\..\..\..\Datos\usuarios_log.json");
                serializadoraRegistros.Serializar(registroUsuarios, path);
                this.ExitoLog.Invoke($"Bienvenido {this.usuario.Nombre}", "LogIn", MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.ErrorLogIn.Invoke("LogIn ERROR", "Usuario/Contrase�a no existen.");
                this.LimpiarTexto.Invoke(txtUsuario);
                this.LimpiarTexto.Invoke(txtContrase�a);
            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // El c�digo que deseas ejecutar al presionar Enter
                btnAceptar_Click(sender, e);
                e.SuppressKeyPress = true; // Evita que se procese la tecla Enter m�s de una vez
            }
        }
        private void txtContrase�a_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // El c�digo que deseas ejecutar al presionar Enter
                btnAceptar_Click(sender, e);
                e.SuppressKeyPress = true; // Evita que se procese la tecla Enter m�s de una vez
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida las credenciales del usuario compar�ndolas con los usuarios almacenados en la lista de usuarios.
        /// </summary>
        /// <returns>Devuelve true si las credenciales son v�lidas y se encuentra el usuario en la lista, de lo contrario, devuelve false.</returns>
        private bool ValidarUsuario()
        {
            bool retorno = false;
            foreach (Usuario u in this.listaUsuarios)
            {
                if (u.Correo == this.usuario.Correo && u.Clave == this.usuario.Clave)
                {
                    this.usuario = u;
                    retorno = true;
                    break;
                }
            }


            return retorno;
        }
        /// <summary>
        /// Muestra un cuadro de mensaje indicando un ingreso exitoso con el texto especificado.
        /// </summary>
        /// <param name="texto">Texto que se mostrar� en el cuadro de mensaje.</param>
        /// <param name="titulo">T�tulo del cuadro de mensaje.</param>
        /// <param name="icono">�cono que se mostrar� en el cuadro de mensaje.</param>
        private void IngresoExitoso(string texto, string titulo, MessageBoxIcon icono)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, icono);
        }
        /// <summary>
        /// Muestra un cuadro de mensaje de error con el mensaje y t�tulo especificados.
        /// </summary>
        /// <param name="titulo">T�tulo del cuadro de mensaje de error.</param>
        /// <param name="mensaje">Mensaje de error que se mostrar� en el cuadro.</param>
        protected void ErrorLog(string titulo, string mensaje)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Maneja el evento Tick del temporizador y actualiza la fecha en el Label de manera as�ncrona.
        /// </summary>
        /// <param name="sender">El objeto que gener� el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private async void Timer_Tick(object sender, EventArgs e)
        {
            // M�todo que se ejecutar� cada vez que el temporizador expire
            await ActualizarFechaEnLabelAsync(lblHora);
        }
        /// <summary>
        /// Actualiza de forma as�ncrona la fecha en un control Label con la hora actual.
        /// </summary>
        /// <param name="lblHora">El control Label donde se mostrar� la hora.</param>
        /// <returns>Una tarea que representa la operaci�n as�ncrona.</returns>
        private async Task ActualizarFechaEnLabelAsync(Label lblHora)
        {
            DateTime horaActual = await Task.Run(() => DateTime.Now);
            if (lblHora.InvokeRequired)
            {
                lblHora.Invoke((Action)(() => lblHora.Text = horaActual.ToString("HH:mm:ss")));
            }
            else
            {
                lblHora.Text = $"{horaActual.ToString("HH:mm:ss")}";
            }
        }
        #endregion

    }
}