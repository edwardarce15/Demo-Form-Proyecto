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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo_Form_Proyecto
{
    public partial class Interfaz_principal : Form
    {
        Clsconexion cone=new Clsconexion();
        public Interfaz_principal()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        public void ocultar_panel()
        {
            panel1.Parent = this;
            panel2.Parent = this;
            panel3.Parent = this;
            panel4.Parent = this;
            panel5.Parent = this;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel1.Visible = true;
            panel1.BringToFront();
            Dock= DockStyle.Fill;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel2.Visible = true;
            panel2.BringToFront();
            Dock= DockStyle.Fill;
        }

        private void Interfaz_principal_Load(object sender, EventArgs e)
        {
            textBox16.UseSystemPasswordChar = true;
        }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel3.Visible = true;
            panel3.BringToFront();
            Dock = DockStyle.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel4.Visible = true;
            panel4.BringToFront();
            Dock = DockStyle.Fill;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel5.Visible = true;
            panel5.BringToFront();
            Dock = DockStyle.Fill;

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox16.UseSystemPasswordChar = false;
                textBox17.UseSystemPasswordChar = false;
            }
            else
            {
                textBox16.UseSystemPasswordChar = true;
                textBox17.UseSystemPasswordChar = true;
            }
        }
        private void funcion()
        {
            DataTable dt3 = cone.Desplegar("SELECT idFuncion, Funcion FROM funcion order BY Funcion");
            comboBox4.ValueMember = "idFuncion";
            comboBox4.DisplayMember = "Funcion";
            comboBox4.DataSource = dt3;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string Sql= "INSERT INTO empleado VALUES(null,'"+ textBox6.Text + "','"+ textBox3.Text + "','" + comboBox4.SelectedValue + "')";
            cone.Ejecutar(Sql);
            MessageBox.Show(Sql);
            MessageBox.Show("Se Guardo el usuario" + textBox3.Text, "LISTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
