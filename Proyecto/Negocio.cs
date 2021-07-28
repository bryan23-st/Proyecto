using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Negocio : Form
    {
        public Negocio()
        {
            InitializeComponent();
        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_categoria.SelectedItem.Equals("Embutidos"))
            {
                embuti.Visible = true;
                bebidas.Visible = false;
                snacks.Visible = false;
            }
            else
            {
                if (cmb_categoria.SelectedItem.Equals("Bebidas"))
                {
                    bebidas.Visible = true;
                    embuti.Visible = false;
                    snacks.Visible = false;

                }
                else
                {
                    if (cmb_categoria.SelectedItem.Equals("Snacks"))
                    {
                        snacks.Visible = true;
                        bebidas.Visible = false;
                        embuti.Visible = false;
                    }
                }
            }
        }

        private void Negocio_Load(object sender, EventArgs e)
        {
            embuti.Visible = true;
            snacks.Visible = false;
            bebidas.Visible = false;
        }

        private void cmb_nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_nombre.SelectedItem.Equals("Coca Cola"))
            {
                cocacola.Visible = true;
                sprite.Visible = false;
                fanta.Visible = false;
            }
            else
            {
                if (cmb_nombre.SelectedItem.Equals("Sprite"))
                {
                    sprite.Visible = true;
                    cocacola.Visible = false;
                    fanta.Visible = false;

                }
                else
                {
                    if (cmb_nombre.SelectedItem.Equals("Fanta"))
                    {
                        fanta.Visible = true;
                        cocacola.Visible = false;
                        sprite.Visible = false;
                    }
                }
            }
        }
    }
}
