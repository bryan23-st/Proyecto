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

namespace Proyecto
{
    public partial class RegistroUsuario : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H6JOJ1AH\\SQLEXPRESS;Initial Catalog=Supermercado;Integrated Security=True");

        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void carga_tipousu()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select tusu_id, tusu_nombre from Tbl_TipoUsuario where tusu_estado = 'A'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dt.Columns.Add("tusu_id", typeof(int));
                dt.Columns.Add("tusu_nombre", typeof(string));
                dt.Rows.Add(0, "Seleccione");
                sda.Fill(dt);
                con.Close();

                cmb_rol.DataSource = dt;
                cmb_rol.DisplayMember = "tusu_nombre";
                cmb_rol.ValueMember = "tusu_id";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            carga_tipousu();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void limpiar()
        {
            txt_nombre.Text = txt_cedula.Text  = txt_nick.Text = txt_pass.Text = txt_direc.Text = txt_correo.Text = "";
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Tbl_Usuario values(@nombre, @cedula, @nick, @pass, @direccion, @correo, @tusu,'A')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txt_nombre.Text.Trim());
                cmd.Parameters.AddWithValue("@cedula", txt_cedula.Text.Trim());
                cmd.Parameters.AddWithValue("@nick", txt_nick.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", txt_pass.Text.Trim());
                cmd.Parameters.AddWithValue("@direccion", txt_direc.Text.Trim());
                cmd.Parameters.AddWithValue("@correo", txt_correo.Text.Trim());
                cmd.Parameters.AddWithValue("@tusu", Convert.ToInt32(cmb_rol.SelectedValue));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario registrado exitosamente");
                limpiar();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
