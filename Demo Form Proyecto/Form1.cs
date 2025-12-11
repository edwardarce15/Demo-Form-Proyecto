using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Form_Proyecto
{
    public partial class Form1 : Form
    {
        private string Nomuser;
        private void ocultarpanel()
        {

        }
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "server=69.6.201.17; database=afcbemis_SecundariaTecnica; Uid=afcbemis; pwd=isoft1106.Proyectos;";
            MySqlConnection cn = new MySqlConnection(conexion);

            try
            {
                cn.Open();

                string query = @"
        SELECT f.Funcion
        FROM cuenta c
        JOIN empleado e ON c.Empleado_idEmpleado = e.idEmpleado
        JOIN funcion f ON e.Funcion_idFuncion = f.idFuncion
        WHERE c.Cuenta = @Cuenta AND c.Contraseña = @Contraseña";

                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Cuenta", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", textBox2.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string funcion = result.ToString().Trim().ToLower();

                        switch (funcion)
                        {
                            case "director":
                                MessageBox.Show("Bienvenido Director");
                                break;

                            case "prefecto":
                                MessageBox.Show("Bienvenido Prefecto");
                                break;

                            case "trabajador social":
                                MessageBox.Show("Bienvenido Trabajador Social");
                                break;

                            case "maestro":
                                MessageBox.Show("Bienvenido Maestro");
                                break;

                            default:
                                MessageBox.Show("Función desconocida: " + funcion);
                                break;
                        }

                       
                        this.Hide();
                        Interfaz_principal Interf = new Interfaz_principal();
                        Interf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Cuenta o Contraseña incorrectos.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = true;

        }


    }
}
