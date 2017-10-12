using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        MySqlConnection conexion = new MySqlConnection();
        String variableconexion;
        public Form1()
        {
            InitializeComponent();
            IniciarConexion();
        }
        private void IniciarConexion()
        {
            try
            {
                variableconexion = ("Server=127.0.0.1; Database=prueba_progra; User=root; Password=;");
                conexion.ConnectionString = variableconexion;
                conexion.Open();
                MessageBox.Show("La conexion se ha realizado con exito");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("La conexion ha fallado, el error es" + ex);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}