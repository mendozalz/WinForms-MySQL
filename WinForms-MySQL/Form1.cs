using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_MySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection con;

        public Form1()
        {
            InitializeComponent();
            conexionAutomatica();
        }

        private void conectar()
        {
            try
            {
                string server = "localhost";
                string database = "empleados";
                string user = "root";
                string pwd = "12345";
                string conexion = "server=" + server + ";database=" + database + ";Uid=" + user + ";pwd=" + pwd + ";";
                con = new MySqlConnection(conexion);
                con.Open();
                label1.Text = "Conexion exitosa";
            }
            catch (Exception ex)
            {
                label1.Text = "Error de conexión" + ex;
            }

        }

        private void conexionAutomatica()
        {
            conectar();
            string query = "select id,nombre,apellido,edad from trabajadores;";
            MySqlCommand comandDB = new MySqlCommand(query, con);
            comandDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comandDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dataGridView.Rows.Add();
                        dataGridView.Rows[n].Cells[0].Value = reader.GetValue(0);
                        dataGridView.Rows[n].Cells[1].Value = reader.GetString(1);
                        dataGridView.Rows[n].Cells[2].Value = reader.GetString(2);
                        dataGridView.Rows[n].Cells[3].Value = reader.GetValue(3);
                    }

                }
                else
                {
                    Console.WriteLine("No hay registros");
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                label1.Text = "Error de conexión" + ex;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string where = "where 1=1";

            if (txtNombre.Text != " ")
            {
                where = where + " and nombre like'%" + txtNombre.Text + "%'";
            }
            if (txtApellido.Text != " ")
            {
                where = where + " and nombre like'%" + txtApellido.Text + "%'";
            }
            if (txtEdad.Text != " ")
            {
                where = where + " and nombre like'%" + txtEdad.Text + "%'";
            }

            string query = "select id,nombre,apellido,edad from trabajadores " + where;
            MySqlCommand comandDB = new MySqlCommand(query, con);
            comandDB.CommandTimeout = 60;
            MySqlDataReader reader;
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            try
            {
                reader = comandDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dataGridView.Rows.Add();
                        dataGridView.Rows[n].Cells[0].Value = reader.GetValue(0);
                        dataGridView.Rows[n].Cells[1].Value = reader.GetString(1);
                        dataGridView.Rows[n].Cells[2].Value = reader.GetString(2);
                        dataGridView.Rows[n].Cells[3].Value = reader.GetValue(3);
                    }

                }
                else
                {
                    Console.WriteLine("No hay registros");
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                label1.Text = "Error de conexión" + ex;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensajeError = " ";
           
            if(txtInsNombre.Text==" ")
            {
                mensajeError += "El nombre es requerido";
            }
            if(txtInsApellido.Text==" ")
            {
                mensajeError += "El apellido es requerido";
            }
            if(txtInsEdad.Text==" ")
            {
                mensajeError += "La edad es requerida";
            }
            if(mensajeError==" ")
            {
                string query = "insert into trabajadores (nombre,apellido,edad) values " +
                    "('"+txtInsNombre.Text+"','"+txtInsApellido.Text+"','"+txtInsEdad.Text +"' )";
                MySqlCommand comand = new MySqlCommand(query, con);
                comand.CommandTimeout = 60;
                MySqlDataReader reader;
                try
                {
                    reader = comand.ExecuteReader();
                    reader.Close();
                    dataGridView.Rows.Clear();
                    dataGridView.Refresh();
                    conexionAutomatica();
                    txtInsNombre.Text = " ";
                    txtInsApellido.Text = " ";
                    txtInsEdad.Text = " ";
                }catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show(mensajeError);
            }
        }
    }

}
