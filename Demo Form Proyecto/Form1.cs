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
            this.WindowState = FormWindowState.Maximized;
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


                string query = "SELECT COUNT(*) FROM cuenta WHERE Cuenta=@Cuenta AND Contraseña=@Contraseña";
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    cmd.Parameters.AddWithValue("@Cuenta", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", textBox2.Text);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Bienvenido " + textBox1.Text,
                                        "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    else
                    {
                        MessageBox.Show(" Cuenta o Contraseña incorrectos.",
                                        "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Hide();
                    Interfaz_principal Interf = new Interfaz_principal();
                    Interf.Show();
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
