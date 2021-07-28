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
    public partial class Invitado : Form
    {
        public Invitado()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openPanelCentral(Form panel)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = panel;
            panel.TopLevel = false;
            panel.FormBorderStyle = FormBorderStyle.None;
            panel.Dock = DockStyle.Fill;
            panelcentral.Controls.Add(panel);
            panelcentral.Tag = panel;
            panel.BringToFront();
            panel.Show();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openPanelCentral(new RegistroUsuario());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openPanelCentral(new Negocio());
        }
    }
}
