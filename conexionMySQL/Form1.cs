using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexionMySQL
{
    public partial class conexion_MySql : Form
    {
    private  MySqlConnection conexion; 

        public conexion_MySql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("El HOST es un campo requerido");
                return;
            }
            if (string.IsNullOrEmpty(txtusuario.Text))
            {
                MessageBox.Show("El USUARIO es un campo requerido");
                return;
            }
            if (string.IsNullOrEmpty(txtcontrasena.Text))
            {
                MessageBox.Show("La CONTRASEÑA  es un campo requerido");
                return;
            }

            try
            {

                conexion = new MySqlConnection();
                conexion.ConnectionString =
                    "server=" + txtHost.Text + ";"
                    + "user id= " + txtusuario.Text + ";"
                    + "password=" + txtcontrasena.Text + ";";
                conexion.Open();
                MessageBox.Show("LA CONEXION SE REALIZO EXITOSAMENTE ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un erro al conectar:" + ex.Message);
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
