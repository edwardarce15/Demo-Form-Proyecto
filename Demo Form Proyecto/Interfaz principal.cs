using MySql.Data.MySqlClient;
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
        MySqlConnection conexion = new MySqlConnection("server=69.6.201.17; database=afcbemis_SecundariaTecnica; Uid=afcbemis; pwd=isoft1106.Proyectos; ");

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
            Clsconexion cone = new Clsconexion();
            
            textBox16.UseSystemPasswordChar = true;
            try
            {
                funcion();
                User();
                grado();
                grupo();
                grado2();
                grupo2();
                TipoFalta();
                Templeado();
                alumno();
                Turno();
                llenarlvAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel4.Visible = true;
            panel4.BringToFront();
            Dock = DockStyle.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel3.Visible = true;
            panel3.BringToFront();
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
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idFuncion, Funcion FROM funcion order BY Funcion");
            comboBox4.ValueMember = "idFuncion";
            comboBox4.DisplayMember = "Funcion";
            comboBox4.DataSource = dt3;

        }
 

        private void button7_Click(object sender, EventArgs e)
        {
            Clsconexion cone = new Clsconexion();
            string Sql= "INSERT INTO empleado VALUES(null,'"+ textBox6.Text + "','"+ textBox3.Text + "','" + comboBox4.SelectedValue + "')";
            cone.Ejecutar(Sql);
            MessageBox.Show(Sql);
            MessageBox.Show("Se Guardo el usuario" + textBox3.Text, "LISTO!", MessageBoxButtons.OK);

        }


        private void button8_Click(object sender, EventArgs e)
        {
            
            Clsconexion cone = new Clsconexion();
            string Sql = "DELETE * FROM empleado WHERE id_Empleado =" + textBox6.Text;
            cone.Ejecutar(Sql);
            MessageBox.Show("Se elimino el usuario");
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void User()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idEmpleado, Nombre FROM empleado order BY Nombre");
            comboBox11.ValueMember = "idEmpleado";
            comboBox11.DisplayMember = "Nombre";
            comboBox11.DataSource = dt3;


        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox16.Text == textBox17.Text)
            {
                Clsconexion cone = new Clsconexion();
                string Sql = "INSERT INTO cuenta VALUES(null,'" + textBox15.Text + "','" + textBox17.Text + "','" + comboBox11.SelectedValue + "')";
                cone.Ejecutar(Sql);
                MessageBox.Show(Sql);
                MessageBox.Show("Se Guardo el usuario" + textBox16.Text, "LISTO!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grado()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idGrado, Grado FROM grado order BY Grado");
            comboBox5.ValueMember = "idGrado";
            comboBox5.DisplayMember = "Grado";
            comboBox5.DataSource = dt3;
        }
        private void grupo()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idGrupo, Grupo FROM grupo order BY Grupo");
            comboBox6.ValueMember = "idGrupo";
            comboBox6.DisplayMember = "Grupo";
            comboBox6.DataSource = dt3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clsconexion cone = new Clsconexion();
            string Sql = "INSERT INTO alumnos VALUES(null,'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox14.Text + "','" + textBox7.Text + "','" + comboBox5.SelectedValue + "','" + comboBox6.SelectedValue + "','" + comboBox13.SelectedValue + "')";
            cone.Ejecutar(Sql);
            MessageBox.Show(Sql);
            MessageBox.Show("Se Guardo el ALUMNO " + textBox4.Text, "LISTO!", MessageBoxButtons.OK);
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void grado2()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idGrado, Grado FROM grado order BY Grado");
            comboBox2.ValueMember = "idGrado";
            comboBox2.DisplayMember = "Grado";
            comboBox2.DataSource = dt3;
        }
        private void grupo2()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idGrupo, Grupo FROM grupo order BY Grupo");
            comboBox1.ValueMember = "idGrupo";
            comboBox1.DisplayMember = "Grupo";
            comboBox1.DataSource = dt3;
        }
        private void TipoFalta()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idTipofalta, Tipodefalta FROM Tipofalta order BY Tipodefalta");
            comboBox3.ValueMember = "idTipofalta";
            comboBox3.DisplayMember = "Tipodefalta";
            comboBox3.DataSource = dt3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Clsconexion cone = new Clsconexion();
            string Sql = "INSERT INTO reporte VALUES(null,'" + textBox12.Text + "','"  + comboBox2.SelectedValue + "','" + comboBox1.SelectedValue + "','" + comboBox12.SelectedValue + "','" + comboBox10.SelectedValue + "','" + comboBox3.SelectedValue + "')";
            cone.Ejecutar(Sql);
            MessageBox.Show(Sql);
            MessageBox.Show("Reporte generado con exito" + textBox4.Text, "LISTO!", MessageBoxButtons.OK);
        }
        private void Templeado()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idEmpleado, nombre FROM empleado order BY Nombre");
            comboBox12.ValueMember = "idEmpleado";
            comboBox12.DisplayMember = "Nombre";
            comboBox12.DataSource = dt3;
        }
        private void alumno()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idAlumnos, Nombre FROM alumnos order BY Nombre");
            comboBox10.ValueMember = "idAlumnos";
            comboBox10.DisplayMember = "Nombre";
            comboBox10.DataSource = dt3;
        }
        private void Turno()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idTurno, Turno FROM turno order BY Turno");
            comboBox13.ValueMember = "idTurno";
            comboBox13.DisplayMember = "Turno";
            comboBox13.DataSource = dt3;
        }

        private void lVAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void llenarlvAlumnos()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT * FROM alumnos order BY Nombre");
            lVAlumnos.Items.Clear();
            foreach (DataRow row in dt3.Rows)
            {
                ListViewItem item = new ListViewItem(row["idAlumnos"].ToString());
                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add(row["Matricula"].ToString());
                item.SubItems.Add(row["NombreTutor"].ToString());
                item.SubItems.Add(row["Tel_Tutor"].ToString());
                item.SubItems.Add(row["idGrado"].ToString());
                item.SubItems.Add(row["idGrupo"].ToString());
                item.SubItems.Add(row["turno_idTurno"].ToString());
                lVAlumnos.Items.Add(item);
            }
        }
    }
}
