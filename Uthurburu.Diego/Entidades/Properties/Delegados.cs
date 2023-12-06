using System.Windows.Forms;

namespace WheelsHub
{
    /// <summary>
    /// Delegado para manejar eventos relacionados con advertencias.
    /// </summary>
    /// <param name="titulo">El título de la advertencia.</param>
    /// <param name="mensaje">El mensaje de la advertencia.</param>
    public delegate void DelegadoAdevetencia(string titulo, string mensaje);
    /// <summary>
    /// Delegado para determinar si el evento KeyPress corresponde a un carácter numérico.
    /// </summary>
    /// <param name="e">Argumentos del evento KeyPress.</param>
    /// <returns>Devuelve true si el carácter es numérico; de lo contrario, devuelve false.</returns>
    public delegate  bool DelegadoEsNumero(KeyPressEventArgs e);
    /// <summary>
    /// Delegado para validar el evento KeyPress en un control TextBox.
    /// </summary>
    /// <param name="e">Argumentos del evento KeyPress.</param>
    /// <param name="box">Control TextBox en el que se está produciendo el evento.</param>
    public delegate void DelegadoValidarKeyPress(KeyPressEventArgs e, TextBox box);
    /// <summary>
    /// Delegado para manejar eventos de éxito, como mostrar un MessageBox.
    /// </summary>
    /// <param name="texto">Texto a mostrar en el MessageBox.</param>
    /// <param name="titulo">Título del MessageBox.</param>
    /// <param name="icono">Ícono a mostrar en el MessageBox.</param>
    public delegate void DelegadoExito(string texto, string titulo, MessageBoxIcon icono );
    /// <summary>
    /// Delegado para manejar el evento de vaciar el texto de un control TextBox.
    /// </summary>
    /// <param name="text">Control TextBox cuyo texto se va a vaciar.</param>
    public delegate void DelegadoVaciarTexto(TextBox text);

    
}