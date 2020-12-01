using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConexion = "Data Source=.\\sqlexpress;" +
            "Initial Catalog=bd_telefonos; Integrated Security=True";
            con = new SqlConnection(strConexion);
        }

    }
}
