using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        //private SqlConnection ConexionConBD = null;
        
        public Form1()
        {
            InitializeComponent();
            string strConexion = "Data Source=(Local)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
            con = new SqlConnection(strConexion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConexion = @"Data Source=(Local)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
            con = new SqlConnection(strConexion);
            //ConexionConBD = new SqlConnection(strConexion);
        }

        private void btMostrarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                // Probar a abrir la conexión
                con.Open();
                tbVersion.Text = "Versión del servidor: " + con.ServerVersion;
                tbEstadoConexion.Text = "La conexion está: \n";
                tbEstadoConexion.Text +=con.State.ToString();
                tbEstadoConexion.Text += "\nSe accede a la base de datos";
            }
            catch (Exception ex)
            {
                // Manipular la excepción
                tbEstadoConexion.Text = "Error al acceder a la base de datos. "
                + ex.Message;
            }
            finally
            {
                // Asegurarse de que la conexión queda cerrada.
                // Aunque la conexión estuviera cerrada,
                // llamar a Close() no produce un error.
                con.Close();
                tbEstadoConexion.Text += "\nAhora la conexion está: " +
                con.State.ToString();
            }
        }
        
    }
}
