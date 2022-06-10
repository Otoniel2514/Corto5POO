using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmPrincipal.Properties;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        private Label lblNombre;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "select id_servi, nombre, direccion from HOTEL";
                SqlCommand command = new SqlCommand(query, connection);
                //MessageBox.Show("Query Configurada");
                
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id_servi = Convert.ToInt32(reader["id_servi"].ToString());
                        string nombre = reader["nombre"].ToString();
                        string direccion = reader["direccion"].ToString();
                        
                        txtNombres.AppendText(id_servi + ": " + 
                                              nombre + " - " + direccion);
                        txtNombres.AppendText(direccion + Environment.NewLine);
                    }

                }

                connection.Close();
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            txtNombres2.Clear();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "select id_servi, nombre, direccion from HOTEL where id_servi = @id_servibuscado";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue( "@id_servibuscado", Convert.ToInt32(nudId_servi.Value));
                

                connection.Open( );
                using (SqlDataReader reader = command.ExecuteReader( ))
                {
                    while (reader.Read())
                    {		
                        int id_servi = Convert.ToInt32(reader["id_servi"].ToString( ));
                        string nombre = reader["nombre"].ToString( );
                        string direccion = reader["direccion"].ToString( );

                        txtNombres2.AppendText(id_servi + ": " + 
                                              nombre + " - " + direccion);
                        txtNombres2.AppendText(direccion + Environment.NewLine);
                    }
                }
                connection.Close( );
            }

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}