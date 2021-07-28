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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-H6JOJ1AH\\SQLEXPRESS;Initial Catalog=Supermercado;Integrated Security=True");
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void login(string nombre, string pass)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Usuario where usu_nomlogin = @nom and usu_password=@pas ", con);
                cmd.Parameters.AddWithValue("nom", nombre);
                cmd.Parameters.AddWithValue("pas", pass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select usu_nombre , tusu_id, usu_cedula from Tbl_Usuario where usu_nomlogin = @nom and usu_password = @pas", con);
                    cmd1.Parameters.AddWithValue("nom", nombre);
                    cmd1.Parameters.AddWithValue("pas", pass);
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    con.Close();

                    if (dt1.Rows.Count == 1)
                    {
                        
                        this.Hide();
                        if (dt1.Rows[0][1].ToString() == "1")
                        {
                            MessageBox.Show("Sea bienvenido al sistema Admin " + "-" + dt1.Rows[0][0].ToString() + "-" + dt1.Rows[0][2].ToString());
                            new Adminis().ShowDialog();
                        }
                        else if (dt1.Rows[0][1].ToString() == "2")
                        {
                            MessageBox.Show("Bienvenido al sistema Usuario " + "-" + dt1.Rows[0][0].ToString() + "-" + dt1.Rows[0][2].ToString());
                            new Invitado().ShowDialog();
                        }
                        this.Close();
                    }
                }
                else
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select usu_nombre , usu_estado from Tbl_Usuario where usu_nomlogin = @nom and usu_password = @pas", con);
                    cmd1.Parameters.AddWithValue("nom", nombre);
                    cmd1.Parameters.AddWithValue("pas", pass);
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    con.Close();

                    MessageBox.Show("Usuario no se encuentra registrado");
                    contador += 1;
                    lbl_intentos.Text = contador.ToString();

                    if (contador > 2)
                    {
                        con.Open();
                        SqlCommand cmdo = new SqlCommand("UPDATE Tbl_Usuario SET usu_estado='B' WHERE usu_nomlogin=@nom", con);
                        cmdo.Parameters.AddWithValue("@nom", nombre);
                        SqlDataAdapter sdao = new SqlDataAdapter(cmdo);
                        DataTable dto = new DataTable();
                        sdao.Fill(dto);
                        con.Close();
                        MessageBox.Show("Ingreso valores erroneos en varios intentos" + "," + nombre + "," + " a sido bloqueado");
                        Application.Exit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            login(txt_usuario.Text, txt_contraseña.Text);
        }

        private void btn_registarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistroUsuario().ShowDialog();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
