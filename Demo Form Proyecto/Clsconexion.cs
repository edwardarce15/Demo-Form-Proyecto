using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Demo_Form_Proyecto
{
    internal class Clsconexion
    {
        public static MySqlConnection Con;
        public void Conectarse()
        {
            try
            {
                Con = new MySqlConnection();
                Con.ConnectionString = "server=69.6.201.17; database=afcbemis_SecundariaTecnica; Uid=afcbemis; pwd=isoft1106.Proyectos; ";
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
