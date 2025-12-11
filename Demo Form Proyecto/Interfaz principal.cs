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
        private void Cleralltxtbox()
        {
            TxtFalta.Clear();
            TxtMatricula.Clear();
            TxtNombre.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear(); 
            textBox17.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            
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
            Dock = DockStyle.Fill;
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
            Dock = DockStyle.Fill;
        }

        private void Interfaz_principal_Load(object sender, EventArgs e)
        {
            Clsconexion cone = new Clsconexion();

            textBox16.UseSystemPasswordChar = true;
            try
            {
                cargarbd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
            string Sql = "INSERT INTO empleado VALUES(null,'" + textBox6.Text + "','" + textBox3.Text + "','" + comboBox4.SelectedValue + "')";
            cone.Ejecutar(Sql);
            MessageBox.Show(Sql);
            MessageBox.Show("Se Guardo el usuario" + textBox3.Text, "LISTO!", MessageBoxButtons.OK);
            Actualisardb();
            Cleralltxtbox();
        }


        private void button8_Click(object sender, EventArgs e)
        {

            Clsconexion cone = new Clsconexion();
            string Sql = "DELETE FROM empleado WHERE NumEmpleado =" + textBox6.Text;
            cone.Ejecutar(Sql);
            MessageBox.Show("Se elimino el usuario");
            Actualisardb();
            Cleralltxtbox();
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
            DataTable dt3 = cone.Desplegar("SELECT idEmpleado, NombreEmpleado FROM empleado order BY NombreEmpleado");
            comboBox11.ValueMember = "idEmpleado";
            comboBox11.DisplayMember = "NombreEmpleado";
            comboBox11.DataSource = dt3;


        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == textBox17.Text)
            {
                Clsconexion cone = new Clsconexion();
                string Sql = "INSERT INTO cuenta VALUES(null,'" + textBox15.Text + "','" + textBox17.Text + "','" + comboBox11.SelectedValue + "')";
                cone.Ejecutar(Sql);
                MessageBox.Show("Se Guardo el usuario" + textBox16.Text, "LISTO!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Actualisardb();
            Cleralltxtbox();
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
            string Sql = "INSERT INTO alumnos VALUES(null,'" + textBox4.Text + "','" + TxtMatricula.Text + "','" + textBox14.Text + "','" + textBox7.Text + "','" + comboBox5.SelectedValue + "','" + comboBox6.SelectedValue + "','" + comboBox13.SelectedValue + "')";
            cone.Ejecutar(Sql);
            MessageBox.Show("Se Guardo el ALUMNO " + textBox4.Text, "LISTO!", MessageBoxButtons.OK);
            Actualisardb();
            Cleralltxtbox();
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
            string fechaSQL = Genfecha.Value.ToString("yyyy-MM-dd");
            Clsconexion cone = new Clsconexion();
            string Sql = "INSERT INTO reporte VALUES(null,'" + fechaSQL + "','" + comboBox2.SelectedValue + "','" + comboBox1.SelectedValue + "','" + comboBox12.SelectedValue + "','" + comboBox10.SelectedValue + "','" + comboBox3.SelectedValue + "','" + TxtFalta.Text + "')";
            cone.Ejecutar(Sql);
            MessageBox.Show("Reporte generado con exito" + textBox4.Text, "LISTO!", MessageBoxButtons.OK);
            Actualisardb();
            Cleralltxtbox();
        }
        private void Templeado()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idEmpleado, NombreEmpleado FROM empleado order BY NombreEmpleado");
            comboBox12.ValueMember = "idEmpleado";
            comboBox12.DisplayMember = "NombreEmpleado";
            comboBox12.DataSource = dt3;
        }
        private void alumno()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT idAlumnos, NombreAlumnos FROM alumnos order BY NombreAlumnos");
            comboBox10.ValueMember = "idAlumnos";
            comboBox10.DisplayMember = "NombreAlumnos";
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
            DataTable dt3 = cone.Desplegar("SELECT * FROM vista_alumnos order BY NombreAlumnos");
            lVAlumnos.Items.Clear();
            foreach (DataRow row in dt3.Rows)
            {
                ListViewItem item = new ListViewItem(row["NombreAlumnos"].ToString());
                item.SubItems.Add(row["Matricula"].ToString());
                item.SubItems.Add(row["NombreTutor"].ToString());
                item.SubItems.Add(row["Tel_Tutor"].ToString());
                item.SubItems.Add(row["NombreGrado"].ToString());
                item.SubItems.Add(row["NombreGrupo"].ToString());
                item.SubItems.Add(row["NombreTurno"].ToString());
                lVAlumnos.Items.Add(item);
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Actualisardb()
        {
            User();
            Templeado();
            alumno();
            llenarlvAlumnos();
            llenLV1();
            llenarlvactu();
            llenlvempleados();
        }

        private void llenLV1()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt = cone.Desplegar("SELECT * FROM vista_alumnos order BY NombreAlumnos");
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["NombreAlumnos"].ToString());
                item.SubItems.Add(row["Matricula"].ToString());
                item.SubItems.Add(row["NombreTutor"].ToString());
                item.SubItems.Add(row["Tel_Tutor"].ToString());
                item.SubItems.Add(row["NombreGrado"].ToString());
                item.SubItems.Add(row["NombreGrupo"].ToString());
                item.SubItems.Add(row["NombreTurno"].ToString());
                lVAlumno.Items.Add(item);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ocultar_panel();
            panel4.Visible = true;
            panel4.BringToFront();
            Dock = DockStyle.Fill;
        }

        private void LVReportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ActulvReportes()
        {


            Clsconexion cone = new Clsconexion();
            DataTable dt = cone.Desplegar("SELECT * FROM vista_reportes_detallado WHERE alumno = " + "('" + TxtNombre.Text + "')" + " order BY FechaReporte DESC");
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["idReporte"].ToString());
                LVReportes.View = View.Details;
                LVReportes.FullRowSelect = true;
                LVReportes.GridLines = true;


                LVReportes.Items.Clear();
                item.SubItems.Add(row["fechaReporte"].ToString());
                item.SubItems.Add(row["alumno"].ToString());
                item.SubItems.Add(row["grado"].ToString());
                item.SubItems.Add(row["grupo"].ToString());
                item.SubItems.Add(row["empleado"].ToString());
                item.SubItems.Add(row["tipo_falta"].ToString());
                item.SubItems.Add(row["Quepaso"].ToString());
                LVReportes.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActulvReportes();
            Cleralltxtbox();

        }
        private void llenarlvactu()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt = cone.Desplegar("SELECT * FROM vista_reportes_detallado order BY FechaReporte DESC");
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["idReporte"].ToString());
                item.SubItems.Add(row["fechaReporte"].ToString());
                item.SubItems.Add(row["alumno"].ToString());
                item.SubItems.Add(row["grado"].ToString());
                item.SubItems.Add(row["grupo"].ToString());
                item.SubItems.Add(row["empleado"].ToString());
                item.SubItems.Add(row["tipo_falta"].ToString());
                item.SubItems.Add(row["Quepaso"].ToString());
                LVReportes.Items.Add(item);
            }
        }
        private void llenlvempleados()
        {
            Clsconexion cone = new Clsconexion();
            DataTable dt3 = cone.Desplegar("SELECT NombreEmpleado,NumEmpleado,Funcion FROM vistaEmpleados order BY NombreEmpleado");
            listView2.Items.Clear();
            foreach (DataRow row in dt3.Rows)
            {
                ListViewItem item = new ListViewItem(row["NumEmpleado"].ToString());
                item.SubItems.Add(row["NombreEmpleado"].ToString());
                item.SubItems.Add(row["Funcion"].ToString());
                listView2.Items.Add(item);
            }
        }
        private void cargarbd()
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
            llenLV1();
            llenarlvactu();
            llenlvempleados();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clsconexion cone = new Clsconexion();
            string Sql = "DELETE FROM alumnos WHERE Matricula =" + TxtMatricula.Text;
            cone.Ejecutar(Sql);
            MessageBox.Show("Se elimino el alumno");
            Actualisardb();
            Cleralltxtbox();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
